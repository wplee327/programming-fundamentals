Imports System
imports Mathematics
Imports Practice

Module Program
    Sub Main(args As String())
        If (args.Length > 0) Then ' Check if any arguments have been passed to the program.
            If (args(0) = "calc") Then ' If the calc argument is passed, then run the Calc method.
                Calc()
            ElseIf (args(0) = "arrays") Then ' If the arrays argument is passed, then run the Arrays method.
                Arrays()
            ElseIf (args(0) = "help") Then ' If the help argument is passed, print the help text.
                Console.WriteLine($"help{vbTab}Display the help text.{vbCrLf}calc{vbTab}Start the calculator.{vbCrLf}arrays{vbTab}Start the arrays demonstration.")
            End If
        Else
            Console.WriteLine("No arguments detected. Try 'dotnet run help' to display help text.") ' Suggest using the help argument if no arguments are entered.
        End If
    End Sub

    Sub Calc() ' Create a sub named Calc to call the calculator methods.
        Dim firstNum, secondNum As Integer ' Create the variables named firstNum and secondNum to hold the two numbers for the operation.
        Dim operation As String ' Create a variable named operation to hold the operation to be performed on the numbers.
        Console.Write("Please enter the first number: ") ' Ask for the first number.
        firstNum = Console.ReadLine() ' Read the user input for the first number and assign it to the variable named firstNum.
        Console.Write("Please enter the second number: ") ' Ask for the second number.
        secondNum = Console.ReadLine() ' Read the user input for the second number and assign it to the variable named secondNum.
        Console.Write("Please enter the operation to perform: ") ' Ask for the operation.
        operation = Console.ReadLine() ' Read the user input for the operation and assign it to the variable named operation.

        Dim calculator As New Mathematics.Calculator ' Create a calculator object. to call the calculator's methods.
        Dim result As Integer ' Create a variable named result to hold the output of the calculator methods.

        If (operation = "add") Then ' Check if the operation is addition.
            result = calculator.Addition(firstNum, secondNum) ' Call the addition method with the two integers and assign the result to the variable named result.
            Console.WriteLine($"{firstNum} + {secondNum} = {result}") ' Output the expression along with the answer.
        ElseIf (operation = "sub") Then
            result = calculator.Subtraction(firstNum, secondNum)
            Console.WriteLine($"{firstNum} - {secondNum} = {result}")
        ElseIf (operation = "mult") Then
            result = calculator.Multiplication(firstNum, secondNum)
            Console.WriteLine($"{firstNum} * {secondNum} = {result}")
        ElseIf (operation = "div") Then
            result = calculator.Division(firstNum, secondNum)
            Dim remainder as Integer = calculator.Modulus(firstNum, secondNum) ' Create a variable named remainder and assign the output of the Modulus method to it.
            Console.WriteLine($"{firstNum} / {secondNum} = {result}r{remainder}")
        Else
            Console.WriteLine("Invalid operation entered. Valid operations [add, sub, mult, div].") ' Print a message telling the user an invalid operation was entered and show valid operations.
        End If
    End Sub

    Sub Arrays()
        Dim inputArray() As Integer = {1, 2, 3, 4, 5} ' Create a variable named inputArray that contains an array of integers from 1-5.
        Dim fizzBuzzArray() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15} ' Create a variable named fizzBuzzArray taht contains an array of integers from 1-15.
        Dim inputString As String ' Create a variable named inputString to hold the string to be reversed.

        Dim challenge As New Practice.CodingChallenges ' Create a CodingChallenges object to call its methods.

        Console.Write("Input Array: ") ' Print out the starting array.
        For Each arrayElement As Integer In inputArray
            Console.Write($"{arrayElement} ")
        Next
            Console.WriteLine()

        Dim outputArray() As Integer = challenge.ReverseArray(inputArray) ' Call the ReverseArray method and assign its output to the variable named outputArray.

        Console.Write("Output Array: ") ' Print out the array after it has been reversed.
        For Each arrayElement As Integer In outputArray
            Console.Write($"{arrayElement} ")
        Next
            Console.WriteLine()
        
        Console.WriteLine("----------")

        Console.WriteLine($"Please input a string to be reversed: ") ' Ask for a string.
        inputString = Console.ReadLine() ' Read the user input and assign it to the variable named inputString.
        Console.WriteLine(challenge.ReverseString(inputString)) ' Call the ReverseString method and print out its output.

        Console.WriteLine("----------")

        challenge.FizzBuzz(fizzBuzzArray) ' Call the FizzBuzz method and pass the array of integers to it.
    End Sub
End Module
