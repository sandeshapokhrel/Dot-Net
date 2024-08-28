namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            string s1 = s;
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s.GetType().ToString());
            Console.WriteLine(s.Equals("Hello"));//compares the value within the object
            Console.WriteLine(s.Equals(s1));//its like double (==) in java 
            Console.WriteLine(Object.ReferenceEquals(s, s1));

            int a = 5;
            Console.WriteLine(a.GetType()); // int type
            Object o = a; // a is boxed to o (value type lai refrence type ma convert - boxing ) 
            Console.WriteLine(o.GetType());
            //unboxing
            int b =(int)o;
            Console.WriteLine(b.GetType());
            //unboxing
            string s2 = "123"; // if string was not number unboxin possible hunna 
            int c=Convert .ToInt32(s2);
            Console.WriteLine(s2);
            Console.WriteLine(c);

            //lonh type to int in unboxing
            long l = 89;
            Object ol= l;
             
            int i=(int)(long)ol;
            Console.WriteLine(i);

            double d = 78.9;//box
            Object od = d; 
            
             int id=(int)od;//unbox
            Console.WriteLine(od.GetType());

        }
    }
}
