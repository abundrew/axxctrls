Public Class RODateTimePicker

    Private _isReadOnly As Boolean
    Private _isNull As Boolean = True

    <System.ComponentModel.Browsable(False)> _
    Public Property rodtpIsNull() As Boolean
        Get
            Return _isNull
        End Get
        Set(ByVal value As Boolean)
            _isNull = value
            ShowControl()
        End Set
    End Property

    Public Event rodtpCloseUp()
    Public Event rodtpDropDown()
    Public Event rodtpEnter()
    Public Event rodtpValueChanged()

    Public Sub New()
        InitializeComponent()
        dtpRODateTimePicker.Value = Today
    End Sub

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RODateTimePicker")> _
    <System.ComponentModel.Description("The custom format string using to format the date and/or time displayed in the rodatetimepicker.")> _
    Public Property rodtpCustomFormat() As String
        Get
            Return dtpRODateTimePicker.CustomFormat
        End Get
        Set(ByVal value As String)
            dtpRODateTimePicker.CustomFormat = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RODateTimePicker")> _
    <System.ComponentModel.Description("The font used to display text in the rodatetimepicker.")> _
    Public Property rodtpFont() As System.Drawing.Font
        Get
            Return dtpRODateTimePicker.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            dtpRODateTimePicker.Font = value
            dtpRODateTimePicker.CalendarFont = value
            txtRODateTimePicker.Font = value
            RODateTimePicker_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RODateTimePicker")> _
    <System.ComponentModel.Description("Determines whether dates and times are displayed using standart or custom formatting.")> _
    Public Property rodtpFormat() As System.Windows.Forms.DateTimePickerFormat
        Get
            Return dtpRODateTimePicker.Format
        End Get
        Set(ByVal value As System.Windows.Forms.DateTimePickerFormat)
            dtpRODateTimePicker.Format = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RODateTimePicker")> _
    <System.ComponentModel.Description("The maximum date that can be selected.")> _
    Public Property rodtpMaxDate() As Date
        Get
            Return dtpRODateTimePicker.MaxDate
        End Get
        Set(ByVal value As Date)
            dtpRODateTimePicker.MaxDate = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RODateTimePicker")> _
    <System.ComponentModel.Description("The minimum date that can be selected.")> _
    Public Property rodtpMinDate() As Date
        Get
            Return dtpRODateTimePicker.MinDate
        End Get
        Set(ByVal value As Date)
            dtpRODateTimePicker.MinDate = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("RODateTimePicker")> _
    <System.ComponentModel.Description("Controls whether the value in the rodatetimepicker control can be changed or not.")> _
    Public Property rodtpReadOnly() As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(ByVal value As Boolean)
            _isReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rodtpValue() As Date
        Get
            Const _nullDate As DateTime = #12:00:00 AM#

            If _isNull Then
                Return _nullDate
            Else
                Return dtpRODateTimePicker.Value
            End If
        End Get
        Set(ByVal value As Date)
            Const _nullDate As DateTime = #12:00:00 AM#

            _isNull = _nullDate.Equals(value)
            If Not _isNull Then
                dtpRODateTimePicker.Value = value
            End If
            ShowControl()
        End Set
    End Property

    Private Sub ShowControl()
        If _isReadOnly Then
            txtRODateTimePicker.Visible = Me.Visible
            dtpRODateTimePicker.Visible = False
            txtRODateTimePicker.Text = IIf(_isNull, "", dtpRODateTimePicker.Value.ToShortDateString)
        Else
            dtpRODateTimePicker.Visible = Me.Visible
            txtRODateTimePicker.Visible = False
        End If
        RODateTimePicker_Resize(Nothing, Nothing)
    End Sub

    Private Sub dtpRODateTimePicker_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpRODateTimePicker.CloseUp
        ShowControl()
        RaiseEvent rodtpCloseUp()
    End Sub

    Private Sub dtpRODateTimePicker_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpRODateTimePicker.DropDown
        ShowControl()
        RaiseEvent rodtpDropDown()
    End Sub

    Private Sub dtpRODateTimePicker_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpRODateTimePicker.Enter
        RaiseEvent rodtpEnter()
    End Sub

    Private Sub dtpRODateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpRODateTimePicker.ValueChanged
        ShowControl()
        RaiseEvent rodtpValueChanged()
    End Sub

    Private Sub RODateTimePicker_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim height As Integer = System.Math.Max(dtpRODateTimePicker.Height, txtRODateTimePicker.Height)
        If Me.Height <> height Then
            Me.Height = height
        End If
    End Sub

    Private Sub RODateTimePicker_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ShowControl()
    End Sub

End Class
