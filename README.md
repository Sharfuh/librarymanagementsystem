# librarymanagementsystem

This is a simple Library Management System implemented using ASP.NET MVC and SQL Server.

## Table of Contents

- [Features](#features)
- [Database Structure](#database-structure)
- [Getting Started](#getting-started)
- [Contributing](#contributing)
- [License](#license)

## Features

- Book Management
- Member Management
- Checkout and Return
- Reservation System
- History and Logs
- Fine Management
- Notifications
- Reporting
- Security
- User Interface

## Database Structure

### Books Table

- `BookID` (Primary Key, Identity, INT)
- `Title` (NVARCHAR(255))
- `Author` (NVARCHAR(255))
- `Genre` (NVARCHAR(100))
- `ISBN` (NVARCHAR(20))
- `PublicationDate` (DATE)
- `AvailabilityStatus` (NVARCHAR(20))

### Members Table

- `MemberID` (Primary Key, Identity, INT)
- `FirstName` (NVARCHAR(100))
- `LastName` (NVARCHAR(100))
- `ContactNumber` (NVARCHAR(20))
- `Email` (NVARCHAR(255))
- `MembershipStatus` (NVARCHAR(20))

### Transactions Table

- `TransactionID` (Primary Key, Identity, INT)
- `BookID` (Foreign Key, INT)
- `MemberID` (Foreign Key, INT)
- `TransactionDate` (DATETIME)
- `DueDate` (DATETIME)
- `ReturnDate` (DATETIME)
- `FineAmount` (DECIMAL(10, 2))

Adjust data types and constraints as per your requirements.

## Getting Started

1. Clone the repository.
2. Set up your ASP.NET MVC development environment.
3. Create the necessary database tables using the provided SQL scripts.
4. Update the connection string in `web.config`.
5. Run the application.

## Contributing

If you'd like to contribute, please fork the repository and create a pull request. You can also open an issue for any bugs or feature requests.

## License

This project is licensed under the [MIT License](LICENSE).
