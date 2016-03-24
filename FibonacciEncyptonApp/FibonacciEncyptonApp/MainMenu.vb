Imports System.IO
Imports System.Numerics

Public Class MainMenu
    Private Sub btnFileSelection_Click(sender As Object, e As EventArgs) Handles btnFileSelection.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        Dim largnum As String = "222232244629420445529739893461909967206666939096499764990979600"
        Dim value As BigInteger = BigInteger.Parse(largnum)

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    'read file here

                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnEncyption_Click(sender As Object, e As EventArgs) Handles btnEncyption.Click

    End Sub

    Private Sub btnDecyption_Click(sender As Object, e As EventArgs) Handles btnDecyption.Click

    End Sub
End Class
