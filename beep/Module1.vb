Module Module1

    Sub Main()
        Dim args As Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        Dim times As Integer = If(args.Count >= 1, args(0), 1)
        Dim frequency As Integer = 0
        Dim duration As Integer = 0
        If args.Count >= 3 Then
            frequency = args(1)
            duration = args(2)
        End If
        Dim pause As Integer = If(args.Count >= 4, args(3), 1000)
        For i = 1 To times
            If Not frequency = 0 And Not duration = 0 Then
                Console.Beep(frequency, duration)
            Else
                Console.Beep()
            End If
            System.Threading.Thread.Sleep(pause)
        Next



    End Sub

End Module
