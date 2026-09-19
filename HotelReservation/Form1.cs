using System.Text.RegularExpressions;

namespace HotelReservation
{
    public partial class Form1 : Form
    {
        private const int NationalIdLength = 10;
        private const int MinPhoneDigits = 9;
        private const decimal DiscountRate = 0.05m;
        private const decimal TaxRate = 0.16m;
        private const decimal LaundryCost = 5m;
        private const decimal ParkingCost = 5m;
        private const decimal LunchCostPerPersonPerDay = 10m;
        private const decimal InternetCost = 10m;

        private static readonly Dictionary<string, (decimal PricePerNight, int MaxGuests)> RoomCatalog = new()
        {
            ["Single Room"] = (45m, 2),
            ["Double Room"] = (75m, 4),
            ["Suite"] = (140m, 4),
            ["VIP Suite"] = (250m, 6)
        };

        public Form1()
        {
            InitializeComponent();
            ResetForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAllInputs(out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nights = (int)numNights.Value;
                int guests = (int)numGuests.Value;
                string roomType = cmbRoomType.SelectedItem!.ToString()!;
                var roomInfo = RoomCatalog[roomType];

                var roomCosts = CalculateRoomCosts(roomInfo.PricePerNight, nights);
                decimal servicesTotal = CalculateOptionalServices(nights, guests);
                decimal finalTotal = roomCosts.RoomAfterTax + servicesTotal;

                UpdateSummaryLabels(roomCosts, servicesTotal, finalTotal);
                ShowConfirmationMessage(roomType, nights, finalTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected error occurred: {ex.Message}\nPlease check your input and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
            MessageBox.Show(
                "The reservation has been cancelled.",
                "Reservation Cancelled",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool ValidateAllInputs(out string errorMessage)
        {
            if (!ValidateCustomerInfo(out errorMessage))
            {
                return false;
            }

            if (!ValidateReservationDetails(out errorMessage))
            {
                return false;
            }

            return true;
        }

        private bool ValidateCustomerInfo(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNationalId.Text))
            {
                errorMessage = "National ID is required.";
                txtNationalId.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtNationalId.Text.Trim(), @"^\d+$"))
            {
                errorMessage = "National ID must contain numeric digits only.";
                txtNationalId.Focus();
                return false;
            }

            if (txtNationalId.Text.Trim().Length != NationalIdLength)
            {
                errorMessage = $"National ID must be exactly {NationalIdLength} digits.";
                txtNationalId.Focus();
                return false;
            }

            if (!ValidateNameField(txtFirstName, "First Name", out errorMessage)) return false;
            if (!ValidateNameField(txtSecondName, "Second Name", out errorMessage)) return false;
            if (!ValidateNameField(txtFamilyName, "Family Name", out errorMessage)) return false;

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorMessage = "Phone Number is required.";
                txtPhone.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d+$"))
            {
                errorMessage = "Phone Number must contain numeric digits only.";
                txtPhone.Focus();
                return false;
            }

            if (txtPhone.Text.Trim().Length < MinPhoneDigits)
            {
                errorMessage = $"Phone Number must be at least {MinPhoneDigits} digits.";
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorMessage = "Address is required.";
                txtAddress.Focus();
                return false;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                errorMessage = "Please select a gender (Male or Female).";
                grpGender.Focus();
                return false;
            }

            return true;
        }

        private static bool ValidateNameField(TextBox textBox, string fieldLabel, out string errorMessage)
        {
            errorMessage = string.Empty;
            string value = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(value))
            {
                errorMessage = $"{fieldLabel} is required.";
                textBox.Focus();
                return false;
            }

            if (!Regex.IsMatch(value, @"^[a-zA-Z\s]+$"))
            {
                errorMessage = $"{fieldLabel} must contain alphabetic characters only (spaces allowed for compound names).";
                textBox.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateReservationDetails(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (cmbRoomType.SelectedIndex < 0)
            {
                errorMessage = "Please select a room type.";
                cmbRoomType.Focus();
                return false;
            }

            int nights;
            int guests;

            try
            {
                nights = (int)numNights.Value;
                guests = (int)numGuests.Value;
            }
            catch (Exception)
            {
                errorMessage = "Number of nights and guests must be valid positive integers.";
                return false;
            }

            if (nights <= 0)
            {
                errorMessage = "Number of nights must be greater than zero.";
                numNights.Focus();
                return false;
            }

            if (guests <= 0)
            {
                errorMessage = "Number of guests must be greater than zero.";
                numGuests.Focus();
                return false;
            }

            string roomType = cmbRoomType.SelectedItem!.ToString()!;
            int maxCapacity = RoomCatalog[roomType].MaxGuests;

            if (guests > maxCapacity)
            {
                errorMessage = "Number of guests exceeds maximum capacity for this room type.";
                numGuests.Focus();
                return false;
            }

            return true;
        }

        private static (decimal BaseCost, decimal DiscountAmount, decimal TaxAmount, decimal RoomAfterTax)
            CalculateRoomCosts(decimal pricePerNight, int nights)
        {
            decimal baseCost = pricePerNight * nights;
            decimal discountAmount = baseCost * DiscountRate;
            decimal costAfterDiscount = baseCost - discountAmount;
            decimal taxAmount = costAfterDiscount * TaxRate;
            decimal roomAfterTax = costAfterDiscount + taxAmount;

            return (baseCost, discountAmount, taxAmount, roomAfterTax);
        }

        private decimal CalculateOptionalServices(int nights, int guests)
        {
            decimal total = 0m;

            if (chkLaundry.Checked)
            {
                total += LaundryCost;
            }

            if (chkParking.Checked)
            {
                total += ParkingCost;
            }

            if (chkLunch.Checked)
            {
                total += LunchCostPerPersonPerDay * guests * nights;
            }

            if (chkInternet.Checked)
            {
                total += InternetCost;
            }

            return total;
        }

        private void UpdateSummaryLabels(
            (decimal BaseCost, decimal DiscountAmount, decimal TaxAmount, decimal RoomAfterTax) roomCosts,
            decimal servicesTotal,
            decimal finalTotal)
        {
            lblBaseCost.Text = FormatCurrency(roomCosts.BaseCost);
            lblDiscount.Text = FormatCurrency(roomCosts.DiscountAmount);
            lblTax.Text = FormatCurrency(roomCosts.TaxAmount);
            lblServicesTotal.Text = FormatCurrency(servicesTotal);
            lblFinalTotal.Text = FormatCurrency(finalTotal);
        }

        private void ShowConfirmationMessage(string roomType, int nights, decimal finalTotal)
        {
            string fullName = $"{txtFirstName.Text.Trim()} {txtSecondName.Text.Trim()} {txtFamilyName.Text.Trim()}";

            string message =
                "Reservation confirmed successfully!\n\n" +
                $"Customer: {fullName}\n" +
                $"Room Type: {roomType}\n" +
                $"Number of Nights: {nights}\n" +
                $"Final Total Cost: {FormatCurrency(finalTotal)}\n\n" +
                "Please proceed to the cashier or payment desk to complete your payment.";

            MessageBox.Show(message, "Reservation Confirmed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetForm()
        {
            txtNationalId.Clear();
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtFamilyName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cmbRoomType.SelectedIndex = -1;
            numNights.Value = 1;
            numGuests.Value = 1;
            chkLaundry.Checked = false;
            chkParking.Checked = false;
            chkLunch.Checked = false;
            chkInternet.Checked = false;

            lblBaseCost.Text = FormatCurrency(0m);
            lblDiscount.Text = FormatCurrency(0m);
            lblTax.Text = FormatCurrency(0m);
            lblServicesTotal.Text = FormatCurrency(0m);
            lblFinalTotal.Text = FormatCurrency(0m);
        }

        private static string FormatCurrency(decimal amount) => $"{amount:F2} JD";

        private void txtNationalId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
