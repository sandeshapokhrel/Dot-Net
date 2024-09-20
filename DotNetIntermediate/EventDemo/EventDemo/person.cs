using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{ public delegate void MyDel();
    public class person
    {
        string name;

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
            }   }
    }
}
