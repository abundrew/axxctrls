<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ROComboBox
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
        Me.cboROComboBox = New System.Windows.Forms.ComboBox
        Me.txtROComboBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cboROComboBox
        '
        Me.cboROComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboROComboBox.FormattingEnabled = True
        Me.cboROComboBox.Location = New System.Drawing.Point(0, 0)
        Me.cboROComboBox.Name = "cboROComboBox"
        Me.cboROComboBox.Size = New System.Drawing.Size(121, 21)
        Me.cboROComboBox.TabIndex = 0
        '
        'txtROComboBox
        '
        Me.txtROComboBox.BackColor = System.Drawing.SystemColors.Info
        Me.txtROComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtROComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtROComboBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtROComboBox.Location = New System.Drawing.Point(0, 0)
        Me.txtROComboBox.Name = "txtROComboBox"
        Me.txtROComboBox.ReadOnly = True
        Me.txtROComboBox.Size = New System.Drawing.Size(121, 20)
        Me.txtROComboBox.TabIndex = 0
        '
        'ROComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboROComboBox)
        Me.Controls.Add(Me.txtROComboBox)
        Me.Name = "ROComboBox"
        Me.Size = New System.Drawing.Size(121, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboROComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtROComboBox As System.Windows.Forms.TextBox

End Class
