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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopEncytionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
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
        Me.txtKeyNumber.Size = New System.Drawing.Size(349, 20)
        Me.txtKeyNumber.TabIndex = 13
        Me.txtKeyNumber.Text = "123456"
        '
        'GroupBox1
        '
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 100)
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.StopEncytionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ManualToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
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
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
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
End Class
