Namespace Global.Practice
    public Class CodingChallenges
        Function ReverseArray(inputArray() As Integer) As Integer()
            Dim outputArray(inputArray.GetUpperBound(0)) As Integer
            For arrayElement As Integer = 0 To (inputArray.GetUpperBound(0))
                outputArray(inputArray.GetUpperBound(0) - arrayElement) = inputArray(arrayElement)
            Next
                return outputArray
        End Function

        Function ReverseArray(inputArray() As Char) As Char()
            Dim outputArray(inputArray.GetUpperBound(0)) As Char
            For arrayElement As Integer = 0 To (inputArray.GetUpperBound(0))
                outputArray(inputArray.GetUpperBound(0) - arrayElement) = inputArray(arrayElement)
            Next
                return outputArray
        End Function

        Function ReverseString(inputString As String) As String
            Dim charArray() As Char = inputString.ToCharArray()
            return ReverseArray(charArray).ToString()
        End Function

        Sub FizzBuzz(inputArray() As Integer)
            For Each arrayElement As Integer In inputArray
                If (arrayElement MOD 5 = 0 And arrayElement MOD 3 = 0) Then
                    Console.WriteLine($"{arrayElement} FizzBuzz")
                ElseIf (arrayElement MOD 3 = 0) Then
                    Console.WriteLine($"{arrayElement} Fizz")
                ElseIf (arrayElement MOD 5 = 0) Then
                    Console.WriteLine($"{arrayElement} Buzz")
                Else
                    Console.WriteLine($"{arrayElement}")
                End If
            Next
        End Sub
    End Class
End Namespace