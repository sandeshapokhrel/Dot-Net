// Demonstrate the use of both null operators.
// 2 null operators 
//??  Null-coalescing operator
//??= Null conditional operator, Elvis operator
class program
{
    static void Main (string [] args)
    {    // Null-coalescing operator (??)
        string name = null;
        string username = name ?? "defaultName";
        Console.WriteLine(username); // if the variable in the left is null gives other value which is defaultName


        // Null-conditional operator (??=), also known as the Elvis operator

        string defaultName = "sandesha";
        name ??= defaultName; // the variable name will be set to defaultName if its null
        Console.WriteLine(name);   
    }
}