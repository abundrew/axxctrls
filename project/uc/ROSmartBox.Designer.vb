<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROSmartBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.tlpMinMaxDate = New System.Windows.Forms.TableLayoutPanel
        Me.pictureMinBox = New System.Windows.Forms.PictureBox
        Me.pictureMaxBox = New System.Windows.Forms.PictureBox
        Me.rocboComboBox = New axxctrls.ROComboBox
        Me.rochkdtMinDate = New axxctrls.ROCheckDateTimePicker
        Me.rochkdtMaxDate = New axxctrls.ROCheckDateTimePicker
        Me.tlpMinMaxDate.SuspendLayout()
        CType(Me.pictureMinBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMaxBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpMinMaxDate
        '
        Me.tlpMinMaxDate.ColumnCount = 4
        Me.tlpMinMaxDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpMinMaxDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMinMaxDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpMinMaxDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMinMaxDate.Controls.Add(Me.rochkdtMinDate, 1, 0)
        Me.tlpMinMaxDate.Controls.Add(Me.pictureMinBox, 0, 0)
        Me.tlpMinMaxDate.Controls.Add(Me.rochkdtMaxDate, 3, 0)
        Me.tlpMinMaxDate.Controls.Add(Me.pictureMaxBox, 2, 0)
        Me.tlpMinMaxDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMinMaxDate.Location = New System.Drawing.Point(0, 0)
        Me.tlpMinMaxDate.Name = "tlpMinMaxDate"
        Me.tlpMinMaxDate.RowCount = 1
        Me.tlpMinMaxDate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMinMaxDate.Size = New System.Drawing.Size(211, 21)
        Me.tlpMinMaxDate.TabIndex = 0
        '
        'pictureMinBox
        '
        Me.pictureMinBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureMinBox.Location = New System.Drawing.Point(0, 2)
        Me.pictureMinBox.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.pictureMinBox.Name = "pictureMinBox"
        Me.pictureMinBox.Size = New System.Drawing.Size(16, 17)
        Me.pictureMinBox.TabIndex = 3
        Me.pictureMinBox.TabStop = False
        '
        'pictureMaxBox
        '
        Me.pictureMaxBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureMaxBox.Location = New System.Drawing.Point(105, 2)
        Me.pictureMaxBox.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.pictureMaxBox.Name = "pictureMaxBox"
        Me.pictureMaxBox.Size = New System.Drawing.Size(16, 17)
        Me.pictureMaxBox.TabIndex = 2
        Me.pictureMaxBox.TabStop = False
        '
        'rocboComboBox
        '
        Me.rocboComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rocboComboBox.Location = New System.Drawing.Point(0, 0)
        Me.rocboComboBox.Name = "rocboComboBox"
        Me.rocboComboBox.rocboDataSource = Nothing
        Me.rocboComboBox.rocboDefaultText = ""
        Me.rocboComboBox.rocboDisplayMember = ""
        Me.rocboComboBox.rocboDropDownHeight = 106
        Me.rocboComboBox.rocboDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.rocboComboBox.rocboDropDownWidth = 211
        Me.rocboComboBox.rocboDroppedDown = False
        Me.rocboComboBox.rocboFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rocboComboBox.rocboMaxDropDownItems = 8
        Me.rocboComboBox.rocboMaxLength = 0
        Me.rocboComboBox.rocboSelectedIndex = -1
        Me.rocboComboBox.rocboSelectedItem = Nothing
        Me.rocboComboBox.rocboSelectedValue = Nothing
        Me.rocboComboBox.rocboSorted = False
        Me.rocboComboBox.rocboText = ""
        Me.rocboComboBox.rocboValueMember = ""
        Me.rocboComboBox.Size = New System.Drawing.Size(211, 21)
        Me.rocboComboBox.TabIndex = 0
        '
        'rochkdtMinDate
        '
        Me.rochkdtMinDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rochkdtMinDate.Location = New System.Drawing.Point(16, 0)
        Me.rochkdtMinDate.Margin = New System.Windows.Forms.Padding(0)
        Me.rochkdtMinDate.Name = "rochkdtMinDate"
        Me.rochkdtMinDate.rochkdtpChecked = True
        Me.rochkdtMinDate.rochkdtpCustomFormat = Nothing
        Me.rochkdtMinDate.rochkdtpFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkdtMinDate.rochkdtpFormat = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rochkdtMinDate.rochkdtpMandatory = False
        Me.rochkdtMinDate.rochkdtpMaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.rochkdtMinDate.rochkdtpMinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.rochkdtMinDate.rochkdtpValue = New Date(2006, 3, 18, 0, 0, 0, 0)
        Me.rochkdtMinDate.Size = New System.Drawing.Size(89, 20)
        Me.rochkdtMinDate.TabIndex = 0
        '
        'rochkdtMaxDate
        '
        Me.rochkdtMaxDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rochkdtMaxDate.Location = New System.Drawing.Point(121, 0)
        Me.rochkdtMaxDate.Margin = New System.Windows.Forms.Padding(0)
        Me.rochkdtMaxDate.Name = "rochkdtMaxDate"
        Me.rochkdtMaxDate.rochkdtpChecked = True
        Me.rochkdtMaxDate.rochkdtpCustomFormat = Nothing
        Me.rochkdtMaxDate.rochkdtpFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rochkdtMaxDate.rochkdtpFormat = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rochkdtMaxDate.rochkdtpMandatory = False
        Me.rochkdtMaxDate.rochkdtpMaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.rochkdtMaxDate.rochkdtpMinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.rochkdtMaxDate.rochkdtpValue = New Date(2006, 3, 18, 0, 0, 0, 0)
        Me.rochkdtMaxDate.Size = New System.Drawing.Size(90, 20)
        Me.rochkdtMaxDate.TabIndex = 1
        '
        'ROSmartBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rocboComboBox)
        Me.Controls.Add(Me.tlpMinMaxDate)
        Me.Name = "ROSmartBox"
        Me.Size = New System.Drawing.Size(211, 21)
        Me.tlpMinMaxDate.ResumeLayout(False)
        CType(Me.pictureMinBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMaxBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rocboComboBox As axxctrls.ROComboBox
    Friend WithEvents tlpMinMaxDate As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rochkdtMinDate As axxctrls.ROCheckDateTimePicker
    Friend WithEvents rochkdtMaxDate As axxctrls.ROCheckDateTimePicker
    Friend WithEvents pictureMaxBox As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinBox As System.Windows.Forms.PictureBox

End Class
