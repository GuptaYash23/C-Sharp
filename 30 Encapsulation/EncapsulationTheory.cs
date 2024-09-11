/* Encapsulation

Encapsulation is one of the core principles of object-oriented programming (OOP) in C#, and it refers to the practice of restricting direct access to an object's internal data and methods, while providing controlled access through public methods or properties. This concept helps in safeguarding the object's internal state and ensures that it's only modified in well-defined ways.

Key Aspects of Encapsulation in C#:

Private Fields: Encapsulation typically involves using private fields to store the data of an object. These fields cannot be accessed directly from outside the class.

Public Methods/Properties: To provide controlled access to the private data, public methods or properties are used. These methods allow reading, modifying, or interacting with the private data, while maintaining control over how the data is accessed or modified.

Getter and Setter: Properties (with get and set accessors) are often used in C# to encapsulate fields. They allow you to expose fields with controlled access, such as validation logic during assignment or restricting access to read-only.

Benefits of Encapsulation:

Improved Security: By hiding the internal implementation details, encapsulation protects the object's integrity by preventing unauthorized or unintended access.

Code Maintenance: It helps in maintaining and updating code because the implementation details are hidden, and only the public interfaces need to be considered when making changes.

Flexibility: Encapsulation allows changing the internal implementation without affecting other parts of the code that rely on the object.

*/