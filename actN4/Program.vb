Imports System
Module Operaciones
    Sub Main()
        Dim num1, num2 As Integer
        Dim operacion As String
        Dim resultado As Integer

        ' Solicitar el primer número
        Console.WriteLine("Ingrese el primer número:")
        num1 = CInt(Console.ReadLine())  ' Leer y convertir la entrada directamente a Integer

        ' Solicitar el segundo número
        Console.WriteLine("Ingrese el segundo número:")
        num2 = CInt(Console.ReadLine())  ' Leer y convertir la entrada directamente a Integer

        ' Solicitar la operación a realizar
        Console.WriteLine("Elija la operación a realizar: suma (s), resta (r), multiplicación (m)")
        operacion = Console.ReadLine().ToLower()  ' Leer la entrada y convertir a minúsculas

        ' Realizar la operación según la elección del usuario
        If operacion = "s" Then
            resultado = num1 + num2
            Console.WriteLine("El resultado de la suma es: " & resultado)
        ElseIf operacion = "r" Then
            resultado = num1 - num2
            Console.WriteLine("El resultado de la resta es: " & resultado)
        ElseIf operacion = "m" Then
            resultado = num1 * num2
            Console.WriteLine("El resultado de la multiplicación es: " & resultado)
        Else
            Console.WriteLine("Operación no válida. Saliendo del programa.")
            Return
        End If

        ' Esperar a que el usuario presione una tecla para finalizar
        Console.WriteLine("Presione cualquier tecla para finalizar.")
        Console.ReadKey()
    End Sub
End Module
