/* Create a class student with basic fields (assume yourself) properties and methods.
 * Create constructors (both types) and destructor(finalizer) too and show the implementation. */

using System.ComponentModel.DataAnnotations;

namespace Fildes_Property_Constructor_Destructor
{
    class student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)

                    age = value;
                else
                    throw new Exception("Age must be greater than 0");
            }
        }

        public student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);

        }
        ~student()
        {
            Console.WriteLine("Destructor called Cleaning up the resources");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student details = new student("sandesha", 20);
            details.Display();
        }
    }
}



