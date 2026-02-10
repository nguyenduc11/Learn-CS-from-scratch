# Learn C# From Scratch

This repository contains my journey learning C# programming from the basics to advanced concepts.

## Project Structure

### Core Topics (Fundamentals)

- **01_Variables/** - Data types, variable scope, type conversion, constants, and nullable types
  - Basic types: `int`, `string`, `bool`, `double`, `char`
  - Variable scope: global, local, and block scope
  - Type conversion: implicit, explicit casting, and safe parsing
  - Constants and readonly variables
  - Nullable types and null handling

- **02_Conditionals/** - Decision making and control flow
  - `if`, `else if`, `else` statements
  - Comparison operators (`==`, `!=`, `<`, `>`, `<=`, `>=`)
  - Logical operators (`&&`, `||`, `!`)
  - `switch` statements and pattern matching
  - Ternary operator (`? :`)

- **03_Loops/** - Iteration and repetitive tasks
  - `for` loops for counted iterations
  - `while` and `do-while` loops for conditional iterations
  - `foreach` loops for collections
  - Loop control: `break`, `continue`, `return`
  - Nested loops and performance considerations

- **04_Methods/** - Code organization and reusability
  - Method declaration and calling
  - Parameters: value, reference (`ref`), output (`out`)
  - Return types and `void` methods
  - Method overloading
  - Static vs instance methods
  - Recursion basics

- **05_Classes_and_Objects/** - Object-oriented programming fundamentals
  - Class definition and instantiation
  - Fields, properties, and methods
  - Constructors and destructors
  - Access modifiers (`public`, `private`, `protected`, `internal`)
  - Static members vs instance members
  - Encapsulation principles

- **06_Inheritance/** - Code reuse and polymorphism
  - Base classes and derived classes
  - Method overriding (`virtual`, `override`)
  - Abstract classes and methods
  - Interfaces and implementation
  - Polymorphism and type casting
  - `base` and `this` keywords

- **07_Collections/** - Data structures and manipulation
  - Arrays: single and multi-dimensional
  - `List<T>`: dynamic arrays
  - `Dictionary<TKey, TValue>`: key-value pairs
  - `HashSet<T>`: unique collections
  - Collection interfaces: `IEnumerable`, `ICollection`, `IList`
  - Generic collections vs non-generic

- **08_Exception_Handling/** - Error management and debugging
  - `try`, `catch`, `finally` blocks
  - Exception types and hierarchy
  - Custom exceptions
  - `throw` and `rethrow`
  - Best practices for error handling
  - Debugging techniques

### Advanced Topics

- **09_LINQ/** - Language Integrated Query for data manipulation
  - Query syntax vs method syntax
  - Filtering with `Where`
  - Projection with `Select`
  - Ordering with `OrderBy`, `OrderByDescending`
  - Grouping with `GroupBy`
  - Aggregation: `Count`, `Sum`, `Average`, `Min`, `Max`
  - Joining collections
  - Working with databases and collections

- **10_Dependency_Injection/** - Inversion of Control and loose coupling
  - Dependency Injection principles
  - Constructor injection
  - Service registration and resolution
  - Built-in DI container in .NET
  - Scoped, Transient, and Singleton lifetimes
  - Interface-based design
  - Testing with DI

## Progress

- [x] Variables - Basic types, scope, and conversion
- [ ] Conditionals - Decision making
- [ ] Loops - Iteration control
- [ ] Methods - Code organization
- [ ] Classes and Objects - OOP fundamentals
- [ ] Inheritance - Advanced OOP
- [ ] Collections - Data structures
- [ ] Exception Handling - Error management
- [ ] LINQ - Data querying
- [ ] Dependency Injection - Design patterns

## .NET CLI Commands Guide

### Creating New Projects

```bash
# Create a new console application
dotnet new console -n ProjectName

# Create in current directory
dotnet new console

# Create with specific framework version
dotnet new console -n ProjectName -f net8.0
```

### Running Projects

```bash
# Run from project directory
dotnet run

# Run with arguments
dotnet run -- arg1 arg2

# Run in release mode
dotnet run --configuration Release
```

### Building Projects

```bash
# Build the project
dotnet build

# Build in release mode
dotnet build --configuration Release

# Clean build artifacts
dotnet clean
```

### Managing Dependencies

```bash
# Add a NuGet package
dotnet add package PackageName

# Remove a package
dotnet remove package PackageName

# Restore packages
dotnet restore
```

### Project Information

```bash
# List installed SDKs
dotnet --list-sdks

# List installed runtimes
dotnet --list-runtimes

# Check .NET version
dotnet --version
```

## How to Use This Repository

1. **Navigate to a topic folder**:
   ```bash
   cd 01_Variables
   ```

2. **Create a new console project**:
   ```bash
   dotnet new console -n TopicName
   cd TopicName
   ```

3. **Run the project**:
   ```bash
   dotnet run
   ```

4. **Experiment and modify** the code to understand the concepts better.

5. **Commit your progress**:
   ```bash
   git add .
   git commit -m "Add: [description of what you learned]"
   git push
   ```

## Learning Path Recommendation

1. **Start with Variables** - Master data types and basic operations
2. **Move to Conditionals** - Learn decision making
3. **Practice with Loops** - Understand repetition and iteration
4. **Create Methods** - Organize code into reusable functions
5. **Build Classes** - Learn object-oriented programming
6. **Explore Inheritance** - Advanced OOP concepts
7. **Work with Collections** - Handle multiple data items
8. **Handle Exceptions** - Write robust, error-resistant code
9. **Master LINQ** - Powerful data querying
10. **Apply Dependency Injection** - Professional software design

Each topic builds upon the previous ones, so follow the sequence for the best learning experience.