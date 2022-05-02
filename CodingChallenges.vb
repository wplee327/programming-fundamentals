Namespace Global.Practice ' Create a namespace named Practice to contain our code and make it Global so it is visible to the rest of the program.
    Class CodingChallenges ' Create a class named CodingChallenges to contain the methods available in this class.
        Function ReverseArray(inputArray() As Integer) As Integer() ' Create a function named ReverseArray that accepts an array of integers and returns an array of integers.
            Dim outputArray(inputArray.GetUpperBound(0)) As Integer ' Create a variable named outputArray that is an array of integers and is the same size as inputArray.
            For arrayElement As Integer = 0 To (inputArray.GetUpperBound(0)) ' Create a loop that starts at 0 and increments arrayElement by 1 until it reaches the number for the last index of inputArray.
                outputArray(inputArray.GetUpperBound(0) - arrayElement) = inputArray(arrayElement) ' Populate outputArray starting from the last index with the value of inputArray at the index specified by arrayElement.
            Next
                return outputArray ' Output the array of integers named outputArray.
        End Function

        Function ReverseArray(inputArray() As Char) As Char() ' Create a function named ReverseArray that accepts an array of characters and returns an array of characters.
            Dim outputArray(inputArray.GetUpperBound(0)) As Char ' Create a variable named outputArray that is an array of characters and is the same size as inputArray.
            For arrayElement As Integer = 0 To (inputArray.GetUpperBound(0)) ' Create a loop that starts at 0 and increments arrayElement by 1 until it reaches the number for the last index of inputArray.
                outputArray(inputArray.GetUpperBound(0) - arrayElement) = inputArray(arrayElement) ' Populate outputArray starting from the last index with the value of inputArray at the index specified by arrayElement.
            Next
                return outputArray ' Output the array of integers named outputArray.
        End Function

        Function ReverseString(inputString As String) As String ' Create a function named ReverseString that accepts a string and returns a string.
            Dim charArray() As Char = inputString.ToCharArray() ' Create a variable named charArray that is an array of characters, convert the string inputString into an array of characters, and assign it to charArray.
            return New String(ReverseArray(charArray)) ' Call the function ReverseArray, passing the array of characters charArray to it, and return the result.
        End Function

        Sub FizzBuzz(inputArray() As Integer) ' Create a sub named FizzBuzz that accepts an array of integers.
            For Each arrayElement As Integer In inputArray ' Iterate over every element of the inputArray.
                If (arrayElement MOD 5 = 0 And arrayElement MOD 3 = 0) Then ' Check if the integer is divisible by both 3 and 5.
                    Console.WriteLine($"{arrayElement} FizzBuzz") ' Print FizzBuzz next to the number if the integer is divisible by both 3 and 5.
                ElseIf (arrayElement MOD 3 = 0) Then ' Check if the integer is divisible by 3.
                    Console.WriteLine($"{arrayElement} Fizz") ' Print Fizz next to the number if the integer is divisible by 3.
                ElseIf (arrayElement MOD 5 = 0) Then ' Check if the integer is divisible by 5.
                    Console.WriteLine($"{arrayElement} Buzz") ' Print Buzz next to the number if the integer is divisible by 5.
                Else
                    Console.WriteLine($"{arrayElement}") ' Print the number by itself if it is not divisible by 3 nor 5.
                End If
            Next
        End Sub

        ' Function IsPalindrome(inputString As String) As Boolean

        ' End Function

        ' Function IsPrime(inputInt As Integer) As Boolean

        ' End Function
    End Class
End Namespace