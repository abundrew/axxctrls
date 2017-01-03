<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ROTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtROTextBox = New System.Windows.Forms.TextBox
        Me.txtROTextBoxRO = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtROTextBox
        '
        Me.txtROTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtROTextBox.Location = New System.Drawing.Point(0, 0)
        Me.txtROTextBox.Name = "txtROTextBox"
        Me.txtROTextBox.Size = New System.Drawing.Size(100, 20)
        Me.txtROTextBox.TabIndex = 0
        '
        'txtROTextBoxRO
        '
        Me.txtROTextBoxRO.BackColor = System.Drawing.SystemColors.Info
        Me.txtROTextBoxRO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtROTextBoxRO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtROTextBoxRO.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtROTextBoxRO.Location = New System.Drawing.Point(0, 0)
        Me.txtROTextBoxRO.Name = "txtROTextBoxRO"
        Me.txtROTextBoxRO.ReadOnly = True
        Me.txtROTextBoxRO.Size = New System.Drawing.Size(100, 20)
        Me.txtROTextBoxRO.TabIndex = 0
        '
        'ROTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtROTextBox)
        Me.Controls.Add(Me.txtROTextBoxRO)
        Me.Name = "ROTextBox"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtROTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtROTextBoxRO As System.Windows.Forms.TextBox

End Class
