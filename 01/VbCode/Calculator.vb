Namespace Global.Mathematics   
   public Class Calculator
        'Procedure to add 2 numbers
        Sub Addition()
            Dim a,b,c as Integer 'variable declaration
            Console.Write("Please enter a number ")
                a=Console.ReadLine() 'Variable initialization
            Console.Write("Please enter another number ")    
                b=Console.ReadLine()
            c=a+b 'Expression to compute addition
            Console.Write($"{a} + {b} = {c}") 'printing the result to the user
        End Sub        
    End Class  
End Namespace 
