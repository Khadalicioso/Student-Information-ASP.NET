# 🎓 Student Information System

<div align="center">

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue?style=for-the-badge&logo=.net)
![C#](https://img.shields.io/badge/C%23-Latest-brightgreen?style=for-the-badge&logo=c-sharp)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-purple?style=for-the-badge&logo=bootstrap)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-red?style=for-the-badge&logo=microsoft-sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)

A modern, secure, and user-friendly student information management system built with ASP.NET Core MVC.

</div>

## ✨ Features

### Core Functionality
- 🔐 Secure authentication system
- 👥 Comprehensive student management
- 📝 CRUD operations with validation
- 🎨 Modern, responsive UI
- 📱 Mobile-friendly design

### Security
- 🔒 Form-based authentication
- 🛡️ Authorization middleware
- 🔑 Secure password handling
- 🚫 XSS protection

### User Experience
- ⚡ Fast and responsive
- 🎯 Intuitive navigation
- 📊 Clean data presentation
- 💫 Modern Bootstrap design

## 🛠️ Tech Stack

### Backend
- **Framework:** ASP.NET Core 8.0
- **Language:** C# 12
- **ORM:** Entity Framework Core 8.0
- **Database:** SQL Server
- **Authentication:** Cookie-based authentication

### Frontend
- **Framework:** Bootstrap 5.3
- **Icons:** Bootstrap Icons
- **JavaScript:** jQuery
- **CSS:** Custom responsive styles

## 🚀 Prerequisites
```bash
# Required
✓ .NET 8.0 SDK
✓ SQL Server 2019+
✓ Visual Studio 2022 or VS Code
```

## 📚 Documentation

### Project Structure
```
StudentInfo/
├── Controllers/         # MVC Controllers
├── Models/             # Data & View Models
├── Views/              # Razor Views
│   ├── Accounts/      # Authentication Views
│   ├── Student/       # Student Management Views
│   └── Shared/        # Layout & Partial Views
├── Data/              # EF Core Context & Config
└── wwwroot/           # Static Files
```

### Key Features Implementation
- **Authentication:** Cookie-based auth with form login
- **Student Management:** Full CRUD with validation
- **UI/UX:** Responsive Bootstrap design
- **Security:** XSS protection, secure auth flow

## 📝 License

This project is [MIT](LICENSE) licensed.
