using ConstructorInjection;
using System;
namespace ConstructorInjection
{
    public interface Text 
    {
        void print();
    }
    class Format : Text
    {
        public void print()
        {
            Console.WriteLine("this is a print method");
        }
    }
    public class constructorInjection
    {
        private Text _text;
        public constructorInjection(Text t1)
        {
            this._text = t1;
        }
        public void print()
        {
            _text.print();
        }
    }
}
class constructor
{
    static void Main(string[] args)
    {
        constructorInjection cs= new constructorInjection(new Format());
        cs.print();
        Console.ReadKey(); // close the function when we press any key 
    }
}