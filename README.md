# Hotel Room Reservation System

Desktop hotel front-desk app built with **C# Windows Forms** (.NET 8).

A clerk can register a customer, pick a room type, add optional services, calculate discount and tax, and confirm the reservation.

## Features

- Customer information (National ID, names, phone, address, gender)
- Room types: Single, Double, Suite, VIP Suite (fixed price and guest capacity)
- Optional services: Laundry, Parking, Lunch, Internet
- Pricing: 5% discount before tax, then 16% tax
- Validation with clear error messages
- Buttons: Confirm Reservation, Clear, Cancel Reservation, Exit

## Requirements

- Windows
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)  
  or Visual Studio 2022 with the **.NET desktop development** workload

## How to open and run

### Visual Studio

1. Open `HotelReservation.sln`
2. Right-click `Form1.cs` → **View Designer** (or press Shift+F7)
3. Press **F5** to run

### Terminal

```bash
cd HotelReservation
dotnet run
```

## Room prices and capacity

| Room Type    | Price per night | Max guests |
|--------------|-----------------|------------|
| Single Room  | 45 JD           | 2          |
| Double Room  | 75 JD           | 4          |
| Suite        | 140 JD          | 4          |
| VIP Suite    | 250 JD          | 6          |

## Cost formula

1. Base cost = room price × nights  
2. Discount = base × 5%  
3. Tax = (base − discount) × 16%  
4. Optional services (if selected)  
5. Final total = room after discount and tax + services  

## Project structure

```
hotel-room-reservation-system/
├── HotelReservation.sln
├── README.md
└── HotelReservation/
    ├── Program.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    └── HotelReservation.csproj
```

## Notes

- Reservations are not saved to a database or file
- Room prices and capacities are fixed in code
