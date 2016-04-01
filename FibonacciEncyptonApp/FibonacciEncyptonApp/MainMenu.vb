Imports System.IO
Imports System
Imports System.Numerics

Public Class MainMenu
    Private DecryptStream As Stream = Nothing
    Private DecryptPath As String
    Private EncyptPath As String
    Private EncryptStream As Stream = Nothing

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog
        'Dim largnum As String = "222232244629420445529739893461909967206666939096499764990979600"
        'Dim value As BigInteger = BigInteger.Parse(largnum)

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt"

        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            EncyptPath = openFileDialog1.FileName
        End If


    End Sub

    Private Sub OpenDecryptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDecryptToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "locked files (*.locked)|*.locked"

        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            DecryptPath = openFileDialog1.FileName
        End If
    End Sub

    Private Sub btnEncypt_Click(sender As Object, e As EventArgs) Handles btnEncypt.Click
        Dim inputFile As StreamReader
        Dim buffer(1) As Char
        Dim index As Integer
        Dim count As Integer
        index = 0
        count = 2
        Try
            inputFile = File.OpenText(EncyptPath)
            inputFile.ReadBlock(buffer, index, count)

            lblName2.Text = buffer(0) + buffer(1)
            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Dim inputFile As StreamReader
        Dim buffer(1) As Char
        Dim index As Integer
        Dim count As Integer
        index = 0
        count = 2
        Try
            inputFile = File.OpenText(DecryptPath)
            inputFile.ReadBlock(buffer, index, count)

            lblName2.Text = buffer(0) + buffer(1)
        Catch ex As Exception

        End Try
    End Sub

End Class
