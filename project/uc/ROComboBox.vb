Public Class ROComboBox

    Private _isReadOnly As Boolean
    Private _defaultText As String = ""

    Public Event rocboDropDown()
    Public Event rocboSelectedValueChanged()
    Public Event rocboTextChanged()

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboDataSource() As Object
        Get
            Return cboROComboBox.DataSource
        End Get
        Set(ByVal value As Object)
            cboROComboBox.DataSource = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboDisplayMember() As String
        Get
            Return cboROComboBox.DisplayMember
        End Get
        Set(ByVal value As String)
            cboROComboBox.DisplayMember = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("The height, in pixels, of the drop-down box in a rocombobox.")> _
    Public Property rocboDropDownHeight() As Integer
        Get
            Return cboROComboBox.DropDownHeight
        End Get
        Set(ByVal value As Integer)
            cboROComboBox.DropDownHeight = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("Controls the appearance and functionality of the rocombobox.")> _
    Public Property rocboDropDownStyle() As System.Windows.Forms.ComboBoxStyle
        Get
            Return cboROComboBox.DropDownStyle
        End Get
        Set(ByVal value As System.Windows.Forms.ComboBoxStyle)
            cboROComboBox.DropDownStyle = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("The width, in pixels, of the drop-down box in a rocombobox.")> _
    Public Property rocboDropDownWidth() As Integer
        Get
            Return cboROComboBox.DropDownWidth
        End Get
        Set(ByVal value As Integer)
            cboROComboBox.DropDownWidth = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboDroppedDown() As Boolean
        Get
            Return cboROComboBox.DroppedDown
        End Get
        Set(ByVal value As Boolean)
            cboROComboBox.DroppedDown = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("The font used to display text in the rocombobox.")> _
    Public Property rocboFont() As System.Drawing.Font
        Get
            Return cboROComboBox.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            cboROComboBox.Font = value
            txtROComboBox.Font = value
            ROComboBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property rocboItems() As System.Windows.Forms.ComboBox.ObjectCollection
        Get
            Return cboROComboBox.Items
        End Get
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("The maximum number of entries to display in the drop-down list.")> _
    Public Property rocboMaxDropDownItems() As Integer
        Get
            Return cboROComboBox.MaxDropDownItems
        End Get
        Set(ByVal value As Integer)
            cboROComboBox.MaxDropDownItems = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("Specifies the maximum number of characters that can be entered into the rocombobox.")> _
    Public Property rocboMaxLength() As Integer
        Get
            Return cboROComboBox.MaxLength
        End Get
        Set(ByVal value As Integer)
            cboROComboBox.MaxLength = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rocombobox control can be changed or not.")> _
    Public Property rocboReadOnly() As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(ByVal value As Boolean)
            _isReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboSelectedIndex() As Integer
        Get
            Return cboROComboBox.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            cboROComboBox.SelectedIndex = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboSelectedItem() As Object
        Get
            Return cboROComboBox.SelectedItem
        End Get
        Set(ByVal value As Object)
            cboROComboBox.SelectedItem = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboSelectedValue() As Object
        Get
            Return cboROComboBox.SelectedValue
        End Get
        Set(ByVal value As Object)
            cboROComboBox.SelectedValue = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROComboBox")> _
    <System.ComponentModel.Description("Controls whether items in the list portion are sorted.")> _
    Public Property rocboSorted() As Boolean
        Get
            Return cboROComboBox.Sorted
        End Get
        Set(ByVal value As Boolean)
            cboROComboBox.Sorted = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboText() As String
        Get
            Return cboROComboBox.Text
        End Get
        Set(ByVal value As String)
            cboROComboBox.Text = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboValueMember() As String
        Get
            Return cboROComboBox.ValueMember
        End Get
        Set(ByVal value As String)
            cboROComboBox.ValueMember = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rocboDefaultText() As String
        Get
            Return _defaultText
        End Get
        Set(ByVal value As String)
            _defaultText = value
            ShowControl()
        End Set
    End Property

    Public Sub BeginUpdate()
        cboROComboBox.BeginUpdate()
    End Sub

    Public Sub EndUpdate()
        cboROComboBox.EndUpdate()
    End Sub

    Private Sub ShowControl()
        If _isReadOnly Then
            txtROComboBox.Visible = Me.Visible
            cboROComboBox.Visible = False
            txtROComboBox.Text = IIf(cboROComboBox.Text.Length > 0, cboROComboBox.Text, _defaultText)
        Else
            cboROComboBox.Visible = Me.Visible
            txtROComboBox.Visible = False
        End If
        ROComboBox_Resize(Nothing, Nothing)
    End Sub

#Region " Combo Box Find String "

    Private Sub cboROComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboROComboBox.KeyPress
        Static findString As String = String.Empty

        With cboROComboBox
            If Not _isReadOnly And .DropDownStyle = ComboBoxStyle.DropDownList Then
                If Not (Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar)) Then
                    findString = ""
                    Exit Sub
                End If
                findString &= e.KeyChar
                Dim index As Integer = .FindString(findString)
                If index >= 0 Then
                    .SelectedIndex = index
                Else
                    findString = ""
                End If
                e.Handled = True
            End If
        End With

    End Sub

#End Region

    Private Sub cboROComboBox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboROComboBox.DropDown
        RaiseEvent rocboDropDown()
    End Sub

    Private Sub cboROComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboROComboBox.SelectedValueChanged
        txtROComboBox.Text = IIf(cboROComboBox.Text.Length > 0, cboROComboBox.Text, _defaultText)
        RaiseEvent rocboSelectedValueChanged()
    End Sub

    Private Sub cboROComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboROComboBox.TextChanged
        RaiseEvent rocboTextChanged()
    End Sub

    Private Sub ROComboBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim height As Integer = System.Math.Max(cboROComboBox.Height, txtROComboBox.Height)
        If Me.Height <> height Then
            Me.Height = height
        End If
    End Sub

    Private Sub ROComboBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ShowControl()
    End Sub

End Class
