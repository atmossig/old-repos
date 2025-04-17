Module Module1
    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim ops As String
    Sub Main()
        Console.WriteLine("Enter the First Number." + vbNewLine)
        firstnum = Double.Parse(Console.ReadLine)

        Console.WriteLine("Select and operator: (+,-,*,/,^,%" + vbNewLine)
        ops = Console.ReadLine

        Console.WriteLine("Enter Second Number" + vbNewLine)
        secondnum = Double.Parse(Console.ReadLine)

        If (ops = "+") Then
            answer = firstnum + secondnum
        ElseIf (ops = "-") Then
            answer = firstnum - secondnum
        ElseIf (ops = "*") Then
            answer = firstnum * secondnum
        ElseIf (ops = "/") Then
            answer = firstnum / secondnum
        ElseIf (ops = "^") Then
            answer = firstnum ^ secondnum
        ElseIf (ops = "%") Then
            answer = firstnum Mod secondnum
        End If


        Console.WriteLine(answer)
        Console.ReadKey()
        Console.WriteLine("Enter the First Number." + vbNewLine)
        firstnum = Double.Parse(Console.ReadLine)

        Console.WriteLine("Select and operator: (+,-,*,/,^,%" + vbNewLine)
        ops = Console.ReadLine

        Console.WriteLine("Enter Second Number" + vbNewLine)
        secondnum = Double.Parse(Console.ReadLine)

        If (ops = "+") Then
            answer = firstnum + secondnum
        ElseIf (ops = "-") Then
            answer = firstnum - secondnum
        ElseIf (ops = "*") Then
            answer = firstnum * secondnum
        ElseIf (ops = "/") Then
            answer = firstnum / secondnum
        ElseIf (ops = "^") Then
            answer = firstnum ^ secondnum
        ElseIf (ops = "%") Then
            answer = firstnum Mod secondnum
        End If


        Console.WriteLine(answer)
        Console.ReadKey()




    End Sub

End Module
