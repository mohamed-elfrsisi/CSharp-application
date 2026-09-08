# Employee Management System

A simple C# console application for managing employees.

## Architecture

```text
Program
   ↓
EmployeeManager
   ├── AddEmployee
   ├── ModifyEmployee
   ├── DeleteEmployee
   └── GetAllEmployees
   ↓
Employee
```

* `Program` → handles the menu.
* `EmployeeManager` → coordinates the operations.
* Each operation has its own class.
* `Employee` → stores employee data and handles validation.
* `List<Employee>` → stores all employees.

## OOP

* Properties
* Encapsulation
* Constructors
* Composition
* Validation
