Module Module1

    Sub Main()
        Dim Balance As Integer
        Dim Monthly_Start_Balance As Integer
        Dim Total_Monthly_Withdrawals As Integer
        Dim New_Balance As Integer
        Dim Monthly_Fee As Integer
        Dim Total_Monthly_Deposits As Integer
        Dim Final_End_of_Month_Balance As Integer

        Console.Write("Enter Monthly Starting Balance:")
        Monthly_Start_Balance = Console.ReadLine()
        Console.Write("Enter Total Monthly Withdrawals:")
        Total_Monthly_Withdrawals = Console.ReadLine()
        Console.Write("Enter Total Monthly Deposits:")
        Total_Monthly_Deposits = Console.ReadLine()

        Balance = Monthly_Start_Balance - Total_Monthly_Withdrawals

        New_Balance = Balance + Total_Monthly_Deposits

        Monthly_Fee = New_Balance * 0.01

        Final_End_of_Month_Balance = New_Balance - Monthly_Fee

        Console.WriteLine(Final_End_of_Month_Balance.ToString())
    End Sub

End Module
