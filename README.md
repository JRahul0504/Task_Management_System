# 🚀 Task Management System (.NET 8 Web API)

## 📌 Project Overview

This is a **Task Management System** built using **ASP.NET Core Web API (.NET 8)** following **Clean Architecture and SOLID principles**.
The project includes **JWT Authentication**, **Role-based Authorization**, **Repository Pattern**, and **Full CRUD operations**.

It simulates a real-world backend system where users can register, log in, and manage tasks securely.

---

## 🧠 Features

* 🔐 JWT Authentication (Login & Register)
* 👤 Role-Based Authorization (Admin/User)
* 🧩 Dependency Injection (DI)
* 🗄️ Entity Framework Core (Code First)
* 🔁 Repository Pattern
* ✅ Full CRUD API (Task Management)
* 📦 DTO Pattern (Data Transfer Objects)
* 🔒 Secure Password Hashing
* 📄 Clean Architecture Structure

---

## 🏗️ Project Structure

TaskManagement.API
│
├── Controllers
│   ├── AuthController.cs
│   ├── TaskController.cs
│
├── Models
│   ├── User.cs
│   ├── TaskItem.cs
│
├── DTOs
│   ├── RegisterDto.cs
│   ├── LoginDto.cs
│   ├── TaskDto.cs
│   ├── UpdateTaskDto.cs
│
├── Data
│   ├── AppDbContext.cs
│
├── Interfaces
│   ├── ITaskRepository.cs
│
├── Repositories
│   ├── TaskRepository.cs
│
├── Services
│   ├── JwtService.cs
│   ├── PasswordService.cs
│
├── Program.cs
├── appsettings.json

---

## ⚙️ Technologies Used

* ASP.NET Core Web API (.NET 8)
* Entity Framework Core
* SQL Server
* JWT Authentication
* Dependency Injection
* C#

---

## 🔐 Authentication Flow

1. User registers → data stored in database
2. User logs in → credentials validated
3. JWT Token generated
4. Token used in API requests

Example:

Authorization: Bearer YOUR_TOKEN

---

## 🔄 API Endpoints

### 🔑 Auth APIs

| Method | Endpoint           | Description       |
| ------ | ------------------ | ----------------- |
| POST   | /api/auth/register | Register user     |
| POST   | /api/auth/login    | Login & get token |

---

### 📋 Task APIs

| Method | Endpoint       | Description    |
| ------ | -------------- | -------------- |
| GET    | /api/task      | Get all tasks  |
| GET    | /api/task/{id} | Get task by ID |
| POST   | /api/task      | Create task    |
| PUT    | /api/task/{id} | Update task    |
| DELETE | /api/task/{id} | Delete task    |

---

## 🧪 How to Run Project

1. Clone the repository
2. Open in Visual Studio 2022
3. Update connection string in `appsettings.json`
4. Run migration:

```
Add-Migration InitialCreate
Update-Database
```

5. Run the project
6. Open Swagger UI
7. Test APIs

---

## 🧠 SOLID Principles Used

* **S (Single Responsibility):** Separate controllers, services, repositories
* **O (Open/Closed):** Easily extend repository without modifying controller
* **L (Liskov Substitution):** Interface-based design
* **I (Interface Segregation):** Small, specific interfaces
* **D (Dependency Inversion):** Controller depends on interfaces

---

## 🏗️ Design Patterns Used

* Repository Pattern
* Dependency Injection
* DTO Pattern
* Layered Architecture

---

## 💼 Resume Points

* Developed RESTful APIs using ASP.NET Core (.NET 8)
* Implemented JWT Authentication & Role-based Authorization
* Applied SOLID principles and Clean Architecture
* Built full CRUD operations using Entity Framework Core
* Used Repository Pattern for data abstraction

---

## 👨‍💻 Author

Your Name
Rahul Jatve

## ⭐ If you like this project

Give it a ⭐ on GitHub!
