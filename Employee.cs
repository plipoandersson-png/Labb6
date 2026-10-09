using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labb6
{
    
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

       // public Employee(Guid id, string name, string gender, int salary)
        //{
          //  Id = id;
            //Name = name;
            //Gender = gender;
            //Salary = salary;
        //}
       public static void CreateEmployees(Stack<Employee> myStack)
        {
            
            Employee employee2 = new Employee("JEF371", "Petter, Andersson", "Male", 54000);
            Employee employee3 = new Employee("OKT321", "Kristan Karlsson", "Male", 46000);
            Employee employee4 = new Employee("MDJ027", "Frida Larsson", "Female", 73000);
            Employee employee5 = new Employee("KDO217", "Svea Johansson", "Female", 42000);

            myStack.Push(employee1);
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);
        }
        
    }

    
}