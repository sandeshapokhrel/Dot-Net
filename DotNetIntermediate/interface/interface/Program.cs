/* Interface
 * Is similar to the class, but it provides a specification rather than an implementation for its members. It is special in following ways:-
   1. Interface member are abstract. where class can be both (concret or Abstract)
   2. A class can implement miltiple inheritance where (class cannot create multiple inheritance) 
   3. No implement for members since all methods are implicitly abstracts. member can be exists like (Property, member, indexs, event, Methods).
   4. Interface convensions:- if we yse inheritance we use I in front of the interface class.
   5. If we do not provide any access modifieres in the interface it will be public by defult.(we cannot use any access modifier to interface).
   6. To implement interface you can use ":" sign just like inheritance. 

 * An interface is considered a "contract" because it specifies a set of methods, properties, and other members that a class must implement.
 * Here’s why it’s termed a contract:
 
Entending Interface 
- Extending interfaces is useful when you want to combine functionalities from 
multiple interfaces or when you want to create a more specific interface that builds upon a general one.

Implement Interface Members Virtual 
- if virtual is not written it will be sealed by defealt. virtual mean you can overried method 

sealed
- when you "seal" a method, you're saying that no further derived class can change the implementation of this method.
(No more content modification)

Alternative of Interface
- Abstract Class 
*/
namespace internal interface;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
