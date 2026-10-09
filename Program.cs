using System.Collections;

namespace Labb6
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Stack<Employee> myStack = new Stack<Employee>();
            AddEmployees(myStack);
            PrintInfo(myStack);
            PopEmployees(myStack);
            AddEmployees(myStack);
            PeekEmployees(myStack);

            List<Employee> myList = new List<Employee>();
            AddEmployees(myList);
            CheckExistence(myList, myList[1]);
            Employee maleEmployee = myList.Find(e => e.Gender == "Male");
            Console.WriteLine($"{maleEmployee.Id} {maleEmployee.Name} {maleEmployee.Gender} {maleEmployee.Salary}");
            List<Employee> maleEmployees = myList.FindAll(e => e.Gender == "Male");
            foreach(Employee employee in maleEmployees)
            {
                Console.WriteLine(employee.Name);
            }


        }
        public static void AddEmployees(Stack<Employee> myStack)
        {
            myStack.Push(new Employee { Id = Guid.NewGuid(), Name = "Sven Svensson", Gender = "Male", Salary = 52000 });
            myStack.Push(new Employee { Id = Guid.NewGuid(), Name = "Petter Andersson", Gender = "Male", Salary = 46000 });
            myStack.Push(new Employee { Id = Guid.NewGuid(), Name = "Johan Karlsson", Gender = "Male", Salary = 51000 });
            myStack.Push(new Employee { Id = Guid.NewGuid(), Name = "Frida Johansson", Gender = "Female", Salary = 72000 });
            myStack.Push(new Employee { Id = Guid.NewGuid(), Name = "Alexandra Pettersson", Gender = "Female", Salary = 44000 });
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
                CheckExistence(myStack, employee);
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
            if (myStack.Count >= 3)
            {
                Console.WriteLine("Object number 3 is in the stack");
            }
            else
            {
                Console.WriteLine("Object number 3 is not in the stack");
            }
        }
        public static void AddEmployees(List<Employee> myList)
        {
            myList.Add(new Employee { Id = Guid.NewGuid(), Name = "Sven Svensson", Gender = "Male", Salary = 52000 });
            myList.Add(new Employee { Id = Guid.NewGuid(), Name = "Petter Andersson", Gender = "Male", Salary = 46000 });
            myList.Add(new Employee { Id = Guid.NewGuid(), Name = "Johan Karlsson", Gender = "Male", Salary = 51000 });
            myList.Add(new Employee { Id = Guid.NewGuid(), Name = "Frida Johansson", Gender = "Female", Salary = 72000 });
            myList.Add(new Employee { Id = Guid.NewGuid(), Name = "Alexandra Pettersson", Gender = "Female", Salary = 44000 });
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
