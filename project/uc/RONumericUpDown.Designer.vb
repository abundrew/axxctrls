<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RONumericUpDown
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
        Me.nudRONumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.txtRONumericUpDown = New System.Windows.Forms.TextBox
        CType(Me.nudRONumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudRONumericUpDown
        '
        Me.nudRONumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudRONumericUpDown.Location = New System.Drawing.Point(0, 0)
        Me.nudRONumericUpDown.Name = "nudRONumericUpDown"
        Me.nudRONumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.nudRONumericUpDown.TabIndex = 0
        '
        'txtRONumericUpDown
        '
        Me.txtRONumericUpDown.BackColor = System.Drawing.SystemColors.Info
        Me.txtRONumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRONumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRONumericUpDown.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtRONumericUpDown.Location = New System.Drawing.Point(0, 0)
        Me.txtRONumericUpDown.Name = "txtRONumericUpDown"
        Me.txtRONumericUpDown.ReadOnly = True
        Me.txtRONumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.txtRONumericUpDown.TabIndex = 0
        '
        'RONumericUpDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.nudRONumericUpDown)
        Me.Controls.Add(Me.txtRONumericUpDown)
        Me.Name = "RONumericUpDown"
        Me.Size = New System.Drawing.Size(100, 20)
        CType(Me.nudRONumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudRONumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtRONumericUpDown As System.Windows.Forms.TextBox

End Class
