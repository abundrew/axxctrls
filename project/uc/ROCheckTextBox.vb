Public Class ROCheckTextBox

    Public Event rochktxtCheckedChanged()
    Public Event rochktxtTextChanged()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckTextBox")> _
    <System.ComponentModel.Description("Indicated whether rochecktextbox is selected or cleared.")> _
    Public Property rochktxtChecked() As Boolean
        Get
            Return chkROCheckTextBox.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            chkROCheckTextBox.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
      <System.ComponentModel.Category("ROCheckTextBox")> _
      <System.ComponentModel.Description("The font used to display text in the rochecktextbox.")> _
      Public Property rochktxtFont() As System.Drawing.Font
        Get
            Return txtROCheckTextBox.rotxtFont
        End Get
        Set(ByVal value As System.Drawing.Font)
            chkROCheckTextBox.rochkFont = value
            txtROCheckTextBox.rotxtFont = value
            ROCheckTextBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckTextBox")> _
    <System.ComponentModel.Description("Specifies the maximum number of characters that can be entered into the rochecktextbox.")> _
    Public Property rochktxtMaxLength() As Integer
        Get
            Return txtROCheckTextBox.rotxtMaxLength
        End Get
        Set(ByVal value As Integer)
            txtROCheckTextBox.rotxtMaxLength = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROCheckTextBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rochecktextbox can be changed or not.")> _
    Public Property rochktxtReadOnly() As Boolean
        Get
            Return chkROCheckTextBox.rochkReadOnly
        End Get
        Set(ByVal value As Boolean)
            chkROCheckTextBox.rochkReadOnly = value
            txtROCheckTextBox.rotxtReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue("")> _
    <System.ComponentModel.Category("ROCheckTextBox")> _
    <System.ComponentModel.Description("The text contained in the rochecktextbox.")> _
    Public Property rochktxtText() As String
        Get
            Return txtROCheckTextBox.rotxtText
        End Get
        Set(ByVal value As String)
            txtROCheckTextBox.rotxtText = value
        End Set
    End Property

    Private Sub ShowControl()
        panelROCheckTextBox.Visible = Me.Visible
        txtROCheckTextBox.Enabled = rochktxtReadOnly OrElse chkROCheckTextBox.rochkChecked
        If rochktxtReadOnly And Not chkROCheckTextBox.rochkChecked Then
            txtROCheckTextBox.rotxtText = ""
        End If
        ROCheckTextBox_Resize(Nothing, Nothing)
    End Sub

    Private Sub chkROCheckTextBox_rochkCheckedChanged() Handles chkROCheckTextBox.rochkCheckedChanged
        ShowControl()
        RaiseEvent rochktxtCheckedChanged()
    End Sub

    Private Sub txtROCheckTextBox_rotxtTextChanged() Handles txtROCheckTextBox.rotxtTextChanged
        RaiseEvent rochktxtTextChanged()
    End Sub

    Private Sub ROCheckTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height <> txtROCheckTextBox.Height Then
            Me.Height = txtROCheckTextBox.Height
        End If
    End Sub

    Private Sub ROCheckTextBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        'panelROCheckTextBox.Visible = Me.Visible
        'txtROCheckTextBox.Enabled = rochktxtReadOnly OrElse chkROCheckTextBox.rochkChecked
        ShowControl()
    End Sub

End Class
