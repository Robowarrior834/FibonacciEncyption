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
        Me.lblDateMod = New System.Windows.Forms.Label()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblKeyNum = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblPath2 = New System.Windows.Forms.Label()
        Me.lblSize2 = New System.Windows.Forms.Label()
        Me.lblDateMod2 = New System.Windows.Forms.Label()
        Me.lblDateCreated2 = New System.Windows.Forms.Label()
        Me.lblOwner2 = New System.Windows.Forms.Label()
        Me.txtKeyNumber = New System.Windows.Forms.TextBox()
        Me.btnFileSelection = New System.Windows.Forms.Button()
        Me.btnEncyption = New System.Windows.Forms.Button()
        Me.btnDecyption = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(22, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(22, 66)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(38, 13)
        Me.lblPath.TabIndex = 1
        Me.lblPath.Text = "Path:  "
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(22, 92)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(33, 13)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "Size: "
        '
        'lblDateMod
        '
        Me.lblDateMod.AutoSize = True
        Me.lblDateMod.Location = New System.Drawing.Point(22, 119)
        Me.lblDateMod.Name = "lblDateMod"
        Me.lblDateMod.Size = New System.Drawing.Size(75, 13)
        Me.lblDateMod.TabIndex = 3
        Me.lblDateMod.Text = "Date modified:"
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.Location = New System.Drawing.Point(22, 140)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(73, 13)
        Me.lblDateCreated.TabIndex = 4
        Me.lblDateCreated.Text = "Date Created:"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(22, 164)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(41, 13)
        Me.lblOwner.TabIndex = 5
        Me.lblOwner.Text = "Owner:"
        '
        'lblKeyNum
        '
        Me.lblKeyNum.AutoSize = True
        Me.lblKeyNum.Location = New System.Drawing.Point(22, 186)
        Me.lblKeyNum.Name = "lblKeyNum"
        Me.lblKeyNum.Size = New System.Drawing.Size(65, 13)
        Me.lblKeyNum.TabIndex = 6
        Me.lblKeyNum.Text = "Key Number"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName2.Location = New System.Drawing.Point(213, 36)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(61, 15)
        Me.lblName2.TabIndex = 7
        Me.lblName2.Text = "Word_Doc"
        '
        'lblPath2
        '
        Me.lblPath2.AutoSize = True
        Me.lblPath2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPath2.Location = New System.Drawing.Point(213, 64)
        Me.lblPath2.Name = "lblPath2"
        Me.lblPath2.Size = New System.Drawing.Size(222, 15)
        Me.lblPath2.TabIndex = 8
        Me.lblPath2.Text = "C:\Users\student-19\Desktop\Word_Doc.txt"
        '
        'lblSize2
        '
        Me.lblSize2.AutoSize = True
        Me.lblSize2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSize2.Location = New System.Drawing.Point(213, 90)
        Me.lblSize2.Name = "lblSize2"
        Me.lblSize2.Size = New System.Drawing.Size(56, 15)
        Me.lblSize2.TabIndex = 9
        Me.lblSize2.Text = "570 Bytes"
        '
        'lblDateMod2
        '
        Me.lblDateMod2.AutoSize = True
        Me.lblDateMod2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateMod2.Location = New System.Drawing.Point(213, 119)
        Me.lblDateMod2.Name = "lblDateMod2"
        Me.lblDateMod2.Size = New System.Drawing.Size(99, 15)
        Me.lblDateMod2.TabIndex = 10
        Me.lblDateMod2.Text = "1/16/2016 1:16pm"
        '
        'lblDateCreated2
        '
        Me.lblDateCreated2.AutoSize = True
        Me.lblDateCreated2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateCreated2.Location = New System.Drawing.Point(213, 140)
        Me.lblDateCreated2.Name = "lblDateCreated2"
        Me.lblDateCreated2.Size = New System.Drawing.Size(99, 15)
        Me.lblDateCreated2.TabIndex = 11
        Me.lblDateCreated2.Text = "2/16/2016 2:16pm"
        '
        'lblOwner2
        '
        Me.lblOwner2.AutoSize = True
        Me.lblOwner2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOwner2.Location = New System.Drawing.Point(213, 164)
        Me.lblOwner2.Name = "lblOwner2"
        Me.lblOwner2.Size = New System.Drawing.Size(61, 15)
        Me.lblOwner2.TabIndex = 12
        Me.lblOwner2.Text = "Student-19"
        '
        'txtKeyNumber
        '
        Me.txtKeyNumber.Location = New System.Drawing.Point(213, 186)
        Me.txtKeyNumber.Name = "txtKeyNumber"
        Me.txtKeyNumber.Size = New System.Drawing.Size(120, 20)
        Me.txtKeyNumber.TabIndex = 13
        Me.txtKeyNumber.Text = "123456"
        '
        'btnFileSelection
        '
        Me.btnFileSelection.Location = New System.Drawing.Point(147, 225)
        Me.btnFileSelection.Name = "btnFileSelection"
        Me.btnFileSelection.Size = New System.Drawing.Size(164, 46)
        Me.btnFileSelection.TabIndex = 14
        Me.btnFileSelection.Text = "Select File"
        Me.btnFileSelection.UseVisualStyleBackColor = True
        '
        'btnEncyption
        '
        Me.btnEncyption.Location = New System.Drawing.Point(66, 277)
        Me.btnEncyption.Name = "btnEncyption"
        Me.btnEncyption.Size = New System.Drawing.Size(164, 46)
        Me.btnEncyption.TabIndex = 15
        Me.btnEncyption.Text = "Encyption"
        Me.btnEncyption.UseVisualStyleBackColor = True
        '
        'btnDecyption
        '
        Me.btnDecyption.Location = New System.Drawing.Point(236, 277)
        Me.btnDecyption.Name = "btnDecyption"
        Me.btnDecyption.Size = New System.Drawing.Size(164, 46)
        Me.btnDecyption.TabIndex = 17
        Me.btnDecyption.Text = "Decyption"
        Me.btnDecyption.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(467, 337)
        Me.Controls.Add(Me.btnDecyption)
        Me.Controls.Add(Me.btnEncyption)
        Me.Controls.Add(Me.btnFileSelection)
        Me.Controls.Add(Me.txtKeyNumber)
        Me.Controls.Add(Me.lblOwner2)
        Me.Controls.Add(Me.lblDateCreated2)
        Me.Controls.Add(Me.lblDateMod2)
        Me.Controls.Add(Me.lblSize2)
        Me.Controls.Add(Me.lblPath2)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblKeyNum)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.lblDateCreated)
        Me.Controls.Add(Me.lblDateMod)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Fibonacci Encyption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblDateMod As Label
    Friend WithEvents lblDateCreated As Label
    Friend WithEvents lblOwner As Label
    Friend WithEvents lblKeyNum As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents lblPath2 As Label
    Friend WithEvents lblSize2 As Label
    Friend WithEvents lblDateMod2 As Label
    Friend WithEvents lblDateCreated2 As Label
    Friend WithEvents lblOwner2 As Label
    Friend WithEvents txtKeyNumber As TextBox
    Friend WithEvents btnFileSelection As Button
    Friend WithEvents btnEncyption As Button
    Friend WithEvents btnDecyption As Button
End Class
