# dotnet-week4-project

# Author
Peculiar Precious 

# Project Description
This project is part of the Week 4 .NET assignment. 
It demonstrates how to use Git for version control, create repositories, 
and manage project files using Git and GitHub.

# How to Run the Project

1. Clone the repository:
   git clone https://github.com/peculiarprecious/dotnet-week4-project.git

2. Navigate to the project folder:
   cd DotnetCohort5\Week-Four-Precious

3. Open the project in VS Code.

4. Build and run the project using the .NET CLI:
   dotnet run 


# Student Management System

A robust C# Console Application built as part of the Dotnet Cohort 5 curriculum. This system manages student records using parallel data structures and a dynamic menu interface.

Features

1. Data Storage & Management
	- Uses Parallel Lists (List<T>) to store Student IDs, Names, Scores, Grades (A-F), and Pass/Fail status.

2. Core Functionality (CRUD)
   - Add New Student: Automatically increments IDs and validates name and score inputs (0-100).
   - View All Students: Displays all student records.
   - Find Student by ID: Implements a search functionality to a specific records.
   - Update Student Grade: Allows users to modify existing scores, there by recalculating the Grade and  Pass/Fail status.
   - Delete Student: Removes a student's complete record from the list.

3. Analytics & Statistics
   - Grade Calculation: Assigns letter grades (A-E, F) based on score ranges.
   - Class Statistics: Calculates the highest score, lowest score, average, and the total count of passing vs. failing students.

4. Technical Implementation
   - Input Validation: Uses `int.TryParse` and `double.TryParse` to prevent system crashes from invalid user input.
   -Git Version Control: Developed using a feature-based commit workflow on GitHub.

# Example of how to use the program

# Running the Application
1. Start the program in your terminal.
2. Select an option from the Main Menu (1-8).

# Step-by-Step (Adding a Student):
- Choose Option 1: `Add New Student`
- Enter Name: `Cynthia Uma`
- Enter Score: `75`
- Result: The system automatically assigns `ID: 6`, calculates `Grade: A`, and sets `Status: Pass`.

# Step-by-Step (Viewing Records):
- Choose Option 2: `View All Students`
- Result: The system displays an aligned table form

# Technical Concepts Demonstrated

# 1. Variables & Data Types
- `int` for IDs, `string` for Names, `double` for Scores, and `char` for Grades.
- `List<T>` to store dynamic, resizable parallel data structures.
-  `int.TryParse` and `double.TryParse` for safe type conversion.

# Control Flow & Loops
- Used `for` loops and `foreach` where necessary.
- used `if/else` statements for conditional logics and `switch` cases for the main menu system.
- A `while` loop to keep the application running until the user exits.

# 3. Operators & Logic
- Arithmetic Operators: Used for calculating averages and running totals (`+`, `/`, `+=`).
- Relational & Logical Operators: Used for grade validation and search functionality (`>=`, `&&`, `||`, `==`).
- Ternary Operator: Used for Pass/Fail status assignment.

# 4. Robust Input Handling
- Data Validation: Preventing system crashes by validating numeric inputs and ensuring strings are not null or empty using `string.IsNullOrWhiteSpace`.

## Challenges Faced & Solutions

- Challenge: Initially, using anonymous types made it difficult to add more students as it fixed.
- Solution: Transitioned from anonymous types to  Lists (`List<T>`), which allowed for easier updates and more robust data handling.

- Challenge: Ensuring that deleting or adding a student updated all five lists (ID, Name, Score, Grade, Status) at the exact same index.
- Solution: Implemented the `.RemoveAt(i)` method within a `for` loop to ensure that all the data at the particular index is removed.


