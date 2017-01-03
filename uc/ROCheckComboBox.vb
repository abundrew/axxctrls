Public Class ROCheckComboBox

    Public Event rochkcboCheckedChanged()
    Public Event rochkcboSelectedValueChanged()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("Indicated whether rocheckcombobox is selected or cleared.")> _
    Public Property rochkcboChecked() As Boolean
        Get
            Return chkROCheckComboBox.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            chkROCheckComboBox.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboDataSource() As Object
        Get
            Return cboROCheckComboBox.rocboDataSource
        End Get
        Set(ByVal value As Object)
            cboROCheckComboBox.rocboDataSource = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboDisplayMember() As String
        Get
            Return cboROCheckComboBox.rocboDisplayMember
        End Get
        Set(ByVal value As String)
            cboROCheckComboBox.rocboDisplayMember = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("The height, in pixels, of the drop-down box in a rocheckcombobox.")> _
    Public Property rochkcboDropDownHeight() As Integer
        Get
            Return cboROCheckComboBox.rocboDropDownHeight
        End Get
        Set(ByVal value As Integer)
            cboROCheckComboBox.rocboDropDownHeight = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("Controls the appearance and functionality of the rocheckcombobox.")> _
    Public Property rochkcboDropDownStyle() As System.Windows.Forms.ComboBoxStyle
        Get
            Return cboROCheckComboBox.rocboDropDownStyle
        End Get
        Set(ByVal value As System.Windows.Forms.ComboBoxStyle)
            cboROCheckComboBox.rocboDropDownStyle = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("The width, in pixels, of the drop-down box in a rocheckcombobox.")> _
    Public Property rochkcboDropDownWidth() As Integer
        Get
            Return cboROCheckComboBox.rocboDropDownWidth
        End Get
        Set(ByVal value As Integer)
            cboROCheckComboBox.rocboDropDownWidth = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboDroppedDown() As Boolean
        Get
            Return cboROCheckComboBox.rocboDroppedDown
        End Get
        Set(ByVal value As Boolean)
            cboROCheckComboBox.rocboDroppedDown = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("The font used to display text in the rocheckcombobox.")> _
    Public Property rochkcboFont() As System.Drawing.Font
        Get
            Return cboROCheckComboBox.rocboFont
        End Get
        Set(ByVal value As System.Drawing.Font)
            chkROCheckComboBox.rochkFont = value
            cboROCheckComboBox.rocboFont = value
            ROCheckComboBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property rochkcboItems() As System.Windows.Forms.ComboBox.ObjectCollection
        Get
            Return cboROCheckComboBox.rocboItems
        End Get
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("The maximum number of entries to display in the drop-down list.")> _
    Public Property rochkcboMaxDropDownItems() As Integer
        Get
            Return cboROCheckComboBox.rocboMaxDropDownItems
        End Get
        Set(ByVal value As Integer)
            cboROCheckComboBox.rocboMaxDropDownItems = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("Specifies the maximum number of characters that can be entered into the rocheckcombobox.")> _
    Public Property rochkcboMaxLength() As Integer
        Get
            Return cboROCheckComboBox.rocboMaxLength
        End Get
        Set(ByVal value As Integer)
            cboROCheckComboBox.rocboMaxLength = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rocheckcombobox can be changed or not.")> _
    Public Property rochkcboReadOnly() As Boolean
        Get
            Return chkROCheckComboBox.rochkReadOnly
        End Get
        Set(ByVal value As Boolean)
            chkROCheckComboBox.rochkReadOnly = value
            cboROCheckComboBox.rocboReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboSelectedIndex() As Integer
        Get
            Return cboROCheckComboBox.rocboSelectedIndex
        End Get
        Set(ByVal value As Integer)
            cboROCheckComboBox.rocboSelectedIndex = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboSelectedItem() As Object
        Get
            Return cboROCheckComboBox.rocboSelectedItem
        End Get
        Set(ByVal value As Object)
            cboROCheckComboBox.rocboSelectedItem = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboSelectedValue() As Object
        Get
            If rochkcboChecked Then
                Return cboROCheckComboBox.rocboSelectedValue
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Object)
            rochkcboChecked = Not IsNothing(value)
            If rochkcboChecked Then
                cboROCheckComboBox.rocboSelectedValue = value
            End If
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckComboBox")> _
    <System.ComponentModel.Description("Controls whether items in the list portion are sorted.")> _
    Public Property rochkcboSorted() As Boolean
        Get
            Return cboROCheckComboBox.rocboSorted
        End Get
        Set(ByVal value As Boolean)
            cboROCheckComboBox.rocboSorted = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboText() As String
        Get
            Return cboROCheckComboBox.rocboText
        End Get
        Set(ByVal value As String)
            cboROCheckComboBox.rocboText = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkcboValueMember() As String
        Get
            Return cboROCheckComboBox.rocboValueMember
        End Get
        Set(ByVal value As String)
            cboROCheckComboBox.rocboValueMember = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
   Public Property rochkcboDefaultText() As String
        Get
            Return cboROCheckComboBox.rocboDefaultText
        End Get
        Set(ByVal value As String)
            cboROCheckComboBox.rocboDefaultText = value
            ShowControl()
        End Set
    End Property

    Public Sub BeginUpdate()
        cboROCheckComboBox.BeginUpdate()
    End Sub

    Public Sub EndUpdate()
        cboROCheckComboBox.EndUpdate()
    End Sub

    Private Sub ShowControl()
        panelROCheckComboBox.Visible = Me.Visible
        cboROCheckComboBox.Enabled = rochkcboReadOnly OrElse chkROCheckComboBox.rochkChecked
        If rochkcboReadOnly And Not chkROCheckComboBox.rochkChecked Then
            If cboROCheckComboBox.rocboDropDownStyle <> ComboBoxStyle.DropDownList Then
                cboROCheckComboBox.rocboText = ""
            Else
                cboROCheckComboBox.rocboSelectedIndex = -1
            End If
        End If
        ROCheckComboBox_Resize(Nothing, Nothing)
    End Sub

    Private Sub chkROCheckComboBox_rochkCheckedChanged() Handles chkROCheckComboBox.rochkCheckedChanged
        ShowControl()
        RaiseEvent rochkcboCheckedChanged()
    End Sub

    Private Sub cboROCheckComboBox_rocboSelectedValueChanged() Handles cboROCheckComboBox.rocboSelectedValueChanged
        RaiseEvent rochkcboSelectedValueChanged()
    End Sub

    Private Sub ROCheckComboBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height <> cboROCheckComboBox.Height Then
            Me.Height = cboROCheckComboBox.Height
        End If
    End Sub

    Private Sub ROCheckComboBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        'panelROCheckComboBox.Visible = Me.Visible
        'cboROCheckComboBox.Enabled = rochkcboReadOnly OrElse chkROCheckComboBox.rochkChecked
        ShowControl()
    End Sub

End Class
