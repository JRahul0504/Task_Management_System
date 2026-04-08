# 🚀 Order Management System API

A production-ready ASP.NET Core Web API built using Clean Architecture principles.

---

## 📌 Features

- ✅ Clean Architecture
- ✅ Repository Pattern
- ✅ DTO + AutoMapper
- ✅ FluentValidation
- ✅ Global Exception Handling
- ✅ ILogger Logging
- ✅ JWT Authentication
- ✅ Role-based Authorization (Admin/User)
- ✅ Full CRUD Operations

---

## 🧱 Project Structure

OrderManagementSystem/
│
├── OrderManagement.API
├── OrderManagement.Application
├── OrderManagement.Domain
├── OrderManagement.Infrastructure

---

## ⚙️ Technologies Used

- .NET 8 Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- AutoMapper
- FluentValidation

---

## 🔐 Authentication

- Login API generates JWT Token
- Token required for all endpoints
- Role-based access:
  - Admin → Create, Delete
  - User → Read

---

## 📦 API Endpoints

### 🔹 Auth

POST /api/auth/login?username=admin

---

### 🔹 Orders

GET /api/order  
POST /api/order (Admin only)  
PUT /api/order/{id}  
DELETE /api/order/{id} (Admin only)  

---

## 🧪 How to Run

1. Clone repository:
2. Open in Visual Studio
3. Update connection string in:
4. Run migration:
5. Run project:
6. 
---

## 🧪 Testing (Postman)

1. Call Login API → Get Token  
2. Add token in Authorization → Bearer  
3. Call Order APIs  

---

## 📌 Author

Your Name
Rahul Jatve
