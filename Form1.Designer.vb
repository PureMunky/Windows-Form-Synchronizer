<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.chkBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(12, 12)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(100, 20)
        Me.txtBox1.TabIndex = 0
        '
        'chkBox1
        '
        Me.chkBox1.AutoSize = True
        Me.chkBox1.Location = New System.Drawing.Point(12, 38)
        Me.chkBox1.Name = "chkBox1"
        Me.chkBox1.Size = New System.Drawing.Size(81, 17)
        Me.chkBox1.TabIndex = 1
        Me.chkBox1.Text = "CheckBox1"
        Me.chkBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 159)
        Me.Controls.Add(Me.chkBox1)
        Me.Controls.Add(Me.txtBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBox1 As System.Windows.Forms.TextBox
    Friend WithEvents chkBox1 As System.Windows.Forms.CheckBox
End Class
