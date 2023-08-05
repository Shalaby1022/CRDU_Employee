# CRUD_Employee

CRUD_EMP is a simple CRUD (Create, Read, Update, Delete) application built using ASP.NET Core MVC. It allows you to manage a list of employees, including their details such as name, age, salary, email, office, and password.

## Recent Changes:

1. Added Project CRUD operations, enabling users to perform Create, Read, Update, and Delete operations on employee records.

2. Added a `selectedItems` feature for the office in the department, providing users with a convenient way to manage offices within departments.

3. Refactored the code using ASP-controller and ASP-actions, improving code organization and maintainability.

## Features:

1. View a list of all employees with basic details.

2. View detailed information about a specific employee.

3. Create a new employee record with all required details.

4. Edit the details of an existing employee.

5. Delete an employee from the database.

6. Added employee and office details to the navigation bar for easy access.

7. Implemented CRUD operations for managing offices, allowing users to add, view, edit, and delete office records.

8. Styled the website using Bootstrap to improve its appearance and user experience.

9. Updated the spacing and layout to enhance readability and visual appeal.

With these recent updates, the CRUD_EMP application is now more user-friendly, and visually appealing, and allows for efficient management of both employees and offices.

## Technologies Used:

1. ASP.NET Core MVC

2. Entity Framework Core

3. Microsoft SQL Server (Database)

4. HTML/CSS

5. Bootstrap (for styling)

## Notes:

1. The application uses basic validation to ensure that all required fields are provided while creating/editing an employee record.

2. The password field is stored in the database as plaintext. For production applications, it's essential to use proper encryption/hashing for passwords.

3. The application does not implement user authentication and authorization. This feature should be added in a real-world application to ensure proper security.

## How to Run the Application:

1. Clone this repository to your local machine.

2. Open the project in Visual Studio or any code editor that supports ASP.NET Core.

3. Update the database connection string in the `appsettings.json` file to point to your Microsoft SQL Server.

4. Run the application using Visual Studio or by executing the `dotnet run` command in the project directory.

5. Access the application in your web browser at `http://localhost:5000`.
