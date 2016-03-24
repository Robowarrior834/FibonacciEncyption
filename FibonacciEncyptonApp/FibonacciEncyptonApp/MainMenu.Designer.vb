<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblKeyNum = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblPath2 = New System.Windows.Forms.Label()
        Me.lblSize2 = New System.Windows.Forms.Label()
        Me.txtKeyNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopEncytionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEncypt = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeyDecrypt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSizeDecrypt = New System.Windows.Forms.Label()
        Me.lblPathDecrypt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNameDecrypt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenDecryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(6, 64)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(38, 13)
        Me.lblPath.TabIndex = 1
        Me.lblPath.Text = "Path:  "
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(6, 38)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(33, 13)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "Size: "
        '
        'lblKeyNum
        '
        Me.lblKeyNum.AutoSize = True
        Me.lblKeyNum.Location = New System.Drawing.Point(6, 88)
        Me.lblKeyNum.Name = "lblKeyNum"
        Me.lblKeyNum.Size = New System.Drawing.Size(65, 13)
        Me.lblKeyNum.TabIndex = 6
        Me.lblKeyNum.Text = "Key Number"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName2.Location = New System.Drawing.Point(88, 14)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(61, 15)
        Me.lblName2.TabIndex = 7
        Me.lblName2.Text = "Word_Doc"
        '
        'lblPath2
        '
        Me.lblPath2.AutoSize = True
        Me.lblPath2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPath2.Location = New System.Drawing.Point(88, 62)
        Me.lblPath2.Name = "lblPath2"
        Me.lblPath2.Size = New System.Drawing.Size(222, 15)
        Me.lblPath2.TabIndex = 8
        Me.lblPath2.Text = "C:\Users\student-19\Desktop\Word_Doc.txt"
        '
        'lblSize2
        '
        Me.lblSize2.AutoSize = True
        Me.lblSize2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSize2.Location = New System.Drawing.Point(88, 38)
        Me.lblSize2.Name = "lblSize2"
        Me.lblSize2.Size = New System.Drawing.Size(56, 15)
        Me.lblSize2.TabIndex = 9
        Me.lblSize2.Text = "570 Bytes"
        '
        'txtKeyNumber
        '
        Me.txtKeyNumber.Location = New System.Drawing.Point(88, 88)
        Me.txtKeyNumber.Name = "txtKeyNumber"
        Me.txtKeyNumber.Size = New System.Drawing.Size(109, 20)
        Me.txtKeyNumber.TabIndex = 13
        Me.txtKeyNumber.Text = "123456"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.btnEncypt)
        Me.GroupBox1.Controls.Add(Me.lblKeyNum)
        Me.GroupBox1.Controls.Add(Me.txtKeyNumber)
        Me.GroupBox1.Controls.Add(Me.lblPath)
        Me.GroupBox1.Controls.Add(Me.lblSize2)
        Me.GroupBox1.Controls.Add(Me.lblPath2)
        Me.GroupBox1.Controls.Add(Me.lblSize)
        Me.GroupBox1.Controls.Add(Me.lblName2)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 171)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encyption"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDecrypt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtKeyDecrypt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblSizeDecrypt)
        Me.GroupBox2.Controls.Add(Me.lblPathDecrypt)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblNameDecrypt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 156)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Decryption"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(467, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenDecryptToolStripMenuItem, Me.StopEncytionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open Encypt"
        '
        'StopEncytionToolStripMenuItem
        '
        Me.StopEncytionToolStripMenuItem.Name = "StopEncytionToolStripMenuItem"
        Me.StopEncytionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StopEncytionToolStripMenuItem.Text = "Stop Encytion"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ManualToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'btnEncypt
        '
        Me.btnEncypt.Location = New System.Drawing.Point(235, 86)
        Me.btnEncypt.Name = "btnEncypt"
        Me.btnEncypt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncypt.TabIndex = 14
        Me.btnEncypt.Text = "Encyption"
        Me.ToolTip1.SetToolTip(Me.btnEncypt, "Click this to encrypt the file.")
        Me.btnEncypt.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 142)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(428, 23)
        Me.ProgressBar1.TabIndex = 15
        Me.ProgressBar1.Value = 78
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(235, 86)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 23
        Me.btnDecrypt.Text = "Decrypt"
        Me.ToolTip1.SetToolTip(Me.btnDecrypt, "Click this to encrypt the file.")
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Key Number"
        '
        'txtKeyDecrypt
        '
        Me.txtKeyDecrypt.Location = New System.Drawing.Point(88, 88)
        Me.txtKeyDecrypt.Name = "txtKeyDecrypt"
        Me.txtKeyDecrypt.Size = New System.Drawing.Size(109, 20)
        Me.txtKeyDecrypt.TabIndex = 22
        Me.txtKeyDecrypt.Text = "123456"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Path:  "
        '
        'lblSizeDecrypt
        '
        Me.lblSizeDecrypt.AutoSize = True
        Me.lblSizeDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSizeDecrypt.Location = New System.Drawing.Point(88, 38)
        Me.lblSizeDecrypt.Name = "lblSizeDecrypt"
        Me.lblSizeDecrypt.Size = New System.Drawing.Size(56, 15)
        Me.lblSizeDecrypt.TabIndex = 21
        Me.lblSizeDecrypt.Text = "570 Bytes"
        '
        'lblPathDecrypt
        '
        Me.lblPathDecrypt.AutoSize = True
        Me.lblPathDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPathDecrypt.Location = New System.Drawing.Point(88, 62)
        Me.lblPathDecrypt.Name = "lblPathDecrypt"
        Me.lblPathDecrypt.Size = New System.Drawing.Size(222, 15)
        Me.lblPathDecrypt.TabIndex = 20
        Me.lblPathDecrypt.Text = "C:\Users\student-19\Desktop\Word_Doc.txt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Size: "
        '
        'lblNameDecrypt
        '
        Me.lblNameDecrypt.AutoSize = True
        Me.lblNameDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNameDecrypt.Location = New System.Drawing.Point(88, 14)
        Me.lblNameDecrypt.Name = "lblNameDecrypt"
        Me.lblNameDecrypt.Size = New System.Drawing.Size(61, 15)
        Me.lblNameDecrypt.TabIndex = 19
        Me.lblNameDecrypt.Text = "Word_Doc"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Name: "
        '
        'OpenDecryptToolStripMenuItem
        '
        Me.OpenDecryptToolStripMenuItem.Name = "OpenDecryptToolStripMenuItem"
        Me.OpenDecryptToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenDecryptToolStripMenuItem.Text = "Open Decrypt"
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(467, 459)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.Text = "Fibonacci Encyption"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblKeyNum As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents lblPath2 As Label
    Friend WithEvents lblSize2 As Label
    Friend WithEvents txtKeyNumber As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopEncytionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnEncypt As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeyDecrypt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSizeDecrypt As Label
    Friend WithEvents lblPathDecrypt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNameDecrypt As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenDecryptToolStripMenuItem As ToolStripMenuItem
End Class
