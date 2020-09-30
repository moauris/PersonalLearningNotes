# Added Indices and Ranges

An Index type lets programmer select the index using an integer with inverted logic.

For an array, if we wish to access the elements, we use the `array[index]` syntax, but before 8.0 the index is an integer. Now index is a standalone type. 

The most significant part is now it accepts the usage of the `^index` syntax to mean selecting from the opposite direction of the index.

A Range type is similar. Now C# supports selecting an array by slicing them up with range:

```c#
char[] firstTwo = vowels[..2];
char[] lastThree = vowels[2..];
char[] middleOne = vowels[2..3];
char[] lastTwo = vowels[^2..];
```

We can initialize and create Index and Range Types:

```c#
Index last = ^1;
Range firstTwoRange = 0..2;
```

More information in Chapter 2;

# Null-Coalescing assignment

An operator that assigns to an object only if it is null.

```c#
if (s == null) s = "hello world";
```

Is the same with :

```c#
s ??= "Hello world";
```

# Using Declarations

We are quite familiar with the old using statement, where we use a resource inside a curly bracket, the resource is disposed when execution exits the bracket.

```c#
using (OleDbConnection conn = new OleDbConnection())
{
    //......some code here
}
//conn object disposed
```

Now, in 8.0, we can use a using statement without the curly bracket.

```c#

if (true) 
{
    using var reader = File.OpenText("file.txt");
    Console.WriteLine (reader.ReadLine());
}
```

A using statement without the curly bracket here will dispose the object once it exits the "if" bracket.

# REARDONLY members for struct

A `readonly` method added to a struct method, will generate compiler error if the method attempts to read the members in itself.

# Default interface members

We can now implement non abstract methods in interfaces. What it does is that it sets for the default behavior of the member, so we don't have to implement it.

# Switch expressions

Just a syntax sugar for the switch inline implementations.



