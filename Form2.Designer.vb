<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.chkBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(12, 12)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(100, 20)
        Me.txtBox2.TabIndex = 0
        '
        'chkBox2
        '
        Me.chkBox2.AutoSize = True
        Me.chkBox2.Location = New System.Drawing.Point(12, 38)
        Me.chkBox2.Name = "chkBox2"
        Me.chkBox2.Size = New System.Drawing.Size(81, 17)
        Me.chkBox2.TabIndex = 1
        Me.chkBox2.Text = "CheckBox2"
        Me.chkBox2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 161)
        Me.Controls.Add(Me.chkBox2)
        Me.Controls.Add(Me.txtBox2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBox2 As System.Windows.Forms.TextBox
    Friend WithEvents chkBox2 As System.Windows.Forms.CheckBox
End Class
