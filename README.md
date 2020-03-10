# TITLE OF PROJECT

#### A C#/.NET Core MVC website that helps users calculate shipping estimates, Current Version: 3/10/20

#### By Sarah "Sasa" Schwartz, Tiffany Siu

## Description

A C#/.NET Core MVC website that helps users calculate shipping estimates. The user can enter the weight and dimensions of a parcel and receive the cost of shipping in return.

## Setup/Installation Requirements

- Clone the repository to your desktop
- Open the terminal
- Make sure you are inside the Parcels directory, within the Parcels.Solution directory
- \$dotnet restore
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## Specs

- User can enter weight of parcel in lbs.
  - Sample input: User enters 10.
  - Expected output: No output until form is submitted.
- User can enter dimensions of parcel in inches.
  - Sample input: User enters 10 for height, 10 for width, and 12 for length.
  - Expected output: No output until form is submitted.
- User will receive cost of shipping estimate for parcel on submit of form.
  - Sample input: User submits form.
  - Expected output: The estimated cost of shipping is \$24.
- Error message will display on submit of form if fields were left blank.
  - Sample input: User submits form with weight missing.
  - Expected output: Please fill in all fields.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET Core MVC Framework

### License

- This software is licensed under the MIT license.
