<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ROCheckComboBox
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
        Me.panelROCheckComboBox = New System.Windows.Forms.Panel
        Me.cboROCheckComboBox = New axxctrls.ROComboBox
        Me.chkROCheckComboBox = New axxctrls.ROCheckBox
        Me.panelROCheckComboBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelROCheckComboBox
        '
        Me.panelROCheckComboBox.Controls.Add(Me.cboROCheckComboBox)
        Me.panelROCheckComboBox.Controls.Add(Me.chkROCheckComboBox)
        Me.panelROCheckComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelROCheckComboBox.Location = New System.Drawing.Point(0, 0)
        Me.panelROCheckComboBox.Name = "panelROCheckComboBox"
        Me.panelROCheckComboBox.Size = New System.Drawing.Size(150, 21)
        Me.panelROCheckComboBox.TabIndex = 0
        '
        'cboROCheckComboBox
        '
        Me.cboROCheckComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboROCheckComboBox.Enabled = False
        Me.cboROCheckComboBox.Location = New System.Drawing.Point(20, 0)
        Me.cboROCheckComboBox.Name = "cboROCheckComboBox"
        Me.cboROCheckComboBox.rocboDataSource = Nothing
        Me.cboROCheckComboBox.rocboDefaultText = ""
        Me.cboROCheckComboBox.rocboDisplayMember = ""
        Me.cboROCheckComboBox.rocboDropDownHeight = 106
        Me.cboROCheckComboBox.rocboDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboROCheckComboBox.rocboDropDownWidth = 130
        Me.cboROCheckComboBox.rocboDroppedDown = False
        Me.cboROCheckComboBox.rocboFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboROCheckComboBox.rocboMaxDropDownItems = 8
        Me.cboROCheckComboBox.rocboMaxLength = 0
        Me.cboROCheckComboBox.rocboSelectedIndex = -1
        Me.cboROCheckComboBox.rocboSelectedItem = Nothing
        Me.cboROCheckComboBox.rocboSelectedValue = Nothing
        Me.cboROCheckComboBox.rocboSorted = False
        Me.cboROCheckComboBox.rocboText = ""
        Me.cboROCheckComboBox.rocboValueMember = ""
        Me.cboROCheckComboBox.Size = New System.Drawing.Size(130, 21)
        Me.cboROCheckComboBox.TabIndex = 1
        '
        'chkROCheckComboBox
        '
        Me.chkROCheckComboBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkROCheckComboBox.Location = New System.Drawing.Point(0, 0)
        Me.chkROCheckComboBox.Name = "chkROCheckComboBox"
        Me.chkROCheckComboBox.rochkChecked = False
        Me.chkROCheckComboBox.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkROCheckComboBox.rochkText = ""
        Me.chkROCheckComboBox.Size = New System.Drawing.Size(20, 20)
        Me.chkROCheckComboBox.TabIndex = 0
        '
        'ROCheckComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelROCheckComboBox)
        Me.Name = "ROCheckComboBox"
        Me.Size = New System.Drawing.Size(150, 21)
        Me.panelROCheckComboBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelROCheckComboBox As System.Windows.Forms.Panel
    Friend WithEvents cboROCheckComboBox As axxctrls.ROComboBox
    Friend WithEvents chkROCheckComboBox As axxctrls.ROCheckBox

End Class
