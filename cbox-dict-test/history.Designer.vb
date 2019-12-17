<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history
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
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstHistory
        '
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.Location = New System.Drawing.Point(12, 24)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(387, 160)
        Me.lstHistory.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Double-Click to select a previously used server/api token pair."
        '
        'history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstHistory)
        Me.Name = "history"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "history"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstHistory As ListBox
    Friend WithEvents Label1 As Label
End Class
