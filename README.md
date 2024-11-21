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
- It is use to pass parameters to the method also it can be use in user define classes and method.

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

# <ins> Generic Delegate </ins>
- Func<T1, T2, ...Tn>: Takes arguments of types T1, T2, ...Tn-1 and returns a value of type Tn.
- Action<T1, T2, ...>: Takes arguments of types T1, T2, ... and does not return a value.
- Predicate<T1>: Takes one argument of type T1 and returns a boolean (true or false).

 # <ins> Exception Handeling </ins>

 Exception handling in C# is a mechanism to manage runtime errors in a program gracefully, ensuring that the application can recover or provide meaningful feedback instead of crashing.
It uses a structured approach to detect, handle, and recover from errors using constructs like try, catch, and finally.

# Exception Handeling mechanism
- try :− A try block identifies a block of code for which particular exceptions is activated. It is followed by one or more catch blocks.

- catch :− A program catches an exception with an exception handler at the place in a program where you want to handle the problem. The catch keyword indicates the catching of an exception.

- finally :− The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown. For example, if you open a file, it must be closed whether an exception is raised or not.

- throw :− A program throws an exception when a problem shows up. This is done using a throw keyword.
```
try(){
  r open;
  .... exception occure
  r close
}
catch(){
  ....handle exception; // after the exception is handled the try block r block ia=s unable ti execute so 
                          // applying in try block
}
finally(){ // you can also close that resource without using finally
  r close 
}
``` 

# Exception Filter
 exception filters are a feature that allows you to specify a condition that determines whether a catch block should handle an exception. 
 This is particularly useful for scenarios where you want to handle specific exceptions only when certain conditions are met, 
 avoiding unnecessary re-throws or nested try-catch blocks

- You use an exception filter by appending a when clause to a catch block
```
try
{
    // Code that might throw an exception
    int[] numbers = { 1, 2, 3 };
    Console.WriteLine(numbers[5]); // Index out of range
}
catch (IndexOutOfRangeException ex) when (ex.Message.Contains("index"))
{
    Console.WriteLine($"Caught exception with filter: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Caught generic exception: {ex.Message}");
}

```

# Using 
The using statement in C# provides a convenient and elegant way to manage unmanaged resources, such as files, database connections, or streams.
It ensures that resources are properly disposed of when they are no longer needed, avoiding resource leaks.

# Throw Expressions
Throw was always a statement, but now it can also be used as an expression in C# 7.0 and later.
This means that you can throw exceptions within an expression context, such as in the return statement or in lambda expressions,
making your code more concise and expressive.

# common Exception Type 




