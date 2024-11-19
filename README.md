 # <ins> Interface Overview </ins>

An Interface is similar to a class but provides a specification rather than an implementation for its members. It has the following characteristics:

### Abstract Members
All members of an interface are abstract, whereas a class can have both concrete and abstract members.

### Multiple Inheritance
A class can implement multiple interfaces, whereas a class cannot inherit from multiple classes.

### No Implementations
Interfaces do not provide implementations for their members. Members can include properties, methods, events, and indexers.

### Naming Conventions
Interfaces typically start with the letter 'I'. For example, `IShape`.

### Access Modifiers
Interface members are public by default, and no access modifiers can be applied.

### Implementation
To implement an interface, use the `:` symbol, similar to class inheritance.

An interface is often considered a "contract" because it specifies a set of methods, properties, and other members that a class must implement.

## Extending Interfaces
Extending interfaces is useful when you want to combine functionalities from multiple interfaces or create a more specific interface that builds upon a general one.

## Implementing Interface Members as Virtual
When a method is declared as virtual, it means that the method can be overridden by derived classes. If `virtual` is not specified, the method will be sealed by default, preventing further overriding.

## Sealed Methods
When you "seal" a method, you're indicating that no further derived classes can change the implementation of this method.

## Alternative to Interfaces
An abstract class can be used as an alternative to an interface.

# <ins> Enumeration </ins>
Enumeration, or enum, in C# is a value type that consists of a set of named constants called the enumerator list. 
Works on Integral value.
Like a tye can be declare outside the class.
Can be combined by using (flag).
It is type Safe.

# <ins> Generic </ins>
A generic class in C# allows you to define a class with a placeholder (type parameter) for data types.
A generic allows you to define a class, method, delegate, or interface with placeholders for the types it operates on. These placeholders, known as type parameters, let you create flexible and reusable code that can work with any data type.
- A generic type defines one or more type parameters, represented by placeholders (e.g., T, U, V).

1.Two ways you can do Inheritance in c# through, Generic and inheritance.

2.Main Advantage : Type safty, type conversion,performance,codereusability

3."T" can be used to for generic type

4.The class name with generic is Khown as generic class.

5.We choose generic type when we are not sure about what type of data it contain.

6.Minimize autoboxing and boxing Overhead

Default Generic value
default keyword is used to get the value for a generic type parameters

# <ins> struct </ins>
The struct (structure) is like a class in C# that is used to store data. However, unlike classes, a struct is a value type.

Suppose we want to store the name and age of a person. We can create two variables: name and age and store value.

However, suppose we want to store the same information of multiple people.


# <ins> A delegate </ins>

Delegate is a type that represents references to methods. It allows you to encapsulate a method with a specific signature and return type. You can think of a delegate as a pointer to a function. It is used to pass methods as arguments to other methods, define callback methods, or event handling.


Key Points:
- Delegate declaration: It defines a signature (method parameters and return type) for methods that can be referenced.
 Delegate happens with subscriber and brodcaster model to handel event handeling.
- Method matching: Any method with the same signature can be assigned to a delegate.
- Invocation: You can invoke the method via the delegate instance.

# <ins> Event </ins>

Events are objects that occur when the current state of an object changes.
It is a way for a class (the broadcaster) to notify other classes or objects (the subscribers) when something interesting happens. It allows for communication between different parts of a program while maintaining loose coupling.

# <ins> Lambda Expression </ins>
 - It was introduce in c# veraion in c# 3.0

- A lambda expression is an unnamed function written in a place of delegate instance.

The compiler immmediatly converts to either:
- A delegate instance 
- An expression tree, or the type Expression<TDelegate>, represents code in a tree-like structure, where each node is an expression 
(e.g., a method call, a binary operation, or a constant).

Given the delegate type:-
We could assign and the lambda expression x => x*x as follows:
 Transformer 
  sqr = x => x*x;
  Console.WriteLine (sqr(3)); //9

(parameter) => expression-0r-statement-block

- Lambda Expression are used most commonly with the func and Action delegates.

Types of Lambda Expression :-
1. Expression Lambda- The result of the expression is automatically returned.
2. Statement Lambda - Written within the curly bracket.



