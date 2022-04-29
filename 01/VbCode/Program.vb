Imports System 'importing namespace
imports Mathematics
Namespace VbCode

Module Program 'Module or class holds the program data and procedures
    'Main Procedure is the entry point of the program 
 Sub Main(args As String()) 'procedure -> behavior of the program, args here is command line arguement which we can pass with dotnet run command
        Console.WriteLine($"First Command line args - {args(0)},{vbCrLf} Second Command line args - {args(1)}")
        Dim obj as Mathematics.Calculator = new Calculator()
        obj.Addition() 'Calling the procedure
        
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