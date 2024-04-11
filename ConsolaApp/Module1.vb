Module Module1

    'Funcion' 
    Function suma(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    Sub Main()

        'Variables'
        Dim numerito = 5

        numerito = "7"

        Console.WriteLine(numerito)

        'Tipar variables'
        Console.WriteLine("Por favor ingrese un numero: ")
        Dim respuesta As Integer = Console.ReadLine()

        'Concatenacion'
        Console.WriteLine($"Usted ingreso el numero: {respuesta}")

        'Condicionales'
        If respuesta = 0 Then
            Console.WriteLine("El numero que ingresaste es cero")
        End If

        If respuesta = 0 Then
            Console.WriteLine("El numero que ingresaste es cero")
        Else
            Console.WriteLine("El numero que ingresaste no es cero")
        End If

        Dim esPar As Boolean = (respuesta Mod 2 = 0)
        Dim esPositivo As Boolean = (respuesta > 0)

        If esPar And esPositivo Then
            Console.WriteLine("El numero es par y positivo")
        ElseIf Not esPositivo And esPar Then
            Console.WriteLine("El numero negativo y es par")
        Else
            Console.WriteLine("El es positivo y no es par")
        End If

        'Vector'

        Dim vecty(5) As String

        vecty(0) = "Chicho"

        Console.WriteLine($"Vecty(0): {vecty(0)}")

        'Lista'

        Dim listita As List(Of String) = New List(Of String)
        Dim listitaPiola As New List(Of String)

        listitaPiola.Add("Hola")
        listitaPiola.Add("Mundo")
        listitaPiola.Add("Esto")
        listitaPiola.Add("Es")
        listitaPiola.Add("Una")
        listitaPiola.Add("Lista")

        Dim listitaMasPiola As New List(Of String) From {"Hola", "Mundo", "Esto", "Es", "Una", "Lista"}

        'Bucles'

        While 1 < 5
            Console.WriteLine("Entre al whie")
            Exit While
        End While

        For i = 1 To 10
            Console.WriteLine(i)
        Next

        Do While 1 < 5
            Console.WriteLine("Entre al do while")
            Exit Do
        Loop

        For Each elemento In listitaPiola
            Console.WriteLine(elemento)
        Next

        Console.ReadLine()
    End Sub

End Module
