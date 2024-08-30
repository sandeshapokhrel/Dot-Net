# Dot-Net 
[] Interface Overview
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
