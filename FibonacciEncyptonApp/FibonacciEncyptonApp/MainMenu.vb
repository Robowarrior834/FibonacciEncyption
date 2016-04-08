Imports System.IO
Imports System
Imports System.Numerics

Public Class MainMenu
    Private DecryptStream As Stream = Nothing
    Private DecryptPath As String
    Private EncyptPath As String
    Private EncryptStream As Stream = Nothing
    Public FibonacciNumbers As New ArrayList
    Private encrytionKey As New ArrayList


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
        GenFibonacci(keyvalue)
        keyGeneration()
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
        Dim number1 As String = "1"
        Dim number0 As String = "0"
        Dim number2 As String = "1"
        'Dim test As String = "2"
        'Dim test2 As String = "3"
        'Dim valtest As BigInteger = BigInteger.Parse(test)
        'Dim valtest2 As BigInteger = BigInteger.Parse(test2)
        'Dim valtest3 As BigInteger
        'valtest3 = valtest * valtest2
        Dim zero As BigInteger = BigInteger.Parse(number0)
        Dim preold As BigInteger = BigInteger.Parse(number1)
        Dim old As BigInteger = BigInteger.Parse(number2)
        Dim NewNumber As BigInteger
        FibonacciNumbers.Add(zero)
        FibonacciNumbers.Add(preold)
        FibonacciNumbers.Add(old)
        For i As Integer = 2 To keyvalue Step 1
            NewNumber = preold + old
            preold = old
            old = NewNumber
            FibonacciNumbers.Add(NewNumber)
            FibonacciNumbers.RemoveAt(0)

        Next
    End Sub
    Private Sub keyGeneration()
        Dim row1 As New ArrayList
        Dim row2 As New ArrayList
        Dim size As New Integer
        size = FibonacciNumbers.Count - 1
        row1.Add(FibonacciNumbers(size))
        row1.Add(FibonacciNumbers(size - 1))
        row2.Add(FibonacciNumbers(size - 1))
        row2.Add(FibonacciNumbers(size - 2))
        encrytionKey.Add(row1)
        encrytionKey.Add(row2)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Object
        Dim b As Object
        Dim c As Object
        For i = 0 To 2
            For j = 0 To 2
                a(i, j) = InputBox("Enter the elements of the 1st matrix.")
            Next j
        Next i


        For i = 0 To 2
            For j = 0 To 2
                b(i, j) = InputBox("Enter the elements of the 2nd matrix")
            Next j
        Next i

        For i = 0 To 2
            For j = 0 To 2
                c(i, j) = 0
                For k = 0 To 2
                    c(i, j) = c(i, j) + a(i, k) * b(k, j)
                Next k
            Next j
        Next i

        For i = 0 To 2
            For j = 0 To 2
                MsgBox(c(i, j))
            Next j
        Next i
    End Sub

End Class
