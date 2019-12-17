Imports System.Text
Imports System.IO


Public Class Form1
    Public serverPair As New Dictionary(Of String, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FILE_NAME As String = "hash.dat"
        If IO.File.Exists(FILE_NAME) Then
            Using sr As New IO.StreamReader(FILE_NAME)
                While Not sr.EndOfStream
                    serverPair.Add(sr.ReadLine, sr.ReadLine)
                End While
            End Using
        Else
            MsgBox("Error loading history items!")
        End If

        'For Each item In serverPair
        '    history.lstHistory.Items.Add(item.Value + " | " + item.Key)
        'Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim sb As New StringBuilder()
        serverPair.Add(cmbHash.Text.ToString(), cmbUrl.Text.ToString())

        For Each item In serverPair
            sb.AppendFormat("{0}{1}{2}{3}", item.Key, Environment.NewLine, item.Value, Environment.NewLine)
        Next

        Dim FILE_NAME As String = "hash.dat"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(sb.ToString())
            objWriter.Close()
        Else
            MsgBox("Error writing combobox data.")
        End If
    End Sub

    Private Sub llblHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblHistory.LinkClicked
        history.Show()
    End Sub
End Class
