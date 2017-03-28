Public Class ROSmartBox

    Public Sub New()
        InitializeComponent()
        pictureMinBox.Image = My.Resources.icoGe.ToBitmap
        pictureMaxBox.Image = My.Resources.icoLe.ToBitmap
    End Sub

    Public Enum enumSmartBoxType
        sbtComboBox = 0
        sbtMinMaxDate = 1
    End Enum

    Private _smartBoxType As enumSmartBoxType = enumSmartBoxType.sbtComboBox

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("rosbSmartBoxType")> _
    <System.ComponentModel.Description("SmartBox Type: ComboBox or MinMaxDate .")> _
    Public Property rosbSmartBoxType() As enumSmartBoxType
        Get
            Return _smartBoxType
        End Get
        Set(ByVal value As enumSmartBoxType)
            _smartBoxType = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The font used to display text in the rosmartbox.")> _
    Public Property rosbFont() As System.Drawing.Font
        Get
            Return rocboComboBox.rocboFont
        End Get
        Set(ByVal value As System.Drawing.Font)
            rocboComboBox.rocboFont = value
            rochkdtMinDate.Font = value
            rochkdtMaxDate.Font = value
            ROSmartBox_Resize(Nothing, Nothing)
        End Set
    End Property

#Region " rocboComboBox "

    Public Event rosbcboSelectedValueChanged()
    Public Event rosbcboTextChanged()

    <System.ComponentModel.Browsable(False)> _
     Public Property rosbcboDataSource() As Object
        Get
            Return rocboComboBox.rocboDataSource
        End Get
        Set(ByVal value As Object)
            rocboComboBox.rocboDataSource = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboDisplayMember() As String
        Get
            Return rocboComboBox.rocboDisplayMember
        End Get
        Set(ByVal value As String)
            rocboComboBox.rocboDisplayMember = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The height, in pixels, of the drop-down box in a rosbcombobox.")> _
    Public Property rosbcboDropDownHeight() As Integer
        Get
            Return rocboComboBox.rocboDropDownHeight
        End Get
        Set(ByVal value As Integer)
            rocboComboBox.rocboDropDownHeight = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Controls the appearance and functionality of the rosbcombobox.")> _
    Public Property rosbcboDropDownStyle() As System.Windows.Forms.ComboBoxStyle
        Get
            Return rocboComboBox.rocboDropDownStyle
        End Get
        Set(ByVal value As System.Windows.Forms.ComboBoxStyle)
            rocboComboBox.rocboDropDownStyle = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The width, in pixels, of the drop-down box in a rosbcombobox.")> _
    Public Property rosbcboDropDownWidth() As Integer
        Get
            Return rocboComboBox.rocboDropDownWidth
        End Get
        Set(ByVal value As Integer)
            rocboComboBox.rocboDropDownWidth = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboDroppedDown() As Boolean
        Get
            Return rocboComboBox.rocboDroppedDown
        End Get
        Set(ByVal value As Boolean)
            rocboComboBox.rocboDroppedDown = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property rosbcboItems() As System.Windows.Forms.ComboBox.ObjectCollection
        Get
            Return rocboComboBox.rocboItems
        End Get
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The maximum number of entries to display in the drop-down list.")> _
    Public Property rosbcboMaxDropDownItems() As Integer
        Get
            Return rocboComboBox.rocboMaxDropDownItems
        End Get
        Set(ByVal value As Integer)
            rocboComboBox.rocboMaxDropDownItems = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Specifies the maximum number of characters that can be entered into the rosbcombobox.")> _
    Public Property rosbcboMaxLength() As Integer
        Get
            Return rocboComboBox.rocboMaxLength
        End Get
        Set(ByVal value As Integer)
            rocboComboBox.rocboMaxLength = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rosbcombobox control can be changed or not.")> _
    Public Property rosbcboReadOnly() As Boolean
        Get
            Return rocboComboBox.rocboReadOnly
        End Get
        Set(ByVal value As Boolean)
            rocboComboBox.rocboReadOnly = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboSelectedIndex() As Integer
        Get
            Return rocboComboBox.rocboSelectedIndex
        End Get
        Set(ByVal value As Integer)
            rocboComboBox.rocboSelectedIndex = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboSelectedItem() As Object
        Get
            Return rocboComboBox.rocboSelectedItem
        End Get
        Set(ByVal value As Object)
            rocboComboBox.rocboSelectedItem = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboSelectedValue() As Object
        Get
            Return rocboComboBox.rocboSelectedValue
        End Get
        Set(ByVal value As Object)
            rocboComboBox.rocboSelectedValue = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Controls whether items in the list portion are sorted.")> _
    Public Property rosbcboSorted() As Boolean
        Get
            Return rocboComboBox.rocboSorted
        End Get
        Set(ByVal value As Boolean)
            rocboComboBox.rocboSorted = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboText() As String
        Get
            Return rocboComboBox.rocboText
        End Get
        Set(ByVal value As String)
            rocboComboBox.rocboText = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboValueMember() As String
        Get
            Return rocboComboBox.rocboValueMember
        End Get
        Set(ByVal value As String)
            rocboComboBox.rocboValueMember = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosbcboDefaultText() As String
        Get
            Return rocboComboBox.rocboDefaultText
        End Get
        Set(ByVal value As String)
            rocboComboBox.rocboDefaultText = value
        End Set
    End Property

#End Region

#Region " rochkdtMinDate "

    Public Event rosbminchkdtpCheckedChanged()
    Public Event rosbminchkdtpValueChanged()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Indicated whether rosbmincheckdatetimepicker is selected or cleared.")> _
    Public Property rosbminchkdtpChecked() As Boolean
        Get
            Return rochkdtMinDate.rochkdtpChecked
        End Get
        Set(ByVal value As Boolean)
            rochkdtMinDate.rochkdtpChecked = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The custom format string using to format the date and/or time displayed in the rosbmincheckdatetimepicker.")> _
    Public Property rosbminchkdtpCustomFormat() As String
        Get
            Return rochkdtMinDate.rochkdtpCustomFormat
        End Get
        Set(ByVal value As String)
            rochkdtMinDate.rochkdtpCustomFormat = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Determines whether dates and times are displayed using standart or custom formatting.")> _
    Public Property rosbminchkdtpFormat() As System.Windows.Forms.DateTimePickerFormat
        Get
            Return rochkdtMinDate.rochkdtpFormat
        End Get
        Set(ByVal value As System.Windows.Forms.DateTimePickerFormat)
            rochkdtMinDate.rochkdtpFormat = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The maximum date that can be selected.")> _
    Public Property rosbminchkdtpMaxDate() As Date
        Get
            Return rochkdtMinDate.rochkdtpMaxDate
        End Get
        Set(ByVal value As Date)
            rochkdtMinDate.rochkdtpMaxDate = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The minimum date that can be selected.")> _
    Public Property rosbminchkdtpMinDate() As Date
        Get
            Return rochkdtMinDate.rochkdtpMinDate
        End Get
        Set(ByVal value As Date)
            rochkdtMinDate.rochkdtpMinDate = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rosbmincheckdatetimepicker can be changed or not.")> _
    Public Property rosbminchkdtpReadOnly() As Boolean
        Get
            Return rochkdtMinDate.rochkdtpReadOnly
        End Get
        Set(ByVal value As Boolean)
            rochkdtMinDate.rochkdtpReadOnly = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosnminchkdtpValue() As Date
        Get
            Return rochkdtMinDate.rochkdtpValue
        End Get
        Set(ByVal value As Date)
            rochkdtMinDate.rochkdtpValue = value
        End Set
    End Property

#End Region

#Region " rochkdtMaxDate "

    Public Event rosbmaxchkdtpCheckedChanged()
    Public Event rosbmaxchkdtpValueChanged()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Indicated whether rosbmaxcheckdatetimepicker is selected or cleared.")> _
    Public Property rosbmaxchkdtpChecked() As Boolean
        Get
            Return rochkdtMaxDate.rochkdtpChecked
        End Get
        Set(ByVal value As Boolean)
            rochkdtMaxDate.rochkdtpChecked = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The custom format string using to format the date and/or time displayed in the rosbmaxcheckdatetimepicker.")> _
    Public Property rosbmaxchkdtpCustomFormat() As String
        Get
            Return rochkdtMaxDate.rochkdtpCustomFormat
        End Get
        Set(ByVal value As String)
            rochkdtMaxDate.rochkdtpCustomFormat = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Determines whether dates and times are displayed using standart or custom formatting.")> _
    Public Property rosbmaxchkdtpFormat() As System.Windows.Forms.DateTimePickerFormat
        Get
            Return rochkdtMaxDate.rochkdtpFormat
        End Get
        Set(ByVal value As System.Windows.Forms.DateTimePickerFormat)
            rochkdtMaxDate.rochkdtpFormat = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The maximum date that can be selected.")> _
    Public Property rosbmaxchkdtpMaxDate() As Date
        Get
            Return rochkdtMaxDate.rochkdtpMaxDate
        End Get
        Set(ByVal value As Date)
            rochkdtMaxDate.rochkdtpMaxDate = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("The minimum date that can be selected.")> _
    Public Property rosbmaxchkdtpMinDate() As Date
        Get
            Return rochkdtMaxDate.rochkdtpMinDate
        End Get
        Set(ByVal value As Date)
            rochkdtMaxDate.rochkdtpMinDate = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROSmartBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rosbmaxcheckdatetimepicker can be changed or not.")> _
    Public Property rosbmaxchkdtpReadOnly() As Boolean
        Get
            Return rochkdtMaxDate.rochkdtpReadOnly
        End Get
        Set(ByVal value As Boolean)
            rochkdtMaxDate.rochkdtpReadOnly = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rosnmaxchkdtpValue() As Date
        Get
            Return rochkdtMaxDate.rochkdtpValue
        End Get
        Set(ByVal value As Date)
            rochkdtMaxDate.rochkdtpValue = value
        End Set
    End Property

#End Region

    Private Sub ShowControl()
        If _smartBoxType = enumSmartBoxType.sbtComboBox Then
            rocboComboBox.Visible = Me.Visible
            'memory leak
            'tlpMinMaxDate.Visible = False
        Else
            'memory leak
            'tlpMinMaxDate.Visible = Me.Visible
            rocboComboBox.Visible = False
        End If
        ROSmartBox_Resize(Nothing, Nothing)
    End Sub

    Private Sub rocboComboBox_SelectedValueChanged() Handles rocboComboBox.rocboSelectedValueChanged
        RaiseEvent rosbcboSelectedValueChanged()
    End Sub

    Private Sub rocboComboBox_TextChanged() Handles rocboComboBox.rocboTextChanged
        RaiseEvent rosbcboTextChanged()
    End Sub

    Private Sub rominchkCheckDateTimePicker_rochkCheckedChanged() Handles rochkdtMinDate.rochkdtpCheckedChanged
        RaiseEvent rosbminchkdtpCheckedChanged()
    End Sub

    Private Sub rominchkCheckDateTimePicker_ValueChanged() Handles rochkdtMinDate.rochkdtpValueChanged
        RaiseEvent rosbminchkdtpValueChanged()
    End Sub

    Private Sub ROSmartBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim height As Integer = System.Math.Max(rocboComboBox.Height, rochkdtMinDate.Height)
        If Me.Height <> height Then
            Me.Height = height
        End If
    End Sub

    Private Sub ROSmartBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ShowControl()
    End Sub

End Class
