using System;

namespace EventDemo
{
    public delegate void MyDel();

    internal class Person
    {
        private string name;
        public MyDel del;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (del != null)
                {
                    del();
                }
            }
        }
    }
}