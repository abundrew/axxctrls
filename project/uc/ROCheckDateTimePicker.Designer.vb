<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ROCheckDateTimePicker
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
        Me.panelROCheckDateTimePicker = New System.Windows.Forms.Panel
        Me.dtpROCheckDateTimePicker = New axxctrls.RODateTimePicker
        Me.chkROCheckDateTimePicker = New axxctrls.ROCheckBox
        Me.panelROCheckDateTimePicker.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelROCheckDateTimePicker
        '
        Me.panelROCheckDateTimePicker.Controls.Add(Me.dtpROCheckDateTimePicker)
        Me.panelROCheckDateTimePicker.Controls.Add(Me.chkROCheckDateTimePicker)
        Me.panelROCheckDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelROCheckDateTimePicker.Location = New System.Drawing.Point(0, 0)
        Me.panelROCheckDateTimePicker.Name = "panelROCheckDateTimePicker"
        Me.panelROCheckDateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.panelROCheckDateTimePicker.TabIndex = 0
        '
        'dtpROCheckDateTimePicker
        '
        Me.dtpROCheckDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtpROCheckDateTimePicker.Enabled = False
        Me.dtpROCheckDateTimePicker.Location = New System.Drawing.Point(20, 0)
        Me.dtpROCheckDateTimePicker.Name = "dtpROCheckDateTimePicker"
        Me.dtpROCheckDateTimePicker.rodtpCustomFormat = Nothing
        Me.dtpROCheckDateTimePicker.rodtpFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpROCheckDateTimePicker.rodtpFormat = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpROCheckDateTimePicker.rodtpMaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpROCheckDateTimePicker.rodtpMinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtpROCheckDateTimePicker.rodtpValue = New Date(2005, 7, 19, 22, 39, 49, 312)
        Me.dtpROCheckDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.dtpROCheckDateTimePicker.TabIndex = 1
        '
        'chkROCheckDateTimePicker
        '
        Me.chkROCheckDateTimePicker.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkROCheckDateTimePicker.Location = New System.Drawing.Point(0, 0)
        Me.chkROCheckDateTimePicker.Name = "chkROCheckDateTimePicker"
        Me.chkROCheckDateTimePicker.rochkChecked = False
        Me.chkROCheckDateTimePicker.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkROCheckDateTimePicker.rochkText = ""
        Me.chkROCheckDateTimePicker.Size = New System.Drawing.Size(20, 20)
        Me.chkROCheckDateTimePicker.TabIndex = 0
        '
        'ROCheckDateTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelROCheckDateTimePicker)
        Me.Name = "ROCheckDateTimePicker"
        Me.Size = New System.Drawing.Size(120, 20)
        Me.panelROCheckDateTimePicker.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelROCheckDateTimePicker As System.Windows.Forms.Panel
    Friend WithEvents chkROCheckDateTimePicker As axxctrls.ROCheckBox
    Friend WithEvents dtpROCheckDateTimePicker As axxctrls.RODateTimePicker

End Class
