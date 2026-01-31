# TASK 2 — Student Management System (C#)

Console-based C# project to practice OOP concepts through two modules:
1) Student Management (validation + GPA calculation)
2) Bank Account System (validation + deposit/withdraw + list search)

---

## Features

### Student Module
- Create a student with: **Id, Name, Email, Grade**
- Validation:
  - Email must contain `@`
  - Grade must be between **0 and 100**
- GPA calculation:
  - 90+ → 4.0
  - 80–89 → 3.0
  - 70–79 → 2.0
  - 60–69 → 1.0
  - <60 → 0.0
- Display student information

### Bank Account Module
- Create bank account with: **AccountNumber, OwnerName, Balance**
- Validation:
  - Account number must be **exactly 14 digits** (numbers only)
  - Initial balance must be **at least 1000**
- Deposit:
  - amount must be positive
- Withdraw:
  - amount must be positive
  - amount must be **less than balance**
- Store multiple accounts in `List<BankAccount>`
- Search account by account number before withdrawal
- Display account info before and after operations

---

## Technologies
- C#
- .NET Console Application
- OOP (Classes, Constructors, Methods, Exceptions)
- Collections (`List<T>`)
- Git & GitHub

---

## Screenshots (Optional)
Create a folder named `screenshots` and add your console output images:

- Student output  
  ![Student Output](screenshots/student-output.png)

- Bank account output  
  ![Bank Output](screenshots/bank-output.png)

> If you don’t want screenshots now, you can remove this section.

---

## How to Run
1. Open the `.sln` file in Visual Studio
2. Run the project (**Ctrl + F5**)

---

## Author
- **kholoud diaa**
