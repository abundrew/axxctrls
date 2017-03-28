Public Class ROCheckDateTimePicker

    Private _mandatory As Boolean = False

    Public Event rochkdtpCheckedChanged()
    Public Event rochkdtpValueChanged()

    Public Sub New()
        InitializeComponent()
        dtpROCheckDateTimePicker.rodtpValue = Today
    End Sub

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckDateTimePicker")> _
    <System.ComponentModel.Description("Indicated whether rocheckdatetimepicker is selected or cleared.")> _
    Public Property rochkdtpChecked() As Boolean
        Get
            Return chkROCheckDateTimePicker.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            chkROCheckDateTimePicker.rochkChecked = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckDateTimePicker")> _
    <System.ComponentModel.Description("The custom format string using to format the date and/or time displayed in the rocheckdatetimepicker.")> _
    Public Property rochkdtpCustomFormat() As String
        Get
            Return dtpROCheckDateTimePicker.rodtpCustomFormat
        End Get
        Set(ByVal value As String)
            dtpROCheckDateTimePicker.rodtpCustomFormat = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckDateTimePicker")> _
    <System.ComponentModel.Description("The font used to display text in the rocheckdatetimepicker.")> _
    Public Property rochkdtpFont() As System.Drawing.Font
        Get
            Return dtpROCheckDateTimePicker.rodtpFont
        End Get
        Set(ByVal value As System.Drawing.Font)
            chkROCheckDateTimePicker.rochkFont = value
            dtpROCheckDateTimePicker.rodtpFont = value
            ROCheckDateTimePicker_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckDateTimePicker")> _
    <System.ComponentModel.Description("Determines whether dates and times are displayed using standart or custom formatting.")> _
    Public Property rochkdtpFormat() As System.Windows.Forms.DateTimePickerFormat
        Get
            Return dtpROCheckDateTimePicker.rodtpFormat
        End Get
        Set(ByVal value As System.Windows.Forms.DateTimePickerFormat)
            dtpROCheckDateTimePicker.rodtpFormat = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckDateTimePicker")> _
    <System.ComponentModel.Description("The maximum date that can be selected.")> _
    Public Property rochkdtpMaxDate() As Date
        Get
            Return dtpROCheckDateTimePicker.rodtpMaxDate
        End Get
        Set(ByVal value As Date)
            dtpROCheckDateTimePicker.rodtpMaxDate = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckDateTimePicker")> _
    <System.ComponentModel.Description("The minimum date that can be selected.")> _
    Public Property rochkdtpMinDate() As Date
        Get
            Return dtpROCheckDateTimePicker.rodtpMinDate
        End Get
        Set(ByVal value As Date)
            dtpROCheckDateTimePicker.rodtpMinDate = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROCheckDateTimePicker")> _
    <System.ComponentModel.Description("Controls whether the value in the rocheckdatetimepicker can be changed or not.")> _
    Public Property rochkdtpReadOnly() As Boolean
        Get
            Return chkROCheckDateTimePicker.rochkReadOnly
        End Get
        Set(ByVal value As Boolean)
            chkROCheckDateTimePicker.rochkReadOnly = value
            dtpROCheckDateTimePicker.rodtpReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkdtpValue() As Date
        Get
            Return dtpROCheckDateTimePicker.rodtpValue
        End Get
        Set(ByVal value As Date)
            Const _nullDate As DateTime = #12:00:00 AM#

            chkROCheckDateTimePicker.rochkChecked = Not _nullDate.Equals(value)
            dtpROCheckDateTimePicker.rodtpValue = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property rochkdtpMandatory() As Boolean
        Get
            Return _mandatory
        End Get
        Set(ByVal value As Boolean)
            _mandatory = value
            ShowControl()
        End Set
    End Property

    Private Sub ShowControl()
        panelROCheckDateTimePicker.Visible = Me.Visible
        chkROCheckDateTimePicker.Visible = Not _mandatory
        dtpROCheckDateTimePicker.Enabled = _
            rochkdtpReadOnly OrElse _mandatory OrElse chkROCheckDateTimePicker.rochkChecked
        ROCheckDateTimePicker_Resize(Nothing, Nothing)
    End Sub

    Private Sub chkROCheckDateTimePicker_rochkCheckedChanged() Handles chkROCheckDateTimePicker.rochkCheckedChanged
        Me.dtpROCheckDateTimePicker.rodtpIsNull = Not chkROCheckDateTimePicker.rochkChecked
        ShowControl()
        RaiseEvent rochkdtpCheckedChanged()
    End Sub

    Private Sub dtpRODateTimePicker_ValueChanged() Handles dtpROCheckDateTimePicker.rodtpValueChanged
        RaiseEvent rochkdtpValueChanged()
    End Sub

    Private Sub ROCheckDateTimePicker_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height <> dtpROCheckDateTimePicker.Height Then
            Me.Height = dtpROCheckDateTimePicker.Height
        End If
    End Sub

    Private Sub ROCheckDateTimePicker_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ShowControl()
    End Sub

End Class
