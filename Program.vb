Imports System
imports Mathematics
Imports Practice

Module Program
    Sub Main(args As String())
        If (args.Length > 0) Then
            If (args(0) = "calc") Then
                Calc(args(1))
            ElseIf (args(0) = "arrays") Then
                Arrays()
            End If
        End If
    End Sub

    Sub Calc(operation As String)
        Dim firstNum, secondNum As Integer
        Console.Write("Please enter the first number: ")
        firstNum = Console.ReadLine()
        Console.Write("Please enter the second number: ")
        secondNum = Console.ReadLine()

        Dim calculator As New Mathematics.Calculator
        Dim result As Integer

        If (operation = "add") Then
            result = calculator.Addition(firstNum, secondNum)
            Console.WriteLine($"{firstNum} + {secondNum} = {result}")
        ElseIf (operation = "sub") Then
            result = calculator.Subtraction(firstNum, secondNum)
            Console.WriteLine($"{firstNum} - {secondNum} = {result}")
        ElseIf (operation = "mult") Then
            result = calculator.Multiplication(firstNum, secondNum)
            Console.WriteLine($"{firstNum} * {secondNum} = {result}")
        ElseIf (operation = "div") Then
            result = calculator.Division(firstNum, secondNum)
            Dim remainder as Integer = calculator.Modulus(firstNum, secondNum)
            Console.WriteLine($"{firstNum} / {secondNum} = {result}r{remainder}")
        End If
    End Sub

    Sub Arrays()
        Dim inputArray() As Integer = {1, 2, 3, 4, 5}
        Dim fizzBuzzArray() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}
        Dim inputString As String = "This is my input string"

        Dim challenge As New Practice.CodingChallenges

        Console.Write("Input Array: ")
        For Each arrayElement As Integer In inputArray
            Console.Write($"{arrayElement} ")
        Next
            Console.WriteLine()

        Dim outputArray() As Integer = challenge.ReverseArray(inputArray)

        Console.Write("Output Array: ")
        For Each arrayElement As Integer In outputArray
            Console.Write($"{arrayElement} ")
        Next
            Console.WriteLine()
        
        Console.WriteLine("----------")

        Console.WriteLine($"Input String: {inputString}")
        Console.WriteLine(challenge.ReverseArray(inputString))

        Console.WriteLine("----------")

        challenge.FizzBuzz(fizzBuzzArray)
    End Sub
End Module
