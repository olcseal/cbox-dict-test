Public Class history
    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mainX As Integer = Form1.Location.X + Form1.Width
        Dim mainY As Integer = Form1.Location.Y

        Me.Location = New Point(mainX, mainY)

        For Each item In Form1.serverPair
            lstHistory.Items.Add(item.Value + " | " + item.Key)
        Next

    End Sub

    Private Sub lstHistory_DoubleClick(sender As Object, e As EventArgs) Handles lstHistory.DoubleClick
        Dim selection = lstHistory.SelectedItem
        Dim selArray() As String = Split(selection, " | ")
        Form1.cmbUrl.Text = selArray(0)
        Form1.cmbHash.Text = selArray(1)
        Me.Close()
    End Sub
End Class