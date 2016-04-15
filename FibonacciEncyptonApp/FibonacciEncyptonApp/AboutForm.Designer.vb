<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Me.txtbxAbout = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtbxAbout
        '
        Me.txtbxAbout.Location = New System.Drawing.Point(12, 12)
        Me.txtbxAbout.Name = "txtbxAbout"
        Me.txtbxAbout.Size = New System.Drawing.Size(597, 500)
        Me.txtbxAbout.TabIndex = 0
        Me.txtbxAbout.Text = "wbvciuqeovbqewaiorvcbqealqscndkjhfruielwhsvcfkjdsahjfhdskjhfakljhsfdksa"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 524)
        Me.Controls.Add(Me.txtbxAbout)
        Me.Name = "AboutForm"
        Me.Text = "About Fibonacci Encyption"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtbxAbout As RichTextBox
End Class
