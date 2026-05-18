# Student Management System API

![CI](https://github.com/manthanpowar02/student-management-system/actions/workflows/ci.yml/badge.svg)

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![SQL Server](https://img.shields.io/badge/SQL_Server-2022-CC2927?logo=microsoftsqlserver)
![Docker](https://img.shields.io/badge/Docker-Ready-2496ED?logo=docker)
![JWT](https://img.shields.io/badge/Auth-JWT-black?logo=jsonwebtokens)
![Azure](https://img.shields.io/badge/Deploy-Azure-0078D4?logo=microsoftazure)

---

# 🚀 Live Demo

## Swagger API Documentation

https://student-management-api-manthan.azurewebsites.net/swagger

Example:

https://student-management-api-manthan.azurewebsites.net/swagger

---

# 📌 Project Overview

The Student Management System API is a production-ready ASP.NET Core 8 Web API designed to manage:

- Students
- Courses
- Enrollments
- Authentication
- Role-based authorization

This project demonstrates enterprise backend development practices including:

- JWT Authentication
- Repository Pattern
- Entity Framework Core
- SQL Server optimization
- Docker containerization
- CI/CD automation
- Azure deployment
- Unit testing with xUnit

---

# 🏗 System Architecture

```text
Client (Postman / Frontend)
            ↓
ASP.NET Core Web API
            ↓
Controllers
            ↓
Services Layer
            ↓
Repositories Layer
            ↓
Entity Framework Core
            ↓
SQL Server Database
```

---

# 🛠 Tech Stack

| Layer             | Technology             |
|-------------------|------------------------|
| Framework         | ASP.NET Core 8         |
| Language          | C#                     |
| Database          | SQL Server             |
| ORM               | Entity Framework Core  |
| Authentication    | JWT Bearer Tokens      |
| Testing           | xUnit                  |
| API Documentation | Swagger                |
| CI/CD             | GitHub Actions         |
| Containerization  | Docker                 |
| Cloud Hosting     | Microsoft Azure        |

---

# ✨ Features

## Authentication & Security

- JWT Authentication
- Role-Based Authorization
- BCrypt Password Hashing
- Protected API Endpoints
- Admin & Student Roles

---

## Student Management

- Create Student
- Update Student
- Delete Student
- Search Students
- Pagination
- Soft Delete Support

---

## Course Management

- Create Courses
- Manage Courses
- Assign Credits
- Course Enrollment

---

## Enrollment System

- Student-Course Mapping
- Enrollment Tracking
- Grade Management

---

## Performance Optimization

- SQL Indexing
- Optimized Queries
- Composite Indexes
- Reduced Query Execution Time

---

# 📈 Performance Improvements

| Query                | Before Optimization | After Optimization | Improvement |
|----------------------|---------------------|--------------------|-------------|
| Student Email Lookup | 280ms               | 8ms                | 97% Faster  |
| Enrollment Query     | 340ms               | 12ms               | 96% Faster  |

Indexes Used:

- IX_Students_Email
- IX_Enrollments_StudentId_CourseId

---

# 🔐 Authentication Flow

## Register

POST

```http
/api/auth/register
```

Request:

```json
{
  "username": "admin",
  "email": "admin@test.com",
  "password": "Admin123!",
  "role": "Admin"
}
```

---

## Login

POST

```http
/api/auth/login
```

Response:

```json
{
  "token": "JWT_TOKEN_HERE"
}
```

---

## Using JWT Token

Add this header:

```http
Authorization: Bearer YOUR_TOKEN
```

---

# 📚 API Endpoints

## Authentication

| Method | Endpoint           | Access  |
|--------|--------------------|---------|
| POST   | /api/auth/register | Public  |
| POST   | /api/auth/login    | Public  |

---

## Students

| Method | Endpoint           | Access        |
|--------|--------------------|---------------|
| GET    | /api/students      | Authenticated |
| GET    | /api/students/{id} | Authenticated |
| POST   | /api/students      | Admin         |
| PUT    | /api/students/{id} | Admin         |
| DELETE | /api/students/{id} | Admin         |

---

## Courses

| Method | Endpoint          | Access        |
|--------|-------------------|---------------|
| GET    | /api/courses      | Authenticated |
| POST   | /api/courses      | Admin         |
| DELETE | /api/courses/{id} | Admin         |

---

## Enrollments

| Method | Endpoint                             | Access        |
|--------|--------------------------------------|---------------|
| POST   | /api/enrollments                     | Admin         |
| GET    | /api/enrollments/student/{studentId} | Authenticated |

---

# 🐳 Docker Setup

## Run Using Docker

```bash
docker-compose up --build
```

Swagger:

```text
http://localhost:8080/swagger
```

---

# ⚙ Local Development Setup

## Clone Repository

```bash
git clone https://github.com/manthanpowar02/student-management-system.git
```

---

## Navigate Into Project

```bash
cd student-management-system
```

---

## Restore Packages

```bash
dotnet restore
```

---

## Run Database Migration

```bash
dotnet ef database update
```

---

## Run Project

```bash
dotnet run
```

---

# 🧪 Unit Testing

Run tests:

```bash
dotnet test
```

Testing Framework:

- xUnit
- EF Core InMemory Database
- Repository Testing

---

# 🔄 CI/CD Pipeline

GitHub Actions automatically:

- Restores dependencies
- Builds project
- Runs unit tests
- Verifies successful deployment

Workflow file:

```text
.github/workflows/ci.yml
```

---

# 📂 Project Structure

```text
StudentManagementSystem/
│
├── Controllers/
├── Models/
├── DTOs/
├── Data/
├── Repositories/
├── Services/
├── Middleware/
├── Migrations/
│
├── appsettings.json
├── Program.cs
├── Dockerfile
├── docker-compose.yml
└── README.md
```

---

# ☁ Azure Deployment

This project is deployed on Microsoft Azure App Service.

Deployment includes:

- Azure App Service
- Azure SQL Database
- GitHub CI/CD Integration
- Environment Variables
- Production Hosting

---

# 🔮 Future Improvements

- Redis Caching
- Refresh Tokens
- React Frontend
- Email Notifications
- File Upload System
- Admin Dashboard
- API Versioning
- Rate Limiting

---

# 👨‍💻 Developer

## Manthan Vikas Powar

Final-Year Computer Science Engineering Student

### Links

GitHub:

https://github.com/manthanpowar02

LinkedIn:

https://linkedin.com/in/manthanpowar02

---