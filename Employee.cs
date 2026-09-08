namespace employee_managment;

public class Employee
{
 private int id;
 private string name;
 private int age;
 private decimal salary;

 public int Id
 {
     get { return id; }
     set
     {
         if (value <= 0)
         {
             throw new ArgumentException("id can't  be zero or negative");
         }

         id = value;
     }
 }

 public string Name
 {
     get { return name; }
     set
     {
         if (string.IsNullOrWhiteSpace(value))
         {
             throw new ArgumentException("name can't be empty");
         }

         name = value;
     }
 }

 public int Age
 {
     get { return age; }
     set
     {
         if (value <= 0)
         {
             throw new ArgumentException("age can't be zero or negative");
         }

         age = value;
     }
 }


 public decimal Salary
 {
     get { return salary; }
     set
     {
         if (value <= 0)
         {
             throw new ArgumentException("madion ya beeeh");
         }

         salary = value;
     }
 }


 public Employee(int id, string name, int age, decimal salary)
 {
     Id = id;
     Name = name;
     Age = age;
     Salary = salary;
 }
 
}