Public Class ROCheckBox

    Private _isReadOnly As Boolean

    Public Event rochkCheckedChanged()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckBox")> _
    <System.ComponentModel.Description("Indicated whether rocheckbox is selected or cleared.")> _
    Public Property rochkChecked() As Boolean
        Get
            Return chkROCheckBox.Checked
        End Get
        Set(ByVal value As Boolean)
            chkROCheckBox.Checked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckBox")> _
    <System.ComponentModel.Description("The font used to display text in the rocheckbox.")> _
    Public Property rochkFont() As System.Drawing.Font
        Get
            Return chkROCheckBox.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            chkROCheckBox.Font = value
            lblROCheckBox.Font = value
            lblROCheckBoxText.Font = value
            ROCheckBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROCheckBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rocheckbox control can be changed or not.")> _
    Public Property rochkReadOnly() As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(ByVal value As Boolean)
            _isReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROCheckBox")> _
    <System.ComponentModel.Description("The text contained in the rocheckbox.")> _
    Public Property rochkText() As String
        Get
            Return chkROCheckBox.Text
        End Get
        Set(ByVal value As String)
            chkROCheckBox.Text = value
            lblROCheckBoxText.Text = value
            ShowControl()
        End Set
    End Property

    Private Sub ShowControl()
        If _isReadOnly Then
            lblROCheckBox.Visible = Me.Visible
            chkROCheckBox.Visible = False
            lblROCheckBoxText.Visible = Me.Visible
        Else
            chkROCheckBox.Visible = Me.Visible
            lblROCheckBox.Visible = False
            lblROCheckBoxText.Visible = False
        End If
    End Sub

    Private Sub ROCheckBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height <> chkROCheckBox.Font.Height + 7 Then
            Me.Height = chkROCheckBox.Font.Height + 7
        End If
    End Sub

    Private Sub ROCheckBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ShowControl()
    End Sub

    Private Sub chkROCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkROCheckBox.CheckedChanged
        lblROCheckBox.ImageKey = IIf(chkROCheckBox.Checked, "checkmark", "checkbox")
        RaiseEvent rochkCheckedChanged()
    End Sub

End Class
