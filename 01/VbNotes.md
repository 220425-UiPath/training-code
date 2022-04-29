# VB.Net
* VB.NET was developed by Microsoft.
* It is an object-oriented language.
* The language is not case sensitive.
* VB.NET programs run on the .NET .
* The language provides windows forms from which you can inherit your own forms.
* VB.NET allows you to enjoy the drag and drop feature when creating a user interface.

# Program Structure
* Namespace declaration
    * We include a namespace into our programming structure. After that, we will be able to access all the methods that have been defined in that namespace without getting an error.
* A class or module
    * VB.Net is an object-oriented language. 
        * Object Oriented languages have a class and object
        * A class is a Blueprint of an object. Object is anything which has real-life entity. Ex: cat
        * Object has its state(attributes) and behaviors. Ex Cat has fur and cat can movement. State (data/attributes) are nouns and behaviors are verbs.
        * Pillars of OOP:
            * Encapsulation : Wrapping up of data and data hiding
            * Abstraction : Show only essentials features of the program
            * Inheritance : Its for resuability and creating parent-child releationship between objects of classes.
            * Polymorphism : multiple behaviors based on the object
    * Hence we must have a class or module in every program. 
    * It is inside this module that you will be able to define the data and methods to be used by your program.
* Comments
    * To mark it as a comment, we added a single quote (‘) to the beginning of the sentence. The VB.Net compiler will not process this part. 
    * The purpose of comments is to improve the readability of the code. Use them to explain the meaning of various statements in your code. 
    * Anyone reading through your code will find it easy to understand.
* The Main procedure
    * This marks the entry point in all VB.Net programs. 
    * It defines what the module will do when it is executed.
* One or more procedures
    * A VB.Net module or class can have more than one procedures. 
    * It is inside procedures where you should define your executable code. 
    * This means that the procedure will define the class behavior. 
    * A procedure can be a Function, Sub, Get, Set
* Variables
    * Holds the data of the program
* Statements & Expressions
    * Commands to process data
    * It may contain keywords, operators, variables, literal values, constants and expressions.

# Variables and Datatypes
* Each variable must belong to a data type. The data type determines the amount of memory space allocated to the variable.
* We can convert a variable from one data type to another.
* Initializing variables means assigning values to the variables.
## Predefined
- Build in datatypes in Vb
- Numbers - Integer (4 byte), Single (4 byte decimal), Double (8 byte decimal), Decimal (16 bytes with high precision values) etc....
- Char - 2 Bytes Ex 'a', '$', 'C' . Values are in ''
- Boolean - True or False
- Object - Store any type of data
- String - array of characters Ex: "Joe". Values are in ""

## Type Conversion 
- Converting 1 datatype to another
- Methods are like this **CDatatype**. Ex CInt(), CDecimal(), CChar(), CString()
    * CBool (expression): converts the expression to a Boolean data type.
    * CDate(expression): converts the expression to a Date data type.
    * CDbl(expression): converts the expression to a Double data type.
    * CByte (expression): converts the expression to a byte data type.
    * CChar(expression): converts the expression to a Char data type.
    * CLng(expression): converts the expression to a Long data type.
    * CDec(expression): converts the expression to a Decimal data type.
    * CInt(expression): converts the expression to an Integer data type.
    * CObj(expression): converts the expression to an Object data type.
    * CStr(expression): converts the expression to a String data type.
    * CSByte(expression): converts the expression to a Byte data type.
    * CShort(expression): converts the expression to a Short data type.

# Procedures
* A procedure is a group of statements that together perform a task when called. 
* After the procedure is executed, the control returns to the statement calling the procedure. VB.Net has two types of procedures−
    1. Functions
        * Functions return a value
    2. Sub procedures or Subs
        * Subs do not return a value.
# Arrays
* They are multivalue fields which are of same type and placed in contigious memory location

# Operators
* An Operator in VB.Net refers to a symbol that instructs the compiler to perform a specific logical or mathematical manipulation.
## Types of Operators:
### Arithmatic Operators
* `^` - for raising an operand to the power of another operand
* `+` -	for adding two operands.
* `–` -	for subtracting the second operand from the first operand.
* `*` -	for multiplying both operands.
* `/` -	for dividing an operand against another. It returns a floating point result.
* `\` -	for dividing an operand against another. It returns an integer result.
* `MOD` -	known as the modulus operator. It returns the remainder after division.

### Comparison Operators
* `=` -	for checking whether the two operands have equal values or not.If yes, the condition will become true.
* `>` -	for checking whether the value of the left operand is less than that of the right operand. If yes, the condition will become true.
* `<` -	for checking whether the value of the left operand is greater than or equal to that of the right operand. If yes, the condition will become true.
* `>=` -	for checking whether the two operands have equal values or not. If yes, the condition will become true.
* `<=` -	for checking whether the value of the left operand is less than or equal to that of the right operand. If yes, the condition will become true.
* `<>` - Checks if the values of two operands are equal or not; if values are not equal, then condition becomes true.

### Logical Operators
* `And` -	known as the logical/bitwise AND. Only true when both conditions are true.
* `Or` -	known as the logical/bitwise OR. True when any of the conditions is true.
* `Not` -	The logical/bitwise NOT. To reverse operand’s logical state. If true, the condition becomes False and vice versa.
* `Xor` -	bitwise Logical Exclusive OR operator. Returns False if expressions are all True or False. Otherwise, it returns True.
* `AndAlso` -	It is also known as the logical AND operator. Only works with Boolean data by performing short-circuiting.
* `OrElse` -	It is also known as the logical OR operator. Only works with Boolean data by performing short-circuiting.
* `IsFalse` -	Determines whether expression evaluates to False.
* `IsTrue` -	Determines whether expression evaluates to True.

# References
- https://www.tutorialspoint.com/vb.net/vb.net_program_structure.htms
- https://www.guru99.com/vb-net-tutorial.html
