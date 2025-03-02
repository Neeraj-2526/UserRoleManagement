# User Role Management API

This is a .NET 8 Web API project for managing users and roles with JWT authentication, multilingual support, and database interaction using Entity Framework Core.

## Features
- User and Role Management
- JWT Authentication
- Multilingual Support
- Database Interaction (Entity Framework Core / Dapper)
- RESTful API Implementation

## Prerequisites
- .NET 8 SDK
- MySQL Server
- Visual Studio / VS Code
- Postman (for API testing)

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/Neeraj-2526/UserRoleManagement.git
   cd UserRoleManagement
2. Restore dependencies:
   ```sh
   dotnet restore
3. Update the appsettings.json with your MySQL connection string:
   ```sh
   "ConnectionStrings": {"DefaultConnection": "Server=localhost;Database=UserRoleManagementDb;User=root;Password=yourpassword;"}
4. Apply migrations and update the database:
   ```sh
   dotnet ef database update
5. Run the application:
   ```sh
   dotnet run

## API Endpoints

### User Endpoints
- **Create User**: `POST /api/users`
- **Get All Users**: `GET /api/users`
- **Get User by ID**: `GET /api/users/{id}`
- **Update User**: `PUT /api/users/{id}`
- **Delete User**: `DELETE /api/users/{id}`

