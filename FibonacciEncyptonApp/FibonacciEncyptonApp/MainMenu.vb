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
        Dim tempString As String
        Dim currentchars As New ArrayList
        Dim row1 As New ArrayList
        Dim row2 As New ArrayList
        Dim tempValue As BigInteger
        index = 0
        count = 2
        keyvalue = txtKeyNumber.Text
        GenFibonacci(keyvalue)
        keyGeneration()
        Try
            inputFile = File.OpenText(EncyptPath)
            inputFile.ReadBlock(buffer, index, count)
            Select Case buffer(0)
                Case "a"
                    tempString = "0"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "b"
                    tempString = "1"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "c"
                    tempString = "2"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "d"
                    tempString = "3"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "e"
                    tempString = "4"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "f"
                    tempString = "5"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "g"
                    tempString = "6"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "h"
                    tempString = "7"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "i"
                    tempString = "8"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "j"
                    tempString = "9"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "k"
                    tempString = "10"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "l"
                    tempString = "11"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "m"
                    tempString = "12"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "n"
                    tempString = "13"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "o"
                    tempString = "14"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "p"
                    tempString = "15"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "q"
                    tempString = "16"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "r"
                    tempString = "17"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "s"
                    tempString = "18"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "T"
                    tempString = "19"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "u"
                    tempString = "20"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "v"
                    tempString = "21"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "w"
                    tempString = "22"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "x"
                    tempString = "23"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "y"
                    tempString = "24"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "z"
                    tempString = "25"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "A"
                    tempString = "26"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "B"
                    tempString = "27"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "C"
                    tempString = "28"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "D"
                    tempString = "29"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "E"
                    tempString = "30"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "F"
                    tempString = "31"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "G"
                    tempString = "32"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "H"
                    tempString = "33"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "I"
                    tempString = "34"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "J"
                    tempString = "35"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "K"
                    tempString = "36"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "L"
                    tempString = "37"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "M"
                    tempString = "38"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "N"
                    tempString = "39"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "O"
                    tempString = "40"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "P"
                    tempString = "41"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "Q"
                    tempString = "42"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "R"
                    tempString = "43"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "S"
                    tempString = "44"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "T"
                    tempString = "45"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "U"
                    tempString = "46"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "V"
                    tempString = "47"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "W"
                    tempString = "48"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "X"
                    tempString = "49"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "Y"
                    tempString = "50"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "Z"
                    tempString = "51"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "."
                    tempString = "52"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "?"
                    tempString = "53"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "!"
                    tempString = "54"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case ","
                    tempString = "55"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "'"
                    tempString = "56"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "-"
                    tempString = "57"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case """"
                    tempString = "58"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case vbCr
                    tempString = "59"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case " "
                    tempString = "60"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "0"
                    tempString = "61"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "1"
                    tempString = "62"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "3"
                    tempString = "63"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "4"
                    tempString = "64"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "5"
                    tempString = "65"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "6"
                    tempString = "66"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "7"
                    tempString = "67"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "8"
                    tempString = "68"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "9"
                    tempString = "69"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
                Case "\"
                    tempString = "70"
                    tempValue = BigInteger.Parse(tempString)
                    row1.Add(tempValue)
            End Select
            Select Case buffer(1)
                Case "a"
                    tempString = "0"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "b"
                    tempString = "1"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "c"
                    tempString = "2"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "d"
                    tempString = "3"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "e"
                    tempString = "4"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "f"
                    tempString = "5"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "g"
                    tempString = "6"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "h"
                    tempString = "7"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "i"
                    tempString = "8"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "j"
                    tempString = "9"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "k"
                    tempString = "10"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "l"
                    tempString = "11"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "m"
                    tempString = "12"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "n"
                    tempString = "13"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "o"
                    tempString = "14"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "p"
                    tempString = "15"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "q"
                    tempString = "16"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "r"
                    tempString = "17"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "s"
                    tempString = "18"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "T"
                    tempString = "19"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "u"
                    tempString = "20"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "v"
                    tempString = "21"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "w"
                    tempString = "22"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "x"
                    tempString = "23"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "y"
                    tempString = "24"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "z"
                    tempString = "25"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "A"
                    tempString = "26"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "B"
                    tempString = "27"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "C"
                    tempString = "28"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "D"
                    tempString = "29"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "E"
                    tempString = "30"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "F"
                    tempString = "31"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "G"
                    tempString = "32"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "H"
                    tempString = "33"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "I"
                    tempString = "34"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "J"
                    tempString = "35"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "K"
                    tempString = "36"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "L"
                    tempString = "37"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "M"
                    tempString = "38"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "N"
                    tempString = "39"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "O"
                    tempString = "40"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "P"
                    tempString = "41"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "Q"
                    tempString = "42"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "R"
                    tempString = "43"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "S"
                    tempString = "44"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "T"
                    tempString = "45"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "U"
                    tempString = "46"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "V"
                    tempString = "47"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "W"
                    tempString = "48"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "X"
                    tempString = "49"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "Y"
                    tempString = "50"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "Z"
                    tempString = "51"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "."
                    tempString = "52"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "?"
                    tempString = "53"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "!"
                    tempString = "54"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case ","
                    tempString = "55"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "'"
                    tempString = "56"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "-"
                    tempString = "57"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case """"
                    tempString = "58"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case vbCr
                    tempString = "59"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case " "
                    tempString = "60"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "0"
                    tempString = "61"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "1"
                    tempString = "62"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "3"
                    tempString = "63"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "4"
                    tempString = "64"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "5"
                    tempString = "65"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "6"
                    tempString = "66"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "7"
                    tempString = "67"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "8"
                    tempString = "68"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "9"
                    tempString = "69"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
                Case "\"
                    tempString = "70"
                    tempValue = BigInteger.Parse(tempString)
                    row2.Add(tempValue)
            End Select
            currentchars.Add(row1)
            currentchars.Add(row2)



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
