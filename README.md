Overview
The repository contains a desktop application for a Restaurant Management System.

Key Components & Architecture

Authentication & Access Control:

Login.cs & ManagerLogin.cs: Handles user authentication, separating standard users from managerial roles.

Role-Based Interfaces:

Admin.cs: A dedicated form for administrative tasks, which usually involves higher-level settings, auditing, or full system configurations.

Manager.cs: An interface tailored for managers to supervise operations, view staff, or oversee sales.

Employeecs.cs: Handles employee management, scheduling, or basic staff workflows.

Core Restaurant Operations:

FoodMenu.cs: An interface to manage or display the restaurant's food items, prices, and categories.

Order.cs: Used by waiters or cashiers to take client orders, calculate bills, or manage active tables.

Database Backend:

script.sql: A SQL database script file, meaning the application relies on a structured database backend (MySQL) to securely save data regarding users, orders, menus, and employee records.

