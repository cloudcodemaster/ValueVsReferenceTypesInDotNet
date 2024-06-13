// In .NET, types are broadly categorized into value types and reference types. Understanding the difference 
// between these two is fundamental to managing memory and performance in .NET applications. Here are detailed
// explanations and examples to illustrate these concepts:

// Value Types
// Value types store the actual data directly. They are stored in the stack, which is a region of memory that
// operates in a last-in, first-out manner. Each value type variable holds its own copy of the data, and operations
// on one variable do not affect another.








// Primitive Value Type

Console.WriteLine("Primitive value types");
int a = 5;
int b = a;  // b gets a copy of the value in a

b = 10;     // Changing b does not affect a
Console.WriteLine(a);  // Output: 5
Console.WriteLine(b);  // Output: 10


// Struct is Value Type


Console.WriteLine("Struct");
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;  // p2 gets a copy of the values in p1

p2.X = 3;  // Changing p2 does not affect p1
Console.WriteLine($"p1: ({p1.X}, {p1.Y})");  // Output: p1: (1, 2)
Console.WriteLine($"p2: ({p2.X}, {p2.Y})");  // Output: p2: (3, 2)


// Reference types


Console.WriteLine("Classes");

Person person1 = new Person { Name = "Alice" };
Person person2 = person1;  // person2 references the same object as person1

person2.Name = "Bob";  // Changing person2 affects person1
Console.WriteLine(person1.Name);  // Output: Bob
Console.WriteLine(person2.Name);  // Output: Bob


Console.WriteLine("Arrays");

int[] array1 = { 1, 2, 3 };
int[] array2 = array1;  // array2 references the same array as array1

array2[0] = 10;  // Changing array2 affects array1
Console.WriteLine(array1[0]);  // Output: 10
Console.WriteLine(array2[0]);  // Output: 10

struct Point
{
    public int X;
    public int Y;
}

class Person
{
    public string Name { get; set; }
}


// Key Differences
// * Memory Location: Value types are stored on the stack, whereas reference types are stored on the heap.
// * Data Handling: Value types hold their data directly; reference types hold a reference to their data.
//  *Copy Behavior: Copying a value type results in a new copy of the data. Copying a reference type results in
// a reference to the same data.

// Understanding these differences helps in writing efficient and effective .NET applications, particularly in
// scenarios involving performance-critical code or complex data structures.