Module Module1

    Sub Main()
        Dim total_score As Integer
        Dim index As Integer
        Dim score As Integer
        Dim scores(18) As Integer
        Dim average_score As Integer

        total_score = 0
        For index = 1 To 18
            Console.Write("Please Enter Score:")
            score = Console.ReadLine()
            scores(index) = score
            total_score = total_score + scores(index)
        Next

        average_score = total_score / 18

        For index = 1 To 18
            Console.WriteLine(scores(index).ToString())
        Next
        Console.WriteLine(average_score.ToString())
    End Sub

End Module
