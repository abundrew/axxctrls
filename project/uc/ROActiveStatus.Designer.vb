<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ROActiveStatus
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
        Me.grpROActiveStatus = New System.Windows.Forms.GroupBox
        Me.tlpROActiveStatus = New System.Windows.Forms.TableLayoutPanel
        Me.rochkActive = New axxctrls.ROCheckBox
        Me.rochkLent = New axxctrls.ROCheckBox
        Me.rochkInactive = New axxctrls.ROCheckBox
        Me.rochkCalibration = New axxctrls.ROCheckBox
        Me.rochkService = New axxctrls.ROCheckBox
        Me.rochkStorage = New axxctrls.ROCheckBox
        Me.rochkMissing = New axxctrls.ROCheckBox
        Me.rochkScrapped = New axxctrls.ROCheckBox
        Me.grpROActiveStatus.SuspendLayout()
        Me.tlpROActiveStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpROActiveStatus
        '
        Me.grpROActiveStatus.Controls.Add(Me.tlpROActiveStatus)
        Me.grpROActiveStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpROActiveStatus.Location = New System.Drawing.Point(0, 0)
        Me.grpROActiveStatus.Name = "grpROActiveStatus"
        Me.grpROActiveStatus.Size = New System.Drawing.Size(300, 111)
        Me.grpROActiveStatus.TabIndex = 0
        Me.grpROActiveStatus.TabStop = False
        Me.grpROActiveStatus.Text = "(active status)"
        '
        'tlpROActiveStatus
        '
        Me.tlpROActiveStatus.ColumnCount = 2
        Me.tlpROActiveStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpROActiveStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpROActiveStatus.Controls.Add(Me.rochkActive, 0, 0)
        Me.tlpROActiveStatus.Controls.Add(Me.rochkLent, 1, 0)
        Me.tlpROActiveStatus.Controls.Add(Me.rochkInactive, 0, 1)
        Me.tlpROActiveStatus.Controls.Add(Me.rochkCalibration, 0, 2)
        Me.tlpROActiveStatus.Controls.Add(Me.rochkService, 0, 3)
        Me.tlpROActiveStatus.Controls.Add(Me.rochkStorage, 1, 1)
        Me.tlpROActiveStatus.Controls.Add(Me.rochkMissing, 1, 2)
        Me.tlpROActiveStatus.Controls.Add(Me.rochkScrapped, 1, 3)
        Me.tlpROActiveStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpROActiveStatus.Location = New System.Drawing.Point(3, 16)
        Me.tlpROActiveStatus.Name = "tlpROActiveStatus"
        Me.tlpROActiveStatus.RowCount = 4
        Me.tlpROActiveStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpROActiveStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpROActiveStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpROActiveStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpROActiveStatus.Size = New System.Drawing.Size(294, 92)
        Me.tlpROActiveStatus.TabIndex = 0
        '
        'rochkActive
        '
        Me.rochkActive.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkActive.Location = New System.Drawing.Point(3, 3)
        Me.rochkActive.Name = "rochkActive"
        Me.rochkActive.rochkChecked = False
        Me.rochkActive.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkActive.rochkText = "(active)"
        Me.rochkActive.Size = New System.Drawing.Size(141, 20)
        Me.rochkActive.TabIndex = 0
        '
        'rochkLent
        '
        Me.rochkLent.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkLent.Location = New System.Drawing.Point(150, 3)
        Me.rochkLent.Name = "rochkLent"
        Me.rochkLent.rochkChecked = False
        Me.rochkLent.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkLent.rochkText = "(lent)"
        Me.rochkLent.Size = New System.Drawing.Size(141, 20)
        Me.rochkLent.TabIndex = 4
        '
        'rochkInactive
        '
        Me.rochkInactive.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkInactive.Location = New System.Drawing.Point(3, 26)
        Me.rochkInactive.Name = "rochkInactive"
        Me.rochkInactive.rochkChecked = False
        Me.rochkInactive.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkInactive.rochkText = "(inactive)"
        Me.rochkInactive.Size = New System.Drawing.Size(141, 20)
        Me.rochkInactive.TabIndex = 1
        '
        'rochkCalibration
        '
        Me.rochkCalibration.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkCalibration.Location = New System.Drawing.Point(3, 49)
        Me.rochkCalibration.Name = "rochkCalibration"
        Me.rochkCalibration.rochkChecked = False
        Me.rochkCalibration.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkCalibration.rochkText = "(calibration)"
        Me.rochkCalibration.Size = New System.Drawing.Size(141, 20)
        Me.rochkCalibration.TabIndex = 2
        '
        'rochkService
        '
        Me.rochkService.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkService.Location = New System.Drawing.Point(3, 72)
        Me.rochkService.Name = "rochkService"
        Me.rochkService.rochkChecked = False
        Me.rochkService.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkService.rochkText = "(service)"
        Me.rochkService.Size = New System.Drawing.Size(141, 20)
        Me.rochkService.TabIndex = 3
        '
        'rochkStorage
        '
        Me.rochkStorage.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkStorage.Location = New System.Drawing.Point(150, 26)
        Me.rochkStorage.Name = "rochkStorage"
        Me.rochkStorage.rochkChecked = False
        Me.rochkStorage.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkStorage.rochkText = "(storage)"
        Me.rochkStorage.Size = New System.Drawing.Size(141, 20)
        Me.rochkStorage.TabIndex = 5
        '
        'rochkMissing
        '
        Me.rochkMissing.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkMissing.Location = New System.Drawing.Point(150, 49)
        Me.rochkMissing.Name = "rochkMissing"
        Me.rochkMissing.rochkChecked = False
        Me.rochkMissing.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkMissing.rochkText = "(missing)"
        Me.rochkMissing.Size = New System.Drawing.Size(141, 20)
        Me.rochkMissing.TabIndex = 6
        '
        'rochkScrapped
        '
        Me.rochkScrapped.Dock = System.Windows.Forms.DockStyle.Top
        Me.rochkScrapped.Location = New System.Drawing.Point(150, 72)
        Me.rochkScrapped.Name = "rochkScrapped"
        Me.rochkScrapped.rochkChecked = False
        Me.rochkScrapped.rochkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkScrapped.rochkText = "(scrapped)"
        Me.rochkScrapped.Size = New System.Drawing.Size(141, 20)
        Me.rochkScrapped.TabIndex = 7
        '
        'ROActiveStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpROActiveStatus)
        Me.Name = "ROActiveStatus"
        Me.Size = New System.Drawing.Size(300, 111)
        Me.grpROActiveStatus.ResumeLayout(False)
        Me.tlpROActiveStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpROActiveStatus As System.Windows.Forms.GroupBox
    Friend WithEvents tlpROActiveStatus As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rochkActive As axxctrls.ROCheckBox
    Friend WithEvents rochkLent As axxctrls.ROCheckBox
    Friend WithEvents rochkInactive As axxctrls.ROCheckBox
    Friend WithEvents rochkCalibration As axxctrls.ROCheckBox
    Friend WithEvents rochkService As axxctrls.ROCheckBox
    Friend WithEvents rochkStorage As axxctrls.ROCheckBox
    Friend WithEvents rochkMissing As axxctrls.ROCheckBox
    Friend WithEvents rochkScrapped As axxctrls.ROCheckBox

End Class
