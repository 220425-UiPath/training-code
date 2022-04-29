Imports System 'importing namespace
imports Mathematics

Namespace VbCode
Module Program 'Module or class holds the program data and procedures
    'Main Procedure is the entry point of the program 
    Sub Main(args As String()) 'procedure -> behavior of the program, args here is command line arguement which we can pass with dotnet run command
            'Console.WriteLine($"First Command line args - {args(0)},{vbCrLf} Second Command line args - {args(1)}")
            'TakeInput()   
            LearnArrays()
    End Sub
    Sub LearnArrays()
        'fixed array
        ' Dim employees(5) as String ' declaration of arrays of size 5
        ' 'access and add values
        ' employees(0)="Joey"
        ' employees(1)="Charlie"
        ' employees(2)="Mandy"
        ' employees(3)="Maria"
        ' employees(4)="Monica"

        'Dynamic array
        Dim employees() as String = {"Joey", "Charlie", "Mandy", "Maria", "Monica"}
        ReDim Preserve employees(6)
        employees(5) = "Rosy"

        'to read a value
        'Console.WriteLine($"Employee 6 - {employees(5)}")

        ' read all values
        ' For i As Integer = 0 To employees.Length-2
        '     Console.WriteLine($"Employee {i+1} - {employees(i)}")   
        ' Next

        For Each emp As String In employees
            Console.WriteLine(emp)
        Next
        
        

    End Sub
    
    Sub TakeInput()
            Dim a,b as Integer 'variable declaration
            Console.Write("Please enter a number ")
            a=Console.ReadLine() 'Variable initialization
            Console.Write("Please enter another number ")    
            b=Console.ReadLine()

            Dim obj as Mathematics.Calculator = new Calculator()
            Dim result as Integer = obj.Addition(a,b) 'calling the function and storing its output in an integer variable
            Console.WriteLine($"{a}+{b}={result}")
    End Sub
    
    Sub LearningDatatypes()
        ' Console.Write("Please enter your name ")
        ' 'Variable
        ' Dim name as String = Console.ReadLine()'takes input from the user
        ' Console.WriteLine($"Hello {name}")'print hello world

        ' Type Conversion
        Dim a as Integer = 0'String = "10"
        Dim b as Integer = 10'String = "20"
        'Console.Write(CInt(a)+CInt(b))
        Console.WriteLine(CBool(b))
    End Sub    
End Module
End Namespace