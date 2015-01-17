Module Module1

    Sub Main()
        Dim Valid_Input_Fields As Integer
        Dim Error_Message As String
        Dim Pay_Rate As Integer
        Dim Employee_Number As Integer
        Dim Hours_Worked As Integer
        Dim Overtime_Hours As Integer
        Dim Overtime_Pay As Integer
        Dim Employee_Weekly_Pay As Integer

        Valid_Input_Fields = True

        Error_Message = ""

        Console.Write("Enter Employee Number:")
        Employee_Number = Console.ReadLine()
        Console.Write("Enter Hours Worked:")
        Hours_Worked = Console.ReadLine()
        Console.Write("Enter Pay Rate:")
        Pay_Rate = Console.ReadLine()

        If Pay_Rate > 25 Then
            Error_Message = "Pay Rate Exceeds $25"
            Console.WriteLine(Employee_Number & " " & Pay_Rate.ToString() & " " & Hours_Worked.ToString() & " " & Error_Message.ToString())
            Valid_Input_Fields = False
        End If

        If Hours_Worked > 60 Then
            Error_Message = "Hours Worked Exceeds 60"
            Console.WriteLine(Employee_Number & " " & Pay_Rate.ToString() & " " & Hours_Worked.ToString() & " " & Error_Message.ToString())
            Valid_Input_Fields = False
        End If

        If Valid_Input_Fields Then
            If Hours_Worked <= 35 Then
                Employee_Weekly_Pay = Pay_Rate * Hours_Worked
            Else
                Overtime_Hours = Hours_Worked - 35
                Overtime_Pay = Overtime_Hours * Pay_Rate * 1.5
                Employee_Weekly_Pay = (Pay_Rate * 35) + Overtime_Pay
            End If

            Console.WriteLine(Employee_Number & " " & Pay_Rate.ToString() & " " & Hours_Worked.ToString() & " " & Employee_Weekly_Pay.ToString())
        End If
    End Sub

End Module
