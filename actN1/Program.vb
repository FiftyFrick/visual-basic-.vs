Imports System

Module Program
    Sub Main()
        Dim cuota As Double
        Dim tipoPoliza As String
        Dim recargo As Double
        Dim edad As Integer
        Dim bebidaAlcoholica As String
        Dim utilizaLentes As String
        Dim padeceEnfermedad As String
        Dim finalizar As String

        While True
            ' Solicitar el tipo de póliza
            Console.WriteLine("Seleccione el tipo de póliza: Cobertura Amplia (A) o Cobertura a Terceros (B)")
            tipoPoliza = Console.ReadLine().ToUpper()

            ' Determinar la cuota base según el tipo de póliza
            If tipoPoliza = "A" Then
                cuota = 500
            ElseIf tipoPoliza = "B" Then
                cuota = 250
            Else
                Console.WriteLine("Tipo de póliza no válido. Saliendo del programa.")
                Return
            End If

            ' Inicializar recargo
            recargo = 0

            ' Preguntar por el consumo de alcohol
            Console.WriteLine("¿Ha consumido bebidas alcohólicas? (S/N)")
            bebidaAlcoholica = Console.ReadLine().ToUpper()
            If bebidaAlcoholica = "S" Then
                recargo += 0.1
            End If

            ' Preguntar si utiliza lentes
            Console.WriteLine("¿Utiliza lentes? (S/N)")
            utilizaLentes = Console.ReadLine().ToUpper()
            If utilizaLentes = "S" Then
                recargo += 0.05
            End If

            ' Preguntar si padece alguna enfermedad
            Console.WriteLine("¿Padece alguna enfermedad? (S/N)")
            padeceEnfermedad = Console.ReadLine().ToUpper()
            If padeceEnfermedad = "S" Then
                recargo += 0.05
            End If

            ' Preguntar por la edad
            Console.WriteLine("Ingrese su edad:")
            If Integer.TryParse(Console.ReadLine(), edad) Then
                If edad > 40 Then
                    recargo += 0.2
                Else
                    recargo += 0.1
                End If
            Else
                Console.WriteLine("Edad no válida. Saliendo del programa.")
                Return
            End If

            ' Calcular la cuota final
            Dim cuotaFinal As Double = cuota + (cuota * recargo)
            Console.WriteLine("La cuota final para la póliza seleccionada es: $" & cuotaFinal)

            ' Preguntar si desea finalizar el programa
            Console.WriteLine("¿Desea finalizar el programa? (S/N)")
            finalizar = Console.ReadLine().ToUpper()
            If finalizar = "S" Then
                Exit While
            End If
        End While
    End Sub
End Module
