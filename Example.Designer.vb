<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Example
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
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLaunch
        '
        Me.btnLaunch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLaunch.Location = New System.Drawing.Point(0, 0)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(386, 157)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "Button1"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'Example
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 157)
        Me.Controls.Add(Me.btnLaunch)
        Me.Name = "Example"
        Me.Text = "Awesome Synchronizer Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLaunch As System.Windows.Forms.Button

End Class
