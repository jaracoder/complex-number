Module ComplexNumberTest

    Sub Main()
        Dim number1 As New ComplexNumber()
        Dim number2 As New ComplexNumber()

        number1.Establecer(13.333, 11.003457)
        Console.WriteLine("Num 1: " & number1.ToString())

        number2.Establecer(9.0001, 10.123)
        Console.WriteLine("Num 2: " & number2.ToString())

        Console.WriteLine()

        Dim suma As ComplexNumber = number1.Suma(number2)
        Console.WriteLine("Suma: " & suma.ToString())

        Dim resta As ComplexNumber = number1.Resta(number2)
        Console.WriteLine("Resta: " & suma.ToString())

        Dim multi As ComplexNumber = number1.Multiplicacion(number2)
        Console.WriteLine("Multiplicacion: " & suma.ToString())

        Console.Read()
    End Sub

End Module
