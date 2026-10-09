using System.Collections;

namespace Labb6
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Stack<Employee> myStack = new Stack<Employee>();
            AddEmployees(myStack);

            foreach(var employee in myStack)
            {
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
                Console.WriteLine("Items left in the Stack: " + myStack.Count);
            }

            Console.WriteLine("");
            Console.WriteLine("Retrieve Using Pop Method");
            while(myStack.Count > 0)
            {
                Employee employee = myStack.Pop();
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
                Console.WriteLine($"Objects left in the stack: {myStack.Count}");
            }

          

            Console.WriteLine("");
            Console.WriteLine("Retrieve Using Peek Method");

            var first = myStack.Peek();
            var temp = myStack.Pop();
            var second = myStack.Peek();
            myStack.Push(temp);
            Console.WriteLine($"{first.Id} {first.Name} {first.Gender} {first.Salary}");
            Console.WriteLine("Objects left in the stack: " + myStack.Count);
            Console.WriteLine($"{second.Id} {second.Name} {second.Gender} {second.Salary}");
            Console.WriteLine("Objects left in the stack: " + myStack.Count);
            
            if(myStack.Contains(employee3))
            {
                Console.WriteLine("Employee number 3 is in the stack");
            }
            else
            {
                Console.WriteLine("Employee number 3 is gone");
            }


            List<Employee> myList = new List<Employee>();
            myList.Add(employee1);
            myList.Add(employee2);
            myList.Add(employee3);
            myList.Add(employee4);
            myList.Add(employee5);

            if(myList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }
            
        }
        public static void AddEmployees( Stack myStack)
        {
            myStack.Push(new Employee { Id = Guid.NewGuid(), Name = "Sven Svensson", Gender = "Male", Salary = 52000});
        }
    }
}
