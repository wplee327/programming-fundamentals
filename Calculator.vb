Namespace Global.Mathematics ' Create a namespace named Mathematics to contain our code and make it Global so it is visible to the rest of the program.
    Class Calculator ' Create a class named Calculator to contain the methods available in this class.
        Function Addition(a As Integer, b As Integer) As Integer ' Create a function named Addition that accepts two integers and outputs one integer.
            return a + b ' Perform addition on the two input integers and output the answer.
        End Function

        Function Subtraction(a As Integer, b As Integer) As Integer
            return a - b
        End Function

        Function Multiplication(a As Integer, b As Integer) As Integer
            return a * b
        End Function

        Function Division(a As Integer, b As Integer) As Integer
            return a / b
        End Function
        
        Function Modulus(a As Integer, b As Integer) As Integer
            return a MOD b
        End Function
    End Class
End Namespace