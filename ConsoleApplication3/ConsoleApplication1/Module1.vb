Module Module1

    Sub Main()
        Dim max_num_elements As Integer = 50
        Dim index As Integer
        Dim input_value As Integer
        Dim value_array(max_num_elements) As Integer

        index = 0
        input_value = Console.ReadLine()

        Do While (input_value <> 0) And (index < max_num_elements)
            index = index + 1
            value_array(index) = input_value
            input_value = Console.ReadLine()
        Loop
    End Sub

End Module
