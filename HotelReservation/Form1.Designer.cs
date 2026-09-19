namespace HotelReservation
{
    public partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpCustomer = new GroupBox();
            lblNationalId = new Label();
            txtNationalId = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblSecondName = new Label();
            txtSecondName = new TextBox();
            lblFamilyName = new Label();
            txtFamilyName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            grpGender = new GroupBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            grpRoom = new GroupBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblNights = new Label();
            numNights = new NumericUpDown();
            lblGuests = new Label();
            numGuests = new NumericUpDown();
            grpServices = new GroupBox();
            chkLaundry = new CheckBox();
            chkParking = new CheckBox();
            chkLunch = new CheckBox();
            chkInternet = new CheckBox();
            grpSummary = new GroupBox();
            lblBaseCostCaption = new Label();
            lblBaseCost = new Label();
            lblDiscountCaption = new Label();
            lblDiscount = new Label();
            lblTaxCaption = new Label();
            lblTax = new Label();
            lblServicesCaption = new Label();
            lblServicesTotal = new Label();
            lblFinalCaption = new Label();
            lblFinalTotal = new Label();
            btnConfirm = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            grpCustomer.SuspendLayout();
            grpGender.SuspendLayout();
            grpRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
            grpServices.SuspendLayout();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(lblNationalId);
            grpCustomer.Controls.Add(txtNationalId);
            grpCustomer.Controls.Add(lblFirstName);
            grpCustomer.Controls.Add(txtFirstName);
            grpCustomer.Controls.Add(lblSecondName);
            grpCustomer.Controls.Add(txtSecondName);
            grpCustomer.Controls.Add(lblFamilyName);
            grpCustomer.Controls.Add(txtFamilyName);
            grpCustomer.Controls.Add(lblPhone);
            grpCustomer.Controls.Add(txtPhone);
            grpCustomer.Controls.Add(lblAddress);
            grpCustomer.Controls.Add(txtAddress);
            grpCustomer.Controls.Add(grpGender);
            grpCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpCustomer.Location = new Point(14, 16);
            grpCustomer.Margin = new Padding(3, 4, 3, 4);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Padding = new Padding(3, 4, 3, 4);
            grpCustomer.Size = new Size(526, 427);
            grpCustomer.TabIndex = 0;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Customer Information";
            // 
            // lblNationalId
            // 
            lblNationalId.AutoSize = true;
            lblNationalId.Font = new Font("Segoe UI", 9F);
            lblNationalId.Location = new Point(18, 43);
            lblNationalId.Name = "lblNationalId";
            lblNationalId.Size = new Size(88, 20);
            lblNationalId.TabIndex = 0;
            lblNationalId.Text = "National ID:";
            // 
            // txtNationalId
            // 
            txtNationalId.Font = new Font("Segoe UI", 9F);
            txtNationalId.Location = new Point(149, 37);
            txtNationalId.Margin = new Padding(3, 4, 3, 4);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(342, 27);
            txtNationalId.TabIndex = 1;
            txtNationalId.TextChanged += txtNationalId_TextChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F);
            lblFirstName.Location = new Point(18, 91);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.Location = new Point(149, 85);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(342, 27);
            txtFirstName.TabIndex = 2;
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Font = new Font("Segoe UI", 9F);
            lblSecondName.Location = new Point(18, 139);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(105, 20);
            lblSecondName.TabIndex = 4;
            lblSecondName.Text = "Second Name:";
            // 
            // txtSecondName
            // 
            txtSecondName.Font = new Font("Segoe UI", 9F);
            txtSecondName.Location = new Point(149, 133);
            txtSecondName.Margin = new Padding(3, 4, 3, 4);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(342, 27);
            txtSecondName.TabIndex = 3;
            // 
            // lblFamilyName
            // 
            lblFamilyName.AutoSize = true;
            lblFamilyName.Font = new Font("Segoe UI", 9F);
            lblFamilyName.Location = new Point(18, 187);
            lblFamilyName.Name = "lblFamilyName";
            lblFamilyName.Size = new Size(98, 20);
            lblFamilyName.TabIndex = 6;
            lblFamilyName.Text = "Family Name:";
            // 
            // txtFamilyName
            // 
            txtFamilyName.Font = new Font("Segoe UI", 9F);
            txtFamilyName.Location = new Point(149, 181);
            txtFamilyName.Margin = new Padding(3, 4, 3, 4);
            txtFamilyName.Name = "txtFamilyName";
            txtFamilyName.Size = new Size(342, 27);
            txtFamilyName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.Location = new Point(18, 235);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 20);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.Location = new Point(149, 229);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(342, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.Location = new Point(18, 283);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(149, 277);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(342, 73);
            txtAddress.TabIndex = 6;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbMale);
            grpGender.Controls.Add(rbFemale);
            grpGender.Font = new Font("Segoe UI", 9F);
            grpGender.Location = new Point(149, 360);
            grpGender.Margin = new Padding(3, 4, 3, 4);
            grpGender.Name = "grpGender";
            grpGender.Padding = new Padding(3, 4, 3, 4);
            grpGender.Size = new Size(343, 53);
            grpGender.TabIndex = 7;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(18, 21);
            rbMale.Margin = new Padding(3, 4, 3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 0;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(137, 21);
            rbFemale.Margin = new Padding(3, 4, 3, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // grpRoom
            // 
            grpRoom.Controls.Add(lblRoomType);
            grpRoom.Controls.Add(cmbRoomType);
            grpRoom.Controls.Add(lblNights);
            grpRoom.Controls.Add(numNights);
            grpRoom.Controls.Add(lblGuests);
            grpRoom.Controls.Add(numGuests);
            grpRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpRoom.Location = new Point(558, 16);
            grpRoom.Margin = new Padding(3, 4, 3, 4);
            grpRoom.Name = "grpRoom";
            grpRoom.Padding = new Padding(3, 4, 3, 4);
            grpRoom.Size = new Size(411, 213);
            grpRoom.TabIndex = 1;
            grpRoom.TabStop = false;
            grpRoom.Text = "Room and Reservation";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F);
            lblRoomType.Location = new Point(18, 48);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(87, 20);
            lblRoomType.TabIndex = 0;
            lblRoomType.Text = "Room Type:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Font = new Font("Segoe UI", 9F);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single Room", "Double Room", "Suite", "VIP Suite" });
            cmbRoomType.Location = new Point(171, 43);
            cmbRoomType.Margin = new Padding(3, 4, 3, 4);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(217, 28);
            cmbRoomType.TabIndex = 0;
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Font = new Font("Segoe UI", 9F);
            lblNights.Location = new Point(18, 96);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(131, 20);
            lblNights.TabIndex = 2;
            lblNights.Text = "Number of Nights:";
            // 
            // numNights
            // 
            numNights.Font = new Font("Segoe UI", 9F);
            numNights.Location = new Point(171, 91);
            numNights.Margin = new Padding(3, 4, 3, 4);
            numNights.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numNights.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNights.Name = "numNights";
            numNights.Size = new Size(137, 27);
            numNights.TabIndex = 1;
            numNights.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Segoe UI", 9F);
            lblGuests.Location = new Point(18, 144);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(131, 20);
            lblGuests.TabIndex = 4;
            lblGuests.Text = "Number of Guests:";
            // 
            // numGuests
            // 
            numGuests.Font = new Font("Segoe UI", 9F);
            numGuests.Location = new Point(171, 139);
            numGuests.Margin = new Padding(3, 4, 3, 4);
            numGuests.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(137, 27);
            numGuests.TabIndex = 2;
            numGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpServices
            // 
            grpServices.Controls.Add(chkLaundry);
            grpServices.Controls.Add(chkParking);
            grpServices.Controls.Add(chkLunch);
            grpServices.Controls.Add(chkInternet);
            grpServices.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpServices.Location = new Point(558, 245);
            grpServices.Margin = new Padding(3, 4, 3, 4);
            grpServices.Name = "grpServices";
            grpServices.Padding = new Padding(3, 4, 3, 4);
            grpServices.Size = new Size(411, 197);
            grpServices.TabIndex = 2;
            grpServices.TabStop = false;
            grpServices.Text = "Optional Services";
            // 
            // chkLaundry
            // 
            chkLaundry.AutoSize = true;
            chkLaundry.Font = new Font("Segoe UI", 9F);
            chkLaundry.Location = new Point(23, 43);
            chkLaundry.Margin = new Padding(3, 4, 3, 4);
            chkLaundry.Name = "chkLaundry";
            chkLaundry.Size = new Size(132, 24);
            chkLaundry.TabIndex = 0;
            chkLaundry.Text = "Laundry service";
            chkLaundry.UseVisualStyleBackColor = true;
            // 
            // chkParking
            // 
            chkParking.AutoSize = true;
            chkParking.Font = new Font("Segoe UI", 9F);
            chkParking.Location = new Point(23, 80);
            chkParking.Margin = new Padding(3, 4, 3, 4);
            chkParking.Name = "chkParking";
            chkParking.Size = new Size(128, 24);
            chkParking.TabIndex = 1;
            chkParking.Text = "Parking service";
            chkParking.UseVisualStyleBackColor = true;
            // 
            // chkLunch
            // 
            chkLunch.AutoSize = true;
            chkLunch.Font = new Font("Segoe UI", 9F);
            chkLunch.Location = new Point(23, 117);
            chkLunch.Margin = new Padding(3, 4, 3, 4);
            chkLunch.Name = "chkLunch";
            chkLunch.Size = new Size(118, 24);
            chkLunch.TabIndex = 2;
            chkLunch.Text = "Lunch service";
            chkLunch.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            chkInternet.AutoSize = true;
            chkInternet.Font = new Font("Segoe UI", 9F);
            chkInternet.Location = new Point(23, 155);
            chkInternet.Margin = new Padding(3, 4, 3, 4);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(131, 24);
            chkInternet.TabIndex = 3;
            chkInternet.Text = "Internet service";
            chkInternet.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblBaseCostCaption);
            grpSummary.Controls.Add(lblBaseCost);
            grpSummary.Controls.Add(lblDiscountCaption);
            grpSummary.Controls.Add(lblDiscount);
            grpSummary.Controls.Add(lblTaxCaption);
            grpSummary.Controls.Add(lblTax);
            grpSummary.Controls.Add(lblServicesCaption);
            grpSummary.Controls.Add(lblServicesTotal);
            grpSummary.Controls.Add(lblFinalCaption);
            grpSummary.Controls.Add(lblFinalTotal);
            grpSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpSummary.Location = new Point(14, 459);
            grpSummary.Margin = new Padding(3, 4, 3, 4);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(3, 4, 3, 4);
            grpSummary.Size = new Size(955, 240);
            grpSummary.TabIndex = 3;
            grpSummary.TabStop = false;
            grpSummary.Text = "Cost Summary";
            // 
            // lblBaseCostCaption
            // 
            lblBaseCostCaption.AutoSize = true;
            lblBaseCostCaption.Font = new Font("Segoe UI", 9F);
            lblBaseCostCaption.Location = new Point(23, 48);
            lblBaseCostCaption.Name = "lblBaseCostCaption";
            lblBaseCostCaption.Size = new Size(120, 20);
            lblBaseCostCaption.TabIndex = 0;
            lblBaseCostCaption.Text = "Base Room Cost:";
            // 
            // lblBaseCost
            // 
            lblBaseCost.Font = new Font("Segoe UI", 9F);
            lblBaseCost.Location = new Point(251, 48);
            lblBaseCost.Name = "lblBaseCost";
            lblBaseCost.Size = new Size(229, 20);
            lblBaseCost.TabIndex = 1;
            lblBaseCost.Text = "0.00 JD";
            // 
            // lblDiscountCaption
            // 
            lblDiscountCaption.AutoSize = true;
            lblDiscountCaption.Font = new Font("Segoe UI", 9F);
            lblDiscountCaption.Location = new Point(23, 85);
            lblDiscountCaption.Name = "lblDiscountCaption";
            lblDiscountCaption.Size = new Size(104, 20);
            lblDiscountCaption.TabIndex = 2;
            lblDiscountCaption.Text = "Discount (5%):";
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Segoe UI", 9F);
            lblDiscount.Location = new Point(251, 85);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(229, 20);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "0.00 JD";
            // 
            // lblTaxCaption
            // 
            lblTaxCaption.AutoSize = true;
            lblTaxCaption.Font = new Font("Segoe UI", 9F);
            lblTaxCaption.Location = new Point(23, 123);
            lblTaxCaption.Name = "lblTaxCaption";
            lblTaxCaption.Size = new Size(75, 20);
            lblTaxCaption.TabIndex = 4;
            lblTaxCaption.Text = "Tax (16%):";
            // 
            // lblTax
            // 
            lblTax.Font = new Font("Segoe UI", 9F);
            lblTax.Location = new Point(251, 123);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(229, 20);
            lblTax.TabIndex = 5;
            lblTax.Text = "0.00 JD";
            // 
            // lblServicesCaption
            // 
            lblServicesCaption.AutoSize = true;
            lblServicesCaption.Font = new Font("Segoe UI", 9F);
            lblServicesCaption.Location = new Point(23, 160);
            lblServicesCaption.Name = "lblServicesCaption";
            lblServicesCaption.Size = new Size(164, 20);
            lblServicesCaption.TabIndex = 6;
            lblServicesCaption.Text = "Optional Services Total:";
            // 
            // lblServicesTotal
            // 
            lblServicesTotal.Font = new Font("Segoe UI", 9F);
            lblServicesTotal.Location = new Point(251, 160);
            lblServicesTotal.Name = "lblServicesTotal";
            lblServicesTotal.Size = new Size(229, 20);
            lblServicesTotal.TabIndex = 7;
            lblServicesTotal.Text = "0.00 JD";
            // 
            // lblFinalCaption
            // 
            lblFinalCaption.AutoSize = true;
            lblFinalCaption.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFinalCaption.Location = new Point(23, 197);
            lblFinalCaption.Name = "lblFinalCaption";
            lblFinalCaption.Size = new Size(107, 25);
            lblFinalCaption.TabIndex = 8;
            lblFinalCaption.Text = "Final Total:";
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFinalTotal.Location = new Point(251, 192);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(99, 32);
            lblFinalTotal.TabIndex = 11;
            lblFinalTotal.Text = "0.00 JD";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(14, 717);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(183, 48);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm Reservation";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(215, 717);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 48);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(370, 717);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 48);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel Reservation";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.Location = new Point(855, 717);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 48);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 788);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(grpSummary);
            Controls.Add(grpServices);
            Controls.Add(grpRoom);
            Controls.Add(grpCustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Room Reservation System";
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grpRoom.ResumeLayout(false);
            grpRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNights).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox grpCustomer;
        private Label lblNationalId;
        private TextBox txtNationalId;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblSecondName;
        private TextBox txtSecondName;
        private Label lblFamilyName;
        private TextBox txtFamilyName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private GroupBox grpGender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox grpRoom;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblNights;
        private NumericUpDown numNights;
        private Label lblGuests;
        private NumericUpDown numGuests;
        private GroupBox grpServices;
        private CheckBox chkLaundry;
        private CheckBox chkParking;
        private CheckBox chkLunch;
        private CheckBox chkInternet;
        private GroupBox grpSummary;
        private Label lblBaseCostCaption;
        private Label lblBaseCost;
        private Label lblDiscountCaption;
        private Label lblDiscount;
        private Label lblTaxCaption;
        private Label lblTax;
        private Label lblServicesCaption;
        private Label lblServicesTotal;
        private Label lblFinalCaption;
        private Label lblFinalTotal;
        private Button btnConfirm;
        private Button btnClear;
        private Button btnCancel;
        private Button btnExit;
    }
}
