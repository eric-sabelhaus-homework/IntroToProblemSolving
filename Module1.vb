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
        Dim Fields() As String
        ' Setting a variable for the data in the list of each string
        Dim ItemNumber As String
        ' Setting numeral variable of the field
        Dim OpenInventory, SoldInventory, PurchasedInventory, FinalInventory As Integer


        ' Setting the text file as the document read from a file
        TextFile = New StreamReader("C:\Inventory.txt")

        'Setting the output file as a new .txt file
        OutFile = New StreamWriter("C:\InventoryReport.txt")

        Do While TextRecord IsNot Nothing
            '  Open text file
            TextRecord = TextFile.ReadLine()

            If TextRecord IsNot Nothing Then
                '  Write a single record
                OutFile.WriteLine("{0},{1},{2},{3},{4}", ItemNumber, OpenInventory, _
                    SoldInventory, PurchasedInventory, FinalInventory)
            End If
        Loop
        '  Close text file
        TextFile.Close()
        OutFile.Close()

    End Sub

End Module

