Imports System.IO

Module Module1

    Sub Main()
        ' Setting a variable for a text file
        Dim TextFile As StreamReader
        ' Setting a variable for the value of each record read
        Dim TextRecord As String
        ' Setting a variable for the List in each string
        Dim Fields() As String
        ' Setting a variable for the data in the list of each string
        Dim Employee, Rate, Hours As String

        ' Setting the text file as the document read from a file
        TextFile = New StreamReader("C:\Employee.txt")

        ' Repeat until all employees have been calculated
        Do
            ' Reading an individual line in the text file
            TextRecord = TextFile.ReadLine()

            ' Error check to ensure that there is data in the string being read
            If TextRecord IsNot Nothing Then


            End If
        Loop
    End Sub

End Module
