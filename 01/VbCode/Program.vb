Imports System 'importing namespace

Module Program 'Module or clas holds the program data and procedures
    Sub Main(args As String()) 'procedure -> behavior of the program
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
