Imports System

Module Program
    Sub Main()
        Dim edad As Integer
        Dim entrada As String

        ' Solicitar la edad de la persona
        Console.WriteLine("Ingrese su edad:")
        entrada = Console.ReadLine()

        ' Verificar si la entrada es un número válido
        If Integer.TryParse(entrada, edad) Then
            ' Determinar si es mayor o menor de 18 años
            If edad >= 18 Then
                Console.WriteLine("la persona es mayor de edad.")
            Else
                Console.WriteLine("la persona es menor de edad.")
            End If
        Else
            Console.WriteLine("Edad no válida.")
        End If

        ' Esperar a que el usuario presione una tecla para finalizar
        Console.WriteLine("Presione cualquier tecla para finalizar.")
        Console.ReadKey()
    End Sub
End Module
