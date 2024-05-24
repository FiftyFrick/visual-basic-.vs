Imports System

Module Program
    Sub Main()
        Dim cantidadEmpleados As Integer
        Dim nombre As String
        Dim horasTrabajadas As Double
        Dim salarioPorHora As Double
        Dim totalHorasTrabajadas() As Double
        Dim salariosSemanales() As Double
        Dim nombres() As String
        Dim maxHorasTrabajadas As Double = 0
        Dim empleadoQueMasTrabaja As String = ""
        Dim entrada As String

        Console.WriteLine("reporte semanal de empresa de lunes a domingos:")

        ' Ingresar la cantidad de empleados
        Console.WriteLine("Ingrese la cantidad de empleados:")
        entrada = Console.ReadLine()
        If Integer.TryParse(entrada, cantidadEmpleados) Then
            ReDim totalHorasTrabajadas(cantidadEmpleados - 1)
            ReDim salariosSemanales(cantidadEmpleados - 1)
            ReDim nombres(cantidadEmpleados - 1)

            ' Ingresar datos de los empleados
            For i As Integer = 0 To cantidadEmpleados - 1
                Console.WriteLine("Ingrese los datos del empleado " & (i + 1) & ":")
                Console.Write("Nombre: ")
                nombres(i) = Console.ReadLine()

                Console.Write("Horas trabajadas: ")
                entrada = Console.ReadLine()
                If Double.TryParse(entrada, horasTrabajadas) Then
                    totalHorasTrabajadas(i) = horasTrabajadas * 7
                Else
                    Console.WriteLine("Horas trabajadas no válidas. Saliendo del programa.")
                    Return
                End If

                Console.Write("Salario por hora: ")
                entrada = Console.ReadLine()
                If Double.TryParse(entrada, salarioPorHora) Then
                    salariosSemanales(i) = (horasTrabajadas * salarioPorHora) * 7
                Else
                    Console.WriteLine("Salario por hora no válido. Saliendo del programa.")
                    Return
                End If
            Next

            ' Calcular y mostrar resultados
            For i As Integer = 0 To cantidadEmpleados - 1
                Console.WriteLine(vbCrLf & "Empleado: " & nombres(i))
                Console.WriteLine("Total de horas trabajadas en la semana: " & totalHorasTrabajadas(i))
                Console.WriteLine("Salario semanal: " & salariosSemanales(i))

                If totalHorasTrabajadas(i) > maxHorasTrabajadas Then
                    maxHorasTrabajadas = totalHorasTrabajadas(i)
                    empleadoQueMasTrabaja = nombres(i)
                End If
            Next

            Console.WriteLine(vbCrLf & "El empleado que más trabaja es: " & empleadoQueMasTrabaja)

            ' Esperar entrada "f" para finalizar el programa
            While True
                Console.WriteLine(vbCrLf & "Ingrese 'f' para finalizar el programa.")
                entrada = Console.ReadLine()
                If entrada.ToLower() = "f" Then
                    Exit While
                End If
            End While
        Else
            Console.WriteLine("Cantidad de empleados no válida. Saliendo del programa.")
        End If
    End Sub
End Module
