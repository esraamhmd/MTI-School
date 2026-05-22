# 🏫 MTI School — Database Management System

<div align="center">

<img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" />
<img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" />

<br/><br/>

### A full-featured school management system with SQL Server backend, Windows Forms UI, and complete CRUD operations across 8 entities.

<br/>

![Screenshot_1](https://github.com/esraamhmd/MTI-School/assets/145714762/0d3b3a43-cb5d-4ed7-98bc-81c77fa72da8)
![Screenshot_2](https://github.com/esraamhmd/MTI-School/assets/145714762/cac52b74-ba6f-490d-aaa2-0d3a64b7745b)

</div>

---

## 📖 Introduction

**MTI School** is a complete desktop-based school database management system built for the Database Systems 1 course at Modern University for Technology & Information (MTI). The system efficiently manages all core school operations — from student enrollment and course assignments to exam tracking, attendance, and payment handling — all backed by a real SQL Server database with properly normalized tables and enforced foreign key relationships.

The application features a clean Windows Forms interface with login authentication, a structured main menu, full CRUD transactions for every entity, and SQL query views for reporting.

---

## ✨ Features

### 🎓 Student Management
- Add, update, and delete student records
- Store `StudentID`, full name, academic level, address, and birthdate
- View all students in a live data grid with instant confirmation

### 👨‍🏫 Teacher Management
- Manage teacher profiles linked to their assigned course
- Store contact info, address, phone number, and teaching class
- Cascading updates and deletes maintain referential integrity

### 📚 Course Management
- Create and manage courses with credit hours
- Courses act as the central entity — linked to teachers, enrollments, assignments, and exams

### 📝 Enrollments
- Track which student is enrolled in which course
- Simple junction table with `StudentID` and `CourseID` as composite key

### 📋 Assignments
- Assign coursework to individual students per course
- Track assignment name, deadline, and completion status (`Pending` / `Completed` / `Not Complete`)

### 📊 Exams
- Record exam results per student per course
- Store exam name, date, and numeric grade
- Full CRUD support with confirmation dialogs

### 🗓️ Attendance
- Log daily attendance records per student
- Status options: `Present` / `Absent`
- Each record tied to a specific date and student

### 💳 Payments
- Record tuition and fee payments per student
- Track payment amount, date, and payment type (`Tuition` / `Fee` / `Books`)

### 🔐 Login Form
- Secure login screen with username and password
- "Show password" toggle checkbox
- Success dialog on valid credentials before entering the main menu

---

## 🗃️ Database Schema

The system is built on **8 relational tables** inside the `mtiSchool` schema:

| Table | Primary Key | Foreign Keys |
|---|---|---|
| `Students` | `StudentID` | — |
| `Courses` | `CourseID` | — |
| `Teachers` | `TeacherID` | `CourseID → Courses` |
| `Enrollments` | `StudentID` | `CourseID → Courses` |
| `Assignments` | `AssID` | `CourseID → Courses`, `StudentID → Students` |
| `Exams` | `ExamID` | `CourseID → Courses`, `StudentID → Students` |
| `Attendance` | `AttendanceID` | `StudentID → Students` |
| `Payments` | `PaymentID` | `StudentID → Students` |

All foreign keys are configured with `ON UPDATE CASCADE ON DELETE CASCADE`.

---

## 🚀 Tech Stack

### 🗄️ SQL Server
The entire backend runs on Microsoft SQL Server. The database (`mtiSchool`) uses a dedicated schema with 8 normalized tables. All relationships, constraints, and cascading rules are enforced at the database level.

### 💻 C# — Windows Forms
The desktop UI is built with C# and Windows Forms. Each entity has its own form with a `DataGridView` for live record display and a `Confirm` button to commit transactions. The main menu provides navigation via a dropdown menu system covering all 8 modules plus a Reports section.

### 🔌 ADO.NET
Database connectivity is handled through ADO.NET — `SqlConnection`, `SqlCommand`, `SqlDataAdapter`, and `DataTable` — for executing queries and binding results directly to the UI grids.

---

## 📸 Interface Overview

| Screen | Description |
|---|---|
| **Login Form** | Username + password with show/hide toggle |
| **Main Menu** | Dropdown navigation to all 8 entity modules |
| **Data Grids** | Inline editable tables with Confirm button per module |
| **SQL Queries** | SELECT views for Assignments, Attendance, Courses, Enrollments, Exams, Payments, Students, Teachers |

---

## 🚦 Getting Started

### Prerequisites

- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (any edition)
- [Visual Studio](https://visualstudio.microsoft.com/) (to run the C# Windows Forms project)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) (recommended)

### Installation

1. **Clone the repository:**
   ```sh
   git clone https://github.com/esraamhmd/MTI-School.git
   cd MTI-School
   ```

2. **Set up the database:**

   Open SSMS and run the following to create the database, schema, and all tables:

   ```sql
   CREATE DATABASE mtiSchool;
   GO
   USE mtiSchool;
   GO
   CREATE SCHEMA mtiSchool;
   GO

   CREATE TABLE mtiSchool.Students (
     StudentID INT NOT NULL PRIMARY KEY,
     FullName VARCHAR(50) NOT NULL,
     Level INT,
     address VARCHAR(90),
     Birthdate DATE
   );

   CREATE TABLE mtiSchool.Courses (
     CourseID INT NOT NULL PRIMARY KEY,
     CourseName VARCHAR(30) NOT NULL,
     Credits INT NOT NULL
   );

   -- (See full SQL in the project documentation)
   ```

3. **Update the connection string** in the project to point to your SQL Server instance.

4. **Open the solution** in Visual Studio and build/run the project.

### Default Login
```
Username: admin
Password: ***
```

---

## 📁 Project Structure

```
MTI-School/
├── Forms/
│   ├── login.cs            # Login screen with auth
│   ├── MainMenu.cs         # Main navigation form
│   ├── Students.cs         # Student CRUD form
│   ├── Teachers.cs         # Teacher CRUD form
│   ├── Courses.cs          # Course CRUD form
│   ├── Enrollments.cs      # Enrollment CRUD form
│   ├── Assignments.cs      # Assignment CRUD form
│   ├── Exams.cs            # Exam CRUD form
│   ├── Attendance.cs       # Attendance CRUD form
│   └── Payments.cs         # Payment CRUD form
├── Adapters/
│   └── StudNameRTableAdapter.cs
└── project_school_db.pdf   # Full project documentation
```

---

## 📄 Documentation

Full project documentation including ERD, database relationships diagram, sample data, SQL scripts, and UI screenshots:

[📎 project\_school\_db.pdf](https://github.com/esraamhmd/MTI-School/files/15365575/project.school.db.pdf)

---

## 📄 License

This project is licensed under the MIT License.

---

<div align="center">

**Built with ❤️ using C# + SQL Server**

</div>
