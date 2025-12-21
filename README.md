# 🛒 Oman Digital Shop Platform

Oman Digital Shop Platform is a web-based application built using **ASP.NET Core** and **Clean Architecture principles**.  
The system is designed to manage products, categories, orders, and users in a scalable and maintainable way.

---

## 📌 Project Overview

This project follows a layered architecture to ensure:
- Separation of concerns
- Scalability
- Easy maintenance
- Testability

---

## 🏗️ Project Structure

```bash
OmanDigitalShopPlatform
│
├── DAL.OmanDigitalShop       # Data Access Layer (Entities & Interfaces)
├── BLL.OmanDigitalShop       # Business Logic Layer (Services & Repositories)
├── PII.Api.OmanDigitalShop   # RESTful API
├── PII.MVC.OmanDigitalShop   # MVC Web Application

🧱 Architecture

DAL (Data Access Layer)
- Models
- Interfaces
- Enums

BLL (Business Logic Layer)
- ApplicationDbContext
- Generic Repository
- Business Rules

API Layer
- REST APIs
- Integration with BLL

MVC Layer
- User Interface
- ViewModels
- Controllers

💾 Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Clean Architecture
- Repository Pattern
- MVC
- REST API


🚀 Features
- Product Management
- Category Management
- Order Handling
- User Management
- Database Migration using EF Core
- Generic Repository Pattern

👩‍💻 Author
Hanadi
Interested in Secure Application Development & Clean Architecture
