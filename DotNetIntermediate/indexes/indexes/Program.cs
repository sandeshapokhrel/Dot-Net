using indexes;

namespace indexes
{
    class BookCollection
    {
        private string[] books = new string[3];//array to hold 3 books name\

        //defining an indexer
        public string this[int index]
        {
            get // retriving and returning the value at specific index
            {
                if (index >= 0 && index < books.Length)
                    return books[index];
                else
                    return "invalid index";

            }
            set // assigning or setting value in book array
            {
                if (index >= 0 && index <= books.Length)
                    books[index] = value; // assigning
                else
                    Console.WriteLine("invalid index");
            }

        }
    }

}

class program
{
    public static void Main (string [] args)
    {
        BookCollection myBook =new BookCollection();
        myBook[0] = "the paradise";
        myBook[1] = "mission";
        myBook[2] = "Matrix";

        Console.WriteLine("book 1:" + myBook[0]);
        Console.WriteLine("book 2:" + myBook[1]);
        Console.WriteLine("book 3:" + myBook[2]);

    }
}
