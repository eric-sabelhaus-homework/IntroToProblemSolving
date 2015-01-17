Module Module1

    Sub Main()
        Dim sum As Integer
        Dim number1 As Integer
        Dim number2 As Integer
        Dim product As Integer
        Dim average As Integer

        sum = 0
        Console.Write("Input Number1:")
        number1 = Console.ReadLine()
        Console.Write("Input Number2:")
        number2 = Console.ReadLine()

        'do while loop
        Do While Not (number1 = 0 And number2 = 0)
            sum = number1 + number2
            product = number1 * number2
            average = sum / 2
            If sum > 200 Then
                Console.WriteLine(sum.ToString() & "*" & product.ToString() & " " & average.ToString())
            Else
                Console.WriteLine(sum.ToString() & " " & product.ToString() & " " & average.ToString())
            End If

            Console.Write("Input Number1:")
            number1 = Console.ReadLine()
            Console.Write("Input Number2:")
            number2 = Console.ReadLine()

        Loop
    End Sub

End Module
