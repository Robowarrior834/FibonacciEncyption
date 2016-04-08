Imports System.IO
Imports System
Imports System.Numerics

Public Class MainMenu
    Private DecryptStream As Stream = Nothing
    Private DecryptPath As String
    Private EncyptPath As String
    Private EncryptStream As Stream = Nothing
    Public FibonacciNumbers As New List(Of BigInteger)


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog

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
        Dim keyvalue As Integer
        index = 0
        count = 2
        keyvalue = txtKeyNumber.Text
        GenFibonacci()
        Try
            inputFile = File.OpenText(EncyptPath)
            inputFile.ReadBlock(buffer, index, count)

            'lblName2.Text = buffer(0) + buffer(1)


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
    Private Sub GenFibonacci(ByVal keyvalue As Integer) 'Generates the first 300 fibonacci numbers in less then a second
        Dim number1 As String = "0"
        Dim number2 As String = "1"
        Dim preold As BigInteger = BigInteger.Parse(number1)
        Dim old As BigInteger = BigInteger.Parse(number2)
        Dim NewNumber As BigInteger
        FibonacciNumbers.Add(preold)
        FibonacciNumbers.Add(old)
        For i As Integer = 3 To keyvalue Step 1
            NewNumber = preold + old
            preold = old
            old = NewNumber
            FibonacciNumbers.Add(NewNumber)
        Next
    End Sub

End Class
