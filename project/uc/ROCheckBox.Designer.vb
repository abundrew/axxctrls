<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ROCheckBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ROCheckBox))
        Me.chkROCheckBox = New System.Windows.Forms.CheckBox
        Me.panelROCheckBox = New System.Windows.Forms.Panel
        Me.lblROCheckBoxText = New System.Windows.Forms.Label
        Me.lblROCheckBox = New System.Windows.Forms.Label
        Me.ilsROCheckBox = New System.Windows.Forms.ImageList(Me.components)
        Me.panelROCheckBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkROCheckBox
        '
        Me.chkROCheckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkROCheckBox.Location = New System.Drawing.Point(0, 0)
        Me.chkROCheckBox.Name = "chkROCheckBox"
        Me.chkROCheckBox.Size = New System.Drawing.Size(150, 20)
        Me.chkROCheckBox.TabIndex = 0
        Me.chkROCheckBox.Text = "ROCheckBox"
        '
        'panelROCheckBox
        '
        Me.panelROCheckBox.Controls.Add(Me.lblROCheckBoxText)
        Me.panelROCheckBox.Controls.Add(Me.lblROCheckBox)
        Me.panelROCheckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelROCheckBox.Location = New System.Drawing.Point(0, 0)
        Me.panelROCheckBox.Name = "panelROCheckBox"
        Me.panelROCheckBox.Size = New System.Drawing.Size(150, 20)
        Me.panelROCheckBox.TabIndex = 0
        '
        'lblROCheckBoxText
        '
        Me.lblROCheckBoxText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblROCheckBoxText.Location = New System.Drawing.Point(20, 0)
        Me.lblROCheckBoxText.Name = "lblROCheckBoxText"
        Me.lblROCheckBoxText.Size = New System.Drawing.Size(130, 20)
        Me.lblROCheckBoxText.TabIndex = 0
        Me.lblROCheckBoxText.Text = "ROCheckBox"
        Me.lblROCheckBoxText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblROCheckBox
        '
        Me.lblROCheckBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblROCheckBox.ImageKey = "checkbox"
        Me.lblROCheckBox.ImageList = Me.ilsROCheckBox
        Me.lblROCheckBox.Location = New System.Drawing.Point(0, 0)
        Me.lblROCheckBox.Name = "lblROCheckBox"
        Me.lblROCheckBox.Size = New System.Drawing.Size(20, 20)
        Me.lblROCheckBox.TabIndex = 0
        '
        'ilsROCheckBox
        '
        Me.ilsROCheckBox.ImageStream = CType(resources.GetObject("ilsROCheckBox.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsROCheckBox.Images.SetKeyName(0, "checkbox")
        Me.ilsROCheckBox.Images.SetKeyName(1, "checkmark")
        '
        'ROCheckBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkROCheckBox)
        Me.Controls.Add(Me.panelROCheckBox)
        Me.Name = "ROCheckBox"
        Me.Size = New System.Drawing.Size(150, 20)
        Me.panelROCheckBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkROCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents panelROCheckBox As System.Windows.Forms.Panel
    Friend WithEvents lblROCheckBox As System.Windows.Forms.Label
    Friend WithEvents ilsROCheckBox As System.Windows.Forms.ImageList
    Friend WithEvents lblROCheckBoxText As System.Windows.Forms.Label

End Class
