# 🛒 E-Commerce Console Application (.NET 10 & EF Core)

A robust, well-structured C# Console Application demonstrating modern backend database design and management using **Entity Framework Core**, **SQL Server**, and **Bogus** for data seeding.

---

## 🌟 Key Features

- **Entity Framework Core Integration**: Code-First approach with SQL Server.
- **Relational Database Design**: Implements One-to-One, One-to-Many, and Many-to-Many relationships:
  - `User` ↔ `UserProfile` (One-to-One)
  - `Category` ↔ `Product` (One-to-Many)
  - `Order` ↔ `Product` via `OrderItem` (Many-to-Many)
- **Data Seeding with Bogus**: Automated generation of realistic fake users, profiles, emails, and Egyptian phone numbers.
- **Clean N-Tier Architecture**: Modular folder separation (`DataBase`, `Models`, `Migrations`).
- **LINQ & EF Core Queries**: Eager loading using `.Include()` to query related entities efficiently.

---

## 🛠️ Tech Stack & Tools

- **Language**: C# (.NET 10.0)
- **ORM**: Entity Framework Core 10.0
- **Database**: Microsoft SQL Server
- **Tools**: Visual Studio 2022, SSMS, Package Manager Console
- **NuGet Packages**:
  - `Microsoft.EntityFrameworkCore.SqlServer`
  - `Microsoft.EntityFrameworkCore.Tools`
  - `Bogus` (Data Generation)

---

## 📁 Project Structure

```text
E-Commerce Console Application/
├── DataBase/
│   └── ApplictionDbContext.cs
├── Models/
│   ├── User.cs
│   ├── UserProfile.cs
│   ├── Category.cs
│   ├── Product.cs
│   └── Order.cs
│   └── OrderItem.cs
├── Migrations/
└── Program.cs
---

👨‍💻 **Developed by Ali Ibrahim Ali**
*Backend Software Developer specializing in C#, .NET, and SQL Server.*
