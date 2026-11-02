using System.Collections;

namespace Labb6
{
    internal class Program
    {
       static void Main(string[] args)
       {
            Employee employee1 = new Employee { Id = Guid.NewGuid(), Name = "Sven Svensson", Gender = "Male", Salary = 52000 };
            Employee employee2 = new Employee { Id = Guid.NewGuid(), Name = "Petter Andersson", Gender = "Male", Salary = 46000 };
            Employee employee3 = new Employee { Id = Guid.NewGuid(), Name = "Johan Karlsson", Gender = "Male", Salary = 51000 };
            Employee employee4 = new Employee { Id = Guid.NewGuid(), Name = "Frida Johansson", Gender = "Female", Salary = 72000 };
            Employee employee5 = new Employee { Id = Guid.NewGuid(), Name = "Alexandra Pettersson", Gender = "Female", Salary = 44000 };

            Stack<Employee> myStack = new Stack<Employee>();

            AddEmployees(myStack, employee1, employee2, employee3, employee4, employee5);
            PrintInfo(myStack);
            PopEmployees(myStack);
            Console.WriteLine("");

            AddEmployees(myStack, employee1, employee2, employee3, employee4, employee5);
            PeekEmployees(myStack);
            Console.WriteLine("");
            CheckExistence(myStack, employee3);
            Console.WriteLine("");

            List<Employee> myList = new List<Employee>();

            AddEmployees(myList, employee1, employee2, employee3, employee4, employee5);

            CheckExistence(myList, employee2);
            Console.WriteLine("");

            Employee maleEmployee = myList.Find(e => e.Gender == "Male");

            Console.WriteLine($"{maleEmployee.Id} {maleEmployee.Name} {maleEmployee.Gender} {maleEmployee.Salary}");

            List<Employee> maleEmployees = myList.FindAll(e => e.Gender == "Male");

            Console.WriteLine("Finding all male employees:");

            foreach (Employee employee in maleEmployees)
            {
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
            }
       }
        public static void AddEmployees(Stack<Employee> myStack, Employee employee1, Employee employee2, Employee employee3, Employee employee4, Employee employee5)
        {
            myStack.Push(employee1);
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);
        }
        public static void PeekEmployees(Stack<Employee> myStack)
        {
            Console.WriteLine("");
            Console.WriteLine("Retrieve Using Peek Method");
            for (int i = 0; i < 2; i++)
            {
                Employee employee = myStack.Peek();
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
                Console.WriteLine($"Objects left in the stack: {myStack.Count}");
                
            }
        }
        public static void PopEmployees(Stack<Employee> myStack)
        {
            Console.WriteLine("");
            Console.WriteLine("Retrieve Using Pop Method");
            while (myStack.Count > 0)
            {
                Employee employee = myStack.Pop();
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
                Console.WriteLine($"Objects left in the stack: {myStack.Count}");
            }
        }
        public static void PrintInfo(Stack<Employee> myStack)
        {
            foreach (var employee in myStack)
            {
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
                Console.WriteLine("Items left in the Stack: " + myStack.Count);
            }
        }
        public static void CheckExistence(Stack<Employee> myStack, Employee employee)
        {
            if (myStack.Contains(employee))
            {
                Console.WriteLine("The employee number 3 exists in the stack");
            }
            else
            {
                Console.WriteLine("The employee number 3 does not exist in the stack");
            }
        }
        public static void AddEmployees(List<Employee> myList, Employee employee1, Employee employee2, Employee employee3, Employee employee4, Employee employee5)
        {
            myList.Add(employee1);
            myList.Add(employee2);
            myList.Add(employee3);
            myList.Add(employee4);
            myList.Add(employee5);
        }
        public static void CheckExistence(List<Employee> myList, Employee listEmployee)
        {
            if (myList.Contains(listEmployee))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }
        }
    }
}
