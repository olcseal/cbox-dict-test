<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbHash = New System.Windows.Forms.ComboBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.cmbUrl = New System.Windows.Forms.ComboBox()
        Me.llblHistory = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'cmbHash
        '
        Me.cmbHash.FormattingEnabled = True
        Me.cmbHash.Location = New System.Drawing.Point(12, 81)
        Me.cmbHash.Name = "cmbHash"
        Me.cmbHash.Size = New System.Drawing.Size(225, 21)
        Me.cmbHash.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(243, 79)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'cmbUrl
        '
        Me.cmbUrl.FormattingEnabled = True
        Me.cmbUrl.Location = New System.Drawing.Point(12, 43)
        Me.cmbUrl.Name = "cmbUrl"
        Me.cmbUrl.Size = New System.Drawing.Size(225, 21)
        Me.cmbUrl.TabIndex = 2
        '
        'llblHistory
        '
        Me.llblHistory.AutoSize = True
        Me.llblHistory.Location = New System.Drawing.Point(200, 27)
        Me.llblHistory.Name = "llblHistory"
        Me.llblHistory.Size = New System.Drawing.Size(37, 13)
        Me.llblHistory.TabIndex = 3
        Me.llblHistory.TabStop = True
        Me.llblHistory.Text = "history"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 250)
        Me.Controls.Add(Me.llblHistory)
        Me.Controls.Add(Me.cmbUrl)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.cmbHash)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbHash As ComboBox
    Friend WithEvents btnGo As Button
    Friend WithEvents cmbUrl As ComboBox
    Friend WithEvents llblHistory As LinkLabel
End Class
