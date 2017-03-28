<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RODateTimePicker
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
        Me.components = New System.ComponentModel.Container
        Me.dtpRODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.txtRODateTimePicker = New System.Windows.Forms.TextBox
        Me.ttRODateTimePicker = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'dtpRODateTimePicker
        '
        Me.dtpRODateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpRODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRODateTimePicker.Location = New System.Drawing.Point(0, 0)
        Me.dtpRODateTimePicker.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpRODateTimePicker.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtpRODateTimePicker.Name = "dtpRODateTimePicker"
        Me.dtpRODateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.dtpRODateTimePicker.TabIndex = 0
        '
        'txtRODateTimePicker
        '
        Me.txtRODateTimePicker.BackColor = System.Drawing.SystemColors.Info
        Me.txtRODateTimePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRODateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRODateTimePicker.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtRODateTimePicker.Location = New System.Drawing.Point(0, 0)
        Me.txtRODateTimePicker.Name = "txtRODateTimePicker"
        Me.txtRODateTimePicker.ReadOnly = True
        Me.txtRODateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.txtRODateTimePicker.TabIndex = 0
        '
        'RODateTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dtpRODateTimePicker)
        Me.Controls.Add(Me.txtRODateTimePicker)
        Me.Name = "RODateTimePicker"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpRODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRODateTimePicker As System.Windows.Forms.TextBox
    Friend WithEvents ttRODateTimePicker As System.Windows.Forms.ToolTip

End Class
