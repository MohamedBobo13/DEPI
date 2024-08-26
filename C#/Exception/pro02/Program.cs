using System;
namespace pro01
{
    internal class Program
    {
        class Employee
        {
            //private string name;
            public String Name {
                get { return name; }

                set
                {
                    if (value.Length == 10)
                    {
                        name = value;
                    }
                    else
                    {
                        throw new Name_Exception(value,"string not equal 10 words");
                    }
                        }
            }
            public override string ToString()
            {
                return $"{name}";
            }
        }

        class Name_Exception : Exception
        {
            public string Name { get; set; }
            public Name_Exception(string name,string Message) : base(Message)
            {
                Name = name; 
            }
        }
        private static void Main(string[] args)
        {
            try
            {
                Employee emp = new Employee();
                emp.Name = Console.ReadLine();
                Console.WriteLine(emp);
            }
            catch (Name_Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Name);
            }
        }
    }
}