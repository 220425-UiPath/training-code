Namespace Global.Practise
    public Class CodingChallenges
        public Sub ReverseArray(inputArray as Integer())
            Console.WriteLine("Before Reverse")
            For i As Integer = 0 To inputArray.GetUpperBound(0) 'Step 1
                Console.Write(inputArray(i).ToString() + " ")
            Next
            Console.WriteLine()
            Console.WriteLine("After Reverse")
            For i As Integer = inputArray.GetUpperBound(0) To 0 Step -1
                Console.Write(inputArray(i).ToString()+" ")
            Next            
        End Sub  
        public function ReverseArrayAgain(input as Integer()) as Integer() 
            Dim output(input.GetUpperBound(0)) as Integer 'a new array to hold reverse values
            For i As Integer = input.GetUpperBound(0) To 0 step -1
                output(input.GetUpperBound(0)-i) = input(i)
            Next
            return output
        End function    

        Sub ReverseString(str as String)
            Dim charArray as Char()=str.ToCharArray()'convert a string to char array
            Dim output as string = string.empty ' initializing an empty string for output as reverse string
            For i As integer = charArray.GetUpperBound(0) To 0 step -1
                output = output + charArray(i)
            Next
            Console.Write(output)
        End Sub

        Sub FizzBuzz(input as Integer())
            For Each i As Integer In input
                If (i MOD 3 = 0 AND i MOD 5 = 0) Then
                    Console.WriteLine("FizzBuzz")
                ElseIf  (i MOD 3 = 0) Then
                    Console.WriteLine("Fizz")
                ElseIf (i MOD 5 = 0) Then
                    Console.WriteLine("Buzz")
                Else
                    Console.WriteLine(i)    
                End If                
            Next
            
        End Sub
         
    End Class
End Namespace
' abc -> 'a', 'b', 'c'