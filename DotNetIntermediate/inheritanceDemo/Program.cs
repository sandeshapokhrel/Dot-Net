using System;
class Person
{
    protected string name;
    protected string gender;
    public Person()
    {
        name = "sandesha";
        gender = "female";

    }
    public Person(string name, string gender) : base()
    {
        this.name = name;
        this.gender = gender;
    }
    public void show()
    {
        Console.WriteLine("Name=" + name);
        Console.WriteLine("gender=" + gender);
    }
}
    class Student: Person
    {
        public string studentID;
    //constructor for student class
        public Student (string studentID, string name, string gender) : base(name, gender)
        {
            this.studentID = studentID;
        }

        public void display()
        {
            show(); 
            Console.WriteLine("Student ID = " + studentID);
        }
    }


