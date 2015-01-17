Imports System.IO

Module Module1

    Sub Main()
        ' Setting a variable for a text file
        Dim TextFile As StreamReader
        '  Write Text to File
        '  A variable for text file
        Dim OutFile As StreamWriter
        ' Setting a variable for the value of each record read
        Dim TextRecord As String = ""
        ' Setting a variable for the List in each string
        Dim Field() As String
        ' Setting variables for the numbers int the list of each string
        Dim Customer_Number, Call_Distance, Customer_Name, Number_Called, Minutes_Used, Usage_Fee As String
        ' Setting a variable for the total revenue
        Dim Total_Charge As Integer

        ' Setting the text file as the document read from a file
        TextFile = New StreamReader("C:\PhoneLog.txt")

        'Setting the output file as a new .txt file
        OutFile = New StreamWriter("C:\Users\Public\Documents\RevenueReport.txt")

        Total_Charge = 0

        Do While TextRecord IsNot Nothing
            '  Open text file
            TextRecord = TextFile.ReadLine()

            If TextRecord IsNot Nothing Then
                'Setting the field
                Field = TextRecord.Split(",")

                'Setting the different fields of each line
                Customer_Name = Field(0)
                Customer_Number = Field(1)
                Number_Called = Field(2)
                Call_Distance = Field(3)
                Minutes_Used = Field(4)

                'Decision if distance is 25km
                If (Call_Distance < 25) Then
                    'Charge .35 cents a minute
                    Usage_Fee = Minutes_Used * 0.35
                    Total_Charge = Total_Charge + Usage_Fee

                    OutFile.WriteLine("Subscriber Name" & "      " & "Number" & "       " & "Called" & "     " & "Charge" & "       ")
                    OutFile.WriteLine(Customer_Name.ToString() & "        " & Customer_Number.ToString() & "  " & Number_Called.ToString() & "    " & Usage_Fee.ToString())

                    'Decision if distance is 25-75km
                ElseIf (Call_Distance > 25 And Call_Distance < 75) Then
                    'Charge .65 cents a minute
                    Usage_Fee = Minutes_Used * 0.65
                    'Add Charge to Total charge
                    Total_Charge = Total_Charge + Usage_Fee

                    'Write Header Line
                    OutFile.WriteLine("Subscriber Name" & "       " & "Number" & "       " & "Called" & "     " & "Charge" & "       ")
                    'Write Information/Data line
                    OutFile.WriteLine(Customer_Name.ToString() & "        " & Customer_Number.ToString() & "  " & Number_Called.ToString() & "    " & Usage_Fee.ToString())

                    'Decision if distance is 75-300km
                ElseIf (Call_Distance > 75 And Call_Distance < 300) Then
                    'Charge 1 dollar a minute
                    Usage_Fee = Minutes_Used * 1.0
                    'Add charge to total charge
                    Total_Charge = Total_Charge + Usage_Fee

                    'Write Header Line
                    OutFile.WriteLine("Subscriber Name" & "       " & "Number" & "       " & "Called" & "     " & "Charge" & "       ")
                    'Write Information/Data line
                    OutFile.WriteLine(Customer_Name.ToString() & "        " & Customer_Number.ToString() & "  " & Number_Called.ToString() & "    " & Usage_Fee.ToString())

                    'Decision if distance is 300-1000km
                ElseIf (Call_Distance > 300 And Call_Distance < 1000) Then
                    'Charge 2 dollars a minute
                    Usage_Fee = Minutes_Used * 2.0
                    'Add charge to total charge
                    Total_Charge = Total_Charge + Usage_Fee

                    'Write Header Line
                    OutFile.WriteLine("Subscriber Name" & "       " & "Number" & "       " & "Called" & "     " & "Charge" & "       ")
                    'Write Information/Data line
                    OutFile.WriteLine(Customer_Name.ToString() & "        " & Customer_Number.ToString() & "  " & Number_Called.ToString() & "    " & Usage_Fee.ToString())

                    'Decision if distance is over 1000km
                ElseIf (Call_Distance > 1000) Then
                    'Charge 3 dollars a minute
                    Usage_Fee = Minutes_Used * 3.0
                    'Add charge to total charge
                    Total_Charge = Total_Charge + Usage_Fee

                    'Write Header Line
                    OutFile.WriteLine("Subscriber Name" & "       " & "Number" & "       " & "Called" & "     " & "Charge" & "       ")
                    'Write Information/Data line
                    OutFile.WriteLine(Customer_Name.ToString() & "        " & Customer_Number.ToString() & "  " & Number_Called.ToString() & "    " & Usage_Fee.ToString())
                End If
            End If
            'Closing loop
        Loop
        'Write out total charge at the end of the file
        OutFile.WriteLine("                              " & "**Total Charge =" & Total_Charge.ToString())
        TextFile.Close()
        OutFile.Close()
    End Sub

End Module
