Imports System.IO
Imports System
Imports System.Numerics

Public Class MainMenu
    Private DecryptStream As Stream = Nothing
    Private DecryptPath As String
    Private EncryptPath As String
    Private EncryptStream As Stream = Nothing
    Public FibonacciNumbers As New ArrayList
    Private encrytionKey As New ArrayList
    Private decryptionKey As New ArrayList
    Dim FilePath As String
    Dim FileSize As System.IO.FileInfo


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt"

        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            EncryptPath = openFileDialog1.FileName
            lblPath2.Text = EncryptPath
            lblPath2.Enabled = True
            lblPath2.Visible = True

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(EncryptPath)

            Dim fileName As String = testFile.Name
            lblName2.Text = fileName
            lblName2.Enabled = True
            lblName2.Visible = True

            Dim infoReader As System.IO.FileInfo
            infoReader = My.Computer.FileSystem.GetFileInfo(EncryptPath)
            lblSize2.Text = infoReader.Length & " bytes"
            lblSize2.Enabled = True
            lblSize2.Visible = True

            txtKeyNumber.Enabled = True
            txtKeyNumber.Visible = True

            btnEncypt.Enabled = True
            btnEncypt.Visible = True
        End If


    End Sub

    Private Sub OpenDecryptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDecryptToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "locked files (*.locked)|*.locked"

        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            DecryptPath = openFileDialog1.FileName
            lblPathDecrypt.Text = DecryptPath
            lblPathDecrypt.Enabled = True
            lblPathDecrypt.Visible = True


            Dim testFileDecrypt As System.IO.FileInfo
            testFileDecrypt = My.Computer.FileSystem.GetFileInfo(DecryptPath)

            Dim fileNameDecrypt As String = testFileDecrypt.Name
            lblNameDecrypt.Text = fileNameDecrypt
            lblNameDecrypt.Enabled = True
            lblNameDecrypt.Visible = True

            Dim infoReaderDecrypt As System.IO.FileInfo
            infoReaderDecrypt = My.Computer.FileSystem.GetFileInfo(DecryptPath)
            lblSizeDecrypt.Text = infoReaderDecrypt.Length & " bytes"
            lblSizeDecrypt.Enabled = True
            lblSizeDecrypt.Visible = True

            txtKeyDecrypt.Enabled = True
            txtKeyDecrypt.Visible = True

            btnDecrypt.Enabled = True
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
        Dim c As New ArrayList
        Dim outputPath As String
        Dim size As Integer

        '------------file-writing-----------------------
        Dim outputfile As StreamWriter
        '----------end-file-writing--------------
        index = 0
        count = 2
        keyvalue = txtKeyNumber.Text
        GenFibonacci(keyvalue)
        keyGeneration()
        Try
            size = File.ReadAllText(EncryptPath).Length
            inputFile = File.OpenText(EncryptPath)
            outputPath = Replace(EncryptPath, ".txt", ".locked")

            outputfile = My.Computer.FileSystem.OpenTextFileWriter(outputPath, False)
            encryptProgress.Maximum = size
            For i As Integer = 0 To size - 2 Step 2
                encryptProgress.Value = i
                inputFile.ReadBlock(buffer, index, count) ' Read two charractes to a buffer

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
                    Case "t"
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
                    Case "0"
                        tempString = "60"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "1"
                        tempString = "61"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "2"
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
                    Case vbLf
                        tempString = "71"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case " "
                        tempString = "72"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case ";"
                        tempString = "73"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "("
                        tempString = "74"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case ")"
                        tempString = "75"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case ":"
                        tempString = "76"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "~"
                        tempString = "77"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "`"
                        tempString = "78"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "*"
                        tempString = "79"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case vbTab
                        tempString = "80"
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
                    Case "t"
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
                    Case "0"
                        tempString = "60"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "1"
                        tempString = "61"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "2"
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
                    Case vbLf
                        tempString = "71"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case " "
                        tempString = "72"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case ";"
                        tempString = "73"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "("
                        tempString = "74"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case ")"
                        tempString = "75"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case ":"
                        tempString = "76"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "~"
                        tempString = "77"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "`"
                        tempString = "78"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "*"
                        tempString = "79"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case vbTab
                        tempString = "80"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)

                End Select
                currentchars.Add(row1)
                currentchars.Add(row2)

                matrixmulti(currentchars, c) 'multiply the arraylists together



                Dim temrow As New ArrayList
                Dim tempBig As BigInteger
                For j As Integer = 0 To 1 Step 1
                    Try
                        temrow = c(j)
                        tempBig = temrow(0)
                        '------------------Write-the-file-----------------------------------
                        If (tempBig.ToString() = "0") Then
                            outputfile.Write("a")
                        ElseIf (tempBig.ToString() = "1") Then
                            outputfile.Write("b")
                        ElseIf (tempBig.ToString() = "2") Then
                            outputfile.Write("c")
                        ElseIf (tempBig.ToString() = "3") Then
                            outputfile.Write("d")
                        ElseIf (tempBig.ToString() = "4") Then
                            outputfile.Write("e")
                        ElseIf (tempBig.ToString() = "5") Then
                            outputfile.Write("f")
                        ElseIf (tempBig.ToString() = "6") Then
                            outputfile.Write("g")
                        ElseIf (tempBig.ToString() = "7") Then
                            outputfile.Write("h")
                        ElseIf (tempBig.ToString() = "8") Then
                            outputfile.Write("i")
                        ElseIf (tempBig.ToString() = "9") Then
                            outputfile.Write("j")
                        ElseIf (tempBig.ToString() = "10") Then
                            outputfile.Write("k")
                        ElseIf (tempBig.ToString() = "11") Then
                            outputfile.Write("l")
                        ElseIf (tempBig.ToString() = "12") Then
                            outputfile.Write("m")
                        ElseIf (tempBig.ToString() = "13") Then
                            outputfile.Write("n")
                        ElseIf (tempBig.ToString() = "14") Then
                            outputfile.Write("o")
                        ElseIf (tempBig.ToString() = "15") Then
                            outputfile.Write("p")
                        ElseIf (tempBig.ToString() = "16") Then
                            outputfile.Write("q")
                        ElseIf (tempBig.ToString() = "17") Then
                            outputfile.Write("r")
                        ElseIf (tempBig.ToString() = "18") Then
                            outputfile.Write("s")
                        ElseIf (tempBig.ToString() = "19") Then
                            outputfile.Write("t")
                        ElseIf (tempBig.ToString() = "20") Then
                            outputfile.Write("u")
                        ElseIf (tempBig.ToString() = "21") Then
                            outputfile.Write("v")
                        ElseIf (tempBig.ToString() = "22") Then
                            outputfile.Write("w")
                        ElseIf (tempBig.ToString() = "23") Then
                            outputfile.Write("x")
                        ElseIf (tempBig.ToString() = "24") Then
                            outputfile.Write("y")
                        ElseIf (tempBig.ToString() = "25") Then
                            outputfile.Write("z")
                        ElseIf (tempBig.ToString() = "26") Then
                            outputfile.Write("A")
                        ElseIf (tempBig.ToString() = "27") Then
                            outputfile.Write("B")
                        ElseIf (tempBig.ToString() = "28") Then
                            outputfile.Write("C")
                        ElseIf (tempBig.ToString() = "29") Then
                            outputfile.Write("D")
                        ElseIf (tempBig.ToString() = "30") Then
                            outputfile.Write("E")
                        ElseIf (tempBig.ToString() = "31") Then
                            outputfile.Write("F")
                        ElseIf (tempBig.ToString() = "32") Then
                            outputfile.Write("G")
                        ElseIf (tempBig.ToString() = "33") Then
                            outputfile.Write("H")
                        ElseIf (tempBig.ToString() = "34") Then
                            outputfile.Write("I")
                        ElseIf (tempBig.ToString() = "35") Then
                            outputfile.Write("J")
                        ElseIf (tempBig.ToString() = "36") Then
                            outputfile.Write("K")
                        ElseIf (tempBig.ToString() = "37") Then
                            outputfile.Write("L")
                        ElseIf (tempBig.ToString() = "38") Then
                            outputfile.Write("M")
                        ElseIf (tempBig.ToString() = "39") Then
                            outputfile.Write("N")
                        ElseIf (tempBig.ToString() = "40") Then
                            outputfile.Write("O")
                        ElseIf (tempBig.ToString() = "41") Then
                            outputfile.Write("P")
                        ElseIf (tempBig.ToString() = "42") Then
                            outputfile.Write("Q")
                        ElseIf (tempBig.ToString() = "43") Then
                            outputfile.Write("R")
                        ElseIf (tempBig.ToString() = "44") Then
                            outputfile.Write("S")
                        ElseIf (tempBig.ToString() = "45") Then
                            outputfile.Write("T")
                        ElseIf (tempBig.ToString() = "46") Then
                            outputfile.Write("U")
                        ElseIf (tempBig.ToString() = "47") Then
                            outputfile.Write("V")
                        ElseIf (tempBig.ToString() = "48") Then
                            outputfile.Write("W")
                        ElseIf (tempBig.ToString() = "49") Then
                            outputfile.Write("X")
                        ElseIf (tempBig.ToString() = "50") Then
                            outputfile.Write("Y")
                        ElseIf (tempBig.ToString() = "51") Then
                            outputfile.Write("Z")
                        ElseIf (tempBig.ToString() = "52") Then
                            outputfile.Write(".")
                        ElseIf (tempBig.ToString() = "53") Then
                            outputfile.Write("?")
                        ElseIf (tempBig.ToString() = "54") Then
                            outputfile.Write("!")
                        ElseIf (tempBig.ToString() = "55") Then
                            outputfile.Write(",")
                        ElseIf (tempBig.ToString() = "56") Then
                            outputfile.Write("'")
                        ElseIf (tempBig.ToString() = "57") Then
                            outputfile.Write("-")
                        ElseIf (tempBig.ToString() = "58") Then
                            outputfile.Write("""")
                        ElseIf (tempBig.ToString() = "59") Then
                            outputfile.Write(vbCr)
                        ElseIf (tempBig.ToString() = "60") Then
                            outputfile.Write("0")
                        ElseIf (tempBig.ToString() = "61") Then
                            outputfile.Write("1")
                        ElseIf (tempBig.ToString() = "62") Then
                            outputfile.Write("2")
                        ElseIf (tempBig.ToString() = "63") Then
                            outputfile.Write("3")
                        ElseIf (tempBig.ToString() = "64") Then
                            outputfile.Write("4")
                        ElseIf (tempBig.ToString() = "65") Then
                            outputfile.Write("5")
                        ElseIf (tempBig.ToString() = "66") Then
                            outputfile.Write("6")
                        ElseIf (tempBig.ToString() = "67") Then
                            outputfile.Write("7")
                        ElseIf (tempBig.ToString() = "68") Then
                            outputfile.Write("8")
                        ElseIf (tempBig.ToString() = "69") Then
                            outputfile.Write("9")
                        ElseIf (tempBig.ToString() = "70") Then
                            outputfile.Write("\")
                        ElseIf (tempBig.ToString() = "71") Then
                            outputfile.Write(vbLf)
                        ElseIf (tempBig.ToString() = "72") Then
                            outputfile.Write(" ")
                        ElseIf (tempBig.ToString() = "73") Then
                            outputfile.Write(";")
                        ElseIf (tempBig.ToString() = "74") Then
                            outputfile.Write("(")
                        ElseIf (tempBig.ToString() = "75") Then
                            outputfile.Write(")")
                        ElseIf (tempBig.ToString() = "76") Then
                            outputfile.Write(":")
                        ElseIf (tempBig.ToString() = "77") Then
                            outputfile.Write("~")
                        ElseIf (tempBig.ToString() = "78") Then
                            outputfile.Write("`")
                        ElseIf (tempBig.ToString() = "79") Then
                            outputfile.Write("*")
                        ElseIf (tempBig.ToString() = "80") Then
                            outputfile.Write(vbTab)
                        End If
                    Catch ex As Exception

                    End Try

                Next
                currentchars.Clear()
                row1.Clear()
                row2.Clear()
                temrow.Clear()
                c.Clear()

            Next
            outputfile.Close()
            inputFile.Close()


        Catch ex As Exception
            outputfile.Close()
        End Try

        encrytionKey.Clear()

        Dim EncryptResponse = MsgBox("The file has been encrypted. Open file location?", MessageBoxButtons.YesNo)
        If EncryptResponse = MsgBoxResult.Yes Then
            Process.Start("C:\")
        End If

        encryptProgress.Value = 0
        lblName2.Enabled = False
        lblName2.Visible = False
        lblSize2.Enabled = False
        lblSize2.Visible = False
        lblPath2.Enabled = False
        lblPath2.Visible = False
        txtKeyNumber.Enabled = False
        txtKeyNumber.Text = ""
        btnEncypt.Enabled = False


    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
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
        Dim c As New ArrayList
        Dim outputPath As String
        Dim size As Integer

        '------------file-writing-----------------------
        Dim outputfile As StreamWriter
        '----------end-file-writing--------------
        index = 0
        count = 2
        keyvalue = txtKeyNumber.Text
        GenFibonacci(keyvalue)
        keyGenerationDecypt(keyvalue)
        Try
            size = File.ReadAllText(DecryptPath).Length
            inputFile = File.OpenText(DecryptPath)
            outputPath = Replace(DecryptPath, ".locked", ".txt")

            outputfile = My.Computer.FileSystem.OpenTextFileWriter(outputPath, False)
            decryptProgress.Maximum = size
            For i As Integer = 0 To size - 2 Step 2
                decryptProgress.Value = i
                inputFile.ReadBlock(buffer, index, count) ' Read two charractes to a buffer

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
                    Case "t"
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
                    Case ", "
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
                    Case "0"
                        tempString = "60"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "1"
                        tempString = "61"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "2"
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
                    Case vbLf
                        tempString = "71"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case " "
                        tempString = "72"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case ";"
                        tempString = "73"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "("
                        tempString = "74"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case ")"
                        tempString = "75"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case ":"
                        tempString = "76"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "~"
                        tempString = "77"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "`"
                        tempString = "78"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case "*"
                        tempString = "79"
                        tempValue = BigInteger.Parse(tempString)
                        row1.Add(tempValue)
                    Case vbTab
                        tempString = "80"
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
                    Case "t"
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
                    Case "0"
                        tempString = "60"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "1"
                        tempString = "61"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "2"
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
                    Case vbLf
                        tempString = "71"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case " "
                        tempString = "72"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case ";"
                        tempString = "73"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "("
                        tempString = "74"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case ")"
                        tempString = "75"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case ":"
                        tempString = "76"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "~"
                        tempString = "77"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "`"
                        tempString = "78"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case "*"
                        tempString = "79"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)
                    Case vbTab
                        tempString = "80"
                        tempValue = BigInteger.Parse(tempString)
                        row2.Add(tempValue)

                End Select
                currentchars.Add(row1)
                currentchars.Add(row2)

                matrixmultiDecypt(currentchars, c) 'multiply the arraylists together



                Dim temrow As New ArrayList
                Dim tempBig As BigInteger
                For j As Integer = 0 To 1 Step 1
                    Try
                        temrow = c(j)
                        tempBig = temrow(0)
                        '------------------Write-the-file-----------------------------------
                        If (tempBig.ToString() = "0") Then
                            outputfile.Write("a")
                        ElseIf (tempBig.ToString() = "1") Then
                            outputfile.Write("b")
                        ElseIf (tempBig.ToString() = "2") Then
                            outputfile.Write("c")
                        ElseIf (tempBig.ToString() = "3") Then
                            outputfile.Write("d")
                        ElseIf (tempBig.ToString() = "4") Then
                            outputfile.Write("e")
                        ElseIf (tempBig.ToString() = "5") Then
                            outputfile.Write("f")
                        ElseIf (tempBig.ToString() = "6") Then
                            outputfile.Write("g")
                        ElseIf (tempBig.ToString() = "7") Then
                            outputfile.Write("h")
                        ElseIf (tempBig.ToString() = "8") Then
                            outputfile.Write("i")
                        ElseIf (tempBig.ToString() = "9") Then
                            outputfile.Write("j")
                        ElseIf (tempBig.ToString() = "10") Then
                            outputfile.Write("k")
                        ElseIf (tempBig.ToString() = "11") Then
                            outputfile.Write("l")
                        ElseIf (tempBig.ToString() = "12") Then
                            outputfile.Write("m")
                        ElseIf (tempBig.ToString() = "13") Then
                            outputfile.Write("n")
                        ElseIf (tempBig.ToString() = "14") Then
                            outputfile.Write("o")
                        ElseIf (tempBig.ToString() = "15") Then
                            outputfile.Write("p")
                        ElseIf (tempBig.ToString() = "16") Then
                            outputfile.Write("q")
                        ElseIf (tempBig.ToString() = "17") Then
                            outputfile.Write("r")
                        ElseIf (tempBig.ToString() = "18") Then
                            outputfile.Write("s")
                        ElseIf (tempBig.ToString() = "19") Then
                            outputfile.Write("t")
                        ElseIf (tempBig.ToString() = "20") Then
                            outputfile.Write("u")
                        ElseIf (tempBig.ToString() = "21") Then
                            outputfile.Write("v")
                        ElseIf (tempBig.ToString() = "22") Then
                            outputfile.Write("w")
                        ElseIf (tempBig.ToString() = "23") Then
                            outputfile.Write("x")
                        ElseIf (tempBig.ToString() = "24") Then
                            outputfile.Write("y")
                        ElseIf (tempBig.ToString() = "25") Then
                            outputfile.Write("z")
                        ElseIf (tempBig.ToString() = "26") Then
                            outputfile.Write("A")
                        ElseIf (tempBig.ToString() = "27") Then
                            outputfile.Write("B")
                        ElseIf (tempBig.ToString() = "28") Then
                            outputfile.Write("C")
                        ElseIf (tempBig.ToString() = "29") Then
                            outputfile.Write("D")
                        ElseIf (tempBig.ToString() = "30") Then
                            outputfile.Write("E")
                        ElseIf (tempBig.ToString() = "31") Then
                            outputfile.Write("F")
                        ElseIf (tempBig.ToString() = "32") Then
                            outputfile.Write("G")
                        ElseIf (tempBig.ToString() = "33") Then
                            outputfile.Write("H")
                        ElseIf (tempBig.ToString() = "34") Then
                            outputfile.Write("I")
                        ElseIf (tempBig.ToString() = "35") Then
                            outputfile.Write("J")
                        ElseIf (tempBig.ToString() = "36") Then
                            outputfile.Write("K")
                        ElseIf (tempBig.ToString() = "37") Then
                            outputfile.Write("L")
                        ElseIf (tempBig.ToString() = "38") Then
                            outputfile.Write("M")
                        ElseIf (tempBig.ToString() = "39") Then
                            outputfile.Write("N")
                        ElseIf (tempBig.ToString() = "40") Then
                            outputfile.Write("O")
                        ElseIf (tempBig.ToString() = "41") Then
                            outputfile.Write("P")
                        ElseIf (tempBig.ToString() = "42") Then
                            outputfile.Write("Q")
                        ElseIf (tempBig.ToString() = "43") Then
                            outputfile.Write("R")
                        ElseIf (tempBig.ToString() = "44") Then
                            outputfile.Write("S")
                        ElseIf (tempBig.ToString() = "45") Then
                            outputfile.Write("T")
                        ElseIf (tempBig.ToString() = "46") Then
                            outputfile.Write("U")
                        ElseIf (tempBig.ToString() = "47") Then
                            outputfile.Write("V")
                        ElseIf (tempBig.ToString() = "48") Then
                            outputfile.Write("W")
                        ElseIf (tempBig.ToString() = "49") Then
                            outputfile.Write("X")
                        ElseIf (tempBig.ToString() = "50") Then
                            outputfile.Write("Y")
                        ElseIf (tempBig.ToString() = "51") Then
                            outputfile.Write("Z")
                        ElseIf (tempBig.ToString() = "52") Then
                            outputfile.Write(".")
                        ElseIf (tempBig.ToString() = "53") Then
                            outputfile.Write("?")
                        ElseIf (tempBig.ToString() = "54") Then
                            outputfile.Write("!")
                        ElseIf (tempBig.ToString() = "55") Then
                            outputfile.Write(",")
                        ElseIf (tempBig.ToString() = "56") Then
                            outputfile.Write("'")
                        ElseIf (tempBig.ToString() = "57") Then
                            outputfile.Write("-")
                        ElseIf (tempBig.ToString() = "58") Then
                            outputfile.Write("""")
                        ElseIf (tempBig.ToString() = "59") Then
                            outputfile.Write(vbCr)
                        ElseIf (tempBig.ToString() = "60") Then
                            outputfile.Write("0")
                        ElseIf (tempBig.ToString() = "61") Then
                            outputfile.Write("1")
                        ElseIf (tempBig.ToString() = "62") Then
                            outputfile.Write("2")
                        ElseIf (tempBig.ToString() = "63") Then
                            outputfile.Write("3")
                        ElseIf (tempBig.ToString() = "64") Then
                            outputfile.Write("4")
                        ElseIf (tempBig.ToString() = "65") Then
                            outputfile.Write("5")
                        ElseIf (tempBig.ToString() = "66") Then
                            outputfile.Write("6")
                        ElseIf (tempBig.ToString() = "67") Then
                            outputfile.Write("7")
                        ElseIf (tempBig.ToString() = "68") Then
                            outputfile.Write("8")
                        ElseIf (tempBig.ToString() = "69") Then
                            outputfile.Write("9")
                        ElseIf (tempBig.ToString() = "70") Then
                            outputfile.Write("\")
                        ElseIf (tempBig.ToString() = "71") Then
                            outputfile.Write(vbLf)
                        ElseIf (tempBig.ToString() = "72") Then
                            outputfile.Write(" ")
                        ElseIf (tempBig.ToString() = "73") Then
                            outputfile.Write(";")
                        ElseIf (tempBig.ToString() = "74") Then
                            outputfile.Write("(")
                        ElseIf (tempBig.ToString() = "75") Then
                            outputfile.Write(")")
                        ElseIf (tempBig.ToString() = "76") Then
                            outputfile.Write(":")
                        ElseIf (tempBig.ToString() = "77") Then
                            outputfile.Write("~")
                        ElseIf (tempBig.ToString() = "78") Then
                            outputfile.Write("`")
                        ElseIf (tempBig.ToString() = "79") Then
                            outputfile.Write("*")
                        ElseIf (tempBig.ToString() = "80") Then
                            outputfile.Write(vbTab)
                        End If
                    Catch ex As Exception

                    End Try

                Next
                currentchars.Clear()
                row1.Clear()
                row2.Clear()
                temrow.Clear()
                c.Clear()

            Next
            outputfile.Close()
            inputFile.Close()

        Catch ex As Exception
        End Try

        decryptionKey.Clear()

        Dim EncryptResponse = MsgBox("The file has been decrypted. Open file location?", MessageBoxButtons.YesNo)
        If EncryptResponse = MsgBoxResult.Yes Then
            Process.Start("C:\")
        End If

        decryptProgress.Value = 0
        lblNameDecrypt.Enabled = False
        lblNameDecrypt.Visible = False
        lblSizeDecrypt.Enabled = False
        lblSizeDecrypt.Visible = False
        lblPathDecrypt.Enabled = False
        lblPathDecrypt.Visible = False
        txtKeyDecrypt.Enabled = False
        txtKeyDecrypt.Text = ""
        btnDecrypt.Enabled = False


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
    Private Sub keyGenerationDecypt(ByVal keyvalue As Integer)
        Dim row1 As New ArrayList
        Dim row2 As New ArrayList
        Dim size As New Integer
        Dim negSize As New Integer
        size = FibonacciNumbers.Count - 1
        negSize = -1 * size
        'size =  fn+1
        'size-1 = fn
        'size-2 = fn-1
        If (keyvalue Mod 2 > 0) Then
            row1.Add(-1 * FibonacciNumbers(size - 2))
            row1.Add(FibonacciNumbers(size - 1))
            row2.Add(FibonacciNumbers(size - 1))
            row2.Add(-1 * FibonacciNumbers(size))
            decryptionKey.Add(row1)
            decryptionKey.Add(row2)
        Else
            row1.Add(FibonacciNumbers(size - 2))
            row1.Add(-1 * FibonacciNumbers(size - 1))
            row2.Add(-1 * FibonacciNumbers(size - 1))
            row2.Add(FibonacciNumbers(size))
            decryptionKey.Add(row1)
            decryptionKey.Add(row2)
        End If

    End Sub

    Private Sub matrixmulti(ByVal currentchars As ArrayList, ByRef c As ArrayList)
        Dim zerostring As String = "0"
        Dim row1 As New ArrayList
        Dim row2 As New ArrayList
        Dim value1 As BigInteger
        Dim value2 As BigInteger
        Dim sum As BigInteger
        Dim modularvalue As BigInteger
        modularvalue = BigInteger.Parse("81")

        c.Add(row1)
        C.Add(row2)

        For i As Integer = 1 To 2 Step 1
            For j As Integer = 1 To 1 Step 1
                sum = BigInteger.Parse(zerostring)
                For k As Integer = 1 To 2 Step 1
                    row1 = encrytionKey(i - 1)
                    value1 = row1(k - 1) Mod 81
                    row1 = currentchars(k - 1)
                    value2 = row1(j - 1) Mod 81
                    sum = sum + value1 * value2
                Next
                sum = sum Mod 81 ' will need to be increased if more characters are added
                row1 = C(i - 1)
                row1.Add(sum)
                C(i - 1) = row1
            Next
        Next

    End Sub
    Private Sub matrixmultiDecypt(ByVal currentchars As ArrayList, ByRef c As ArrayList)
        Dim zerostring As String = "0"
        Dim row1 As New ArrayList
        Dim row2 As New ArrayList
        Dim row3 As New ArrayList
        Dim value1 As BigInteger
        Dim value2 As BigInteger
        Dim sum As BigInteger
        Dim modularvalue As BigInteger
        modularvalue = BigInteger.Parse("81")

        c.Add(row1)
        c.Add(row2)

        For i As Integer = 1 To 2 Step 1
            For j As Integer = 1 To 1 Step 1
                sum = BigInteger.Parse(zerostring)
                For k As Integer = 1 To 2 Step 1
                    row1 = decryptionKey(i - 1)
                    value1 = row1(k - 1)
                    value1 = Modulus(value1, modularvalue)
                    row1 = currentchars(k - 1)
                    value2 = row1(j - 1) Mod 81
                    sum = sum + value1 * value2
                Next
                sum = sum Mod 81 ' will need to be increased if more characters are added
                row2 = c(i - 1)
                row2.Add(sum)
                c(i - 1) = row2
            Next
        Next

    End Sub
    Private Function Modulus(ByRef x As BigInteger, m As BigInteger)
        Dim r As BigInteger
        r = x Mod m
        If (r < 0) Then
            r = r + m
        ElseIf (r >= 0) Then
            r = r
        End If

        Return r
    End Function
End Class
