// Write a program to show the hierarchical inheritance. 
using System.ComponentModel.DataAnnotations;

namespace _3._3_HierarchicalInheritance_
{
    internal class Program
    {  public class Employee
        {
            public string Name { get; set; }
            public void DisplayInfo ()
            {
                Console.Write($"Name:{Name} ");
            }
        }
        public class PartTimeEmployee:Employee
        {
            public void DisplayPartTimeInfo()
            {
                DisplayInfo();
                Console.WriteLine("Part Time Employee");
            }
        }
        public class FullTime : Employee 
        { 
            public void DisplayFullTimeInfo() 
            {
              DisplayInfo();
              Console.WriteLine("Full Time Employee");
            }
        }
        public static void Main(string[] args)
        {
            PartTimeEmployee emp1 = new PartTimeEmployee { Name = "sudip"};
            FullTime emp2 = new FullTime { Name= "Megan" } ;
            emp1.DisplayPartTimeInfo();
            emp2.DisplayFullTimeInfo();

        }
    }
}
