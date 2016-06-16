Public Class Form1

    Private Sub cmdEnhance_Click(sender As Object, e As EventArgs) Handles cmdEnhance.Click
        Me.openSesame.ShowDialog()


    End Sub

    Private Sub openSesame_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openSesame.FileOk

        Dim streamRead As New System.IO.StreamReader(Me.openSesame.OpenFile())

        Dim streamWrite As New System.IO.StreamWriter(Me.openSesame.FileName + "out.txt", False)
        Dim blockOfText = streamRead.ReadToEnd()

        ' turn wall of text into array of co-ord triplits
        Dim kmlPoints = blockOfText.Split(" ")

        streamWrite.WriteLine("[[")
        For Each kPoint In kmlPoints
            'break triplit into points
            Dim pointy = kPoint.Split(",")
            streamWrite.WriteLine("[" & pointy(0) & ", " & pointy(1) & "],")
        Next

        streamWrite.WriteLine("]]")
        streamWrite.Close()

        MessageBox.Show("DONE, THANKS")
    End Sub
End Class
