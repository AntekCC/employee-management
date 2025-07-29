
Create the foundations of an employee management system in a certain company.
Implement a class representing the employee. Each employee is described by the following properties:
• Name 
• Last name
• Contract
The class representing the employee provides the following operations:
• the constructor initiating the employee with the given name and surname in the arguments, with the default intern contract
• a method that allows you to change the contract assigned to an employee
• method that returns the amount of the employee's salary depending on the signed contract
• the overridden ToString) method containing a string consisting of the employee's first name, last name and salary
Each contract is represented by an object that makes the following operations publicly available:
• a method that returns the amount of the salary paid for a given contract of employee
• a constructor that allows you to initialize all the constituent fields of the object
• default constructor
Currently, 2 types of contracts are signed in the company: internship and full-time
employment. Contracts are defined by the following properties:
• Internship: monthly rate (default: PLN 2,000)
• Full-Time Employment: monthly rate (default PLN 5,000), amount of overtime (default 0)
The amount of salaries is determined differently for each of these contracts, respectively:
• A trainee's (Internship) salary is always equal to the monthly rate
• Salary of a full-time employee = monthly rate + number of overtime hours * (monthly rate/60)
We assume that in the future there will be other types of contracts that differ in the way the salary is calculated. The contract class object is responsible for calculating the salary, which provides a public method that returns the amount of the salary using the Salary method. Therefore, adding a new type of contract comes down to implementing only one class, without the need to modify existing classes.
Requirements:
• C# language
• Simple graphical interface in WPF/WinForms - displaying the list of employees with their salaries, adding, removing employees and editing the contract
