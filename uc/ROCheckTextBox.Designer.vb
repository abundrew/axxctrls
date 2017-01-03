<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ROCheckTextBox
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
        Me.panelROCheckTextBox = New System.Windows.Forms.Panel
        Me.txtROCheckTextBox = New axxctrls.ROTextBox
        Me.chkROCheckTextBox = New axxctrls.ROCheckBox
        Me.panelROCheckTextBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelROCheckTextBox
        '
        Me.panelROCheckTextBox.Controls.Add(Me.txtROCheckTextBox)
        Me.panelROCheckTextBox.Controls.Add(Me.chkROCheckTextBox)
        Me.panelROCheckTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelROCheckTextBox.Location = New System.Drawing.Point(0, 0)
        Me.panelROCheckTextBox.Name = "panelROCheckTextBox"
        Me.panelROCheckTextBox.Size = New System.Drawing.Size(150, 20)
        Me.panelROCheckTextBox.TabIndex = 0
        '
        'txtROCheckTextBox
        '
        Me.txtROCheckTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtROCheckTextBox.Enabled = False
        Me.txtROCheckTextBox.Location = New System.Drawing.Point(20, 0)
        Me.txtROCheckTextBox.Name = "txtROCheckTextBox"
        Me.txtROCheckTextBox.rotxtAcceptsReturn = False
        Me.txtROCheckTextBox.rotxtAcceptsTab = False
        Me.txtROCheckTextBox.rotxtFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROCheckTextBox.rotxtMaxLength = 32767
        Me.txtROCheckTextBox.rotxtMultiline = False
        Me.txtROCheckTextBox.rotxtScrollbars = System.Windows.Forms.ScrollBars.None
        Me.txtROCheckTextBox.rotxtWordWrap = True
        Me.txtROCheckTextBox.Size = New System.Drawing.Size(130, 20)
        Me.txtROCheckTextBox.TabIndex = 1
        '
        'chkROCheckTextBox
        '
        Me.chkROCheckTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkROCheckTextBox.Location = New System.Drawing.Point(0, 0)
        Me.chkROCheckTextBox.Name = "chkROCheckTextBox"
        Me.chkROCheckTextBox.rochkChecked = False
        Me.chkROCheckTextBox.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkROCheckTextBox.rochkText = ""
        Me.chkROCheckTextBox.Size = New System.Drawing.Size(20, 20)
        Me.chkROCheckTextBox.TabIndex = 0
        '
        'ROCheckTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelROCheckTextBox)
        Me.Name = "ROCheckTextBox"
        Me.Size = New System.Drawing.Size(150, 20)
        Me.panelROCheckTextBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelROCheckTextBox As System.Windows.Forms.Panel
    Friend WithEvents chkROCheckTextBox As axxctrls.ROCheckBox
    Friend WithEvents txtROCheckTextBox As axxctrls.ROTextBox

End Class
