Public Class ROTextBox

    Private _isReadOnly As Boolean

    Public Event rotxtTextChanged()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Indicates if return characters are accepted for the rotextbox.")> _
    Public Property rotxtAcceptsReturn() As Boolean
        Get
            Return txtROTextBox.AcceptsReturn
        End Get
        Set(ByVal value As Boolean)
            txtROTextBox.AcceptsReturn = value
            txtROTextBoxRO.AcceptsReturn = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Indicates if tab characters are accepted for the rotextbox.")> _
    Public Property rotxtAcceptsTab() As Boolean
        Get
            Return txtROTextBox.AcceptsTab
        End Get
        Set(ByVal value As Boolean)
            txtROTextBox.AcceptsTab = value
            txtROTextBoxRO.AcceptsTab = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Indicates if all characters should be left alone or converted to uppercase or lowercase in the rotextbox.")> _
    Public Property rotxtCharacterCasing() As System.Windows.Forms.CharacterCasing
        Get
            Return txtROTextBox.CharacterCasing
        End Get
        Set(ByVal value As System.Windows.Forms.CharacterCasing)
            txtROTextBox.CharacterCasing = value
            txtROTextBoxRO.CharacterCasing = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
     <System.ComponentModel.Category("ROTextBox")> _
     <System.ComponentModel.Description("The font used to display text in the rotextbox.")> _
     Public Property rotxtFont() As System.Drawing.Font
        Get
            Return txtROTextBox.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            txtROTextBox.Font = value
            txtROTextBoxRO.Font = value
            ROTextBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Specifies the maximum number of characters that can be entered into the rotextbox.")> _
    Public Property rotxtMaxLength() As Integer
        Get
            Return txtROTextBox.MaxLength
        End Get
        Set(ByVal value As Integer)
            txtROTextBox.MaxLength = value
            txtROTextBoxRO.MaxLength = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Controls whether the text in the rotextbox can span more than one line.")> _
    Public Property rotxtMultiline() As Boolean
        Get
            Return txtROTextBox.Multiline
        End Get
        Set(ByVal value As Boolean)
            txtROTextBox.Multiline = value
            txtROTextBoxRO.Multiline = value

            ROTextBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Controls whether the value in the rotextbox can be changed or not.")> _
    Public Property rotxtReadOnly() As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(ByVal value As Boolean)
            _isReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Indicates which scrollbars will be shown for the rotextbox.")> _
    Public Property rotxtScrollbars() As System.Windows.Forms.ScrollBars
        Get
            Return txtROTextBox.ScrollBars
        End Get
        Set(ByVal value As System.Windows.Forms.ScrollBars)
            txtROTextBox.ScrollBars = value
            txtROTextBoxRO.ScrollBars = value
            ROTextBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue("")> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("The text contained in the rotextbox.")> _
    Public Property rotxtText() As String
        Get
            Return txtROTextBox.Text
        End Get
        Set(ByVal value As String)
            txtROTextBox.Text = value
            txtROTextBoxRO.Text = value
            ROTextBox_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue("")> _
    <System.ComponentModel.Category("ROTextBox")> _
    <System.ComponentModel.Description("Indicates if lines were automatically word-wrapped for the rotextbox.")> _
    Public Property rotxtWordWrap() As Boolean
        Get
            Return txtROTextBox.WordWrap
        End Get
        Set(ByVal value As Boolean)
            txtROTextBox.WordWrap = value
            txtROTextBoxRO.WordWrap = value
            ROTextBox_Resize(Nothing, Nothing)
        End Set
    End Property

    Public Sub SetTabWidth(ByVal numberOfSpaces As Integer)
        clsTextBox.SetTabWidth(txtROTextBox, numberOfSpaces)
        clsTextBox.SetTabWidth(txtROTextBoxRO, numberOfSpaces)
    End Sub

    Private Sub ShowControl()
        If _isReadOnly Then
            txtROTextBoxRO.Visible = Me.Visible
            txtROTextBox.Visible = False
            txtROTextBoxRO.Text = txtROTextBox.Text
            txtROTextBoxRO.SelectionLength = 0
        Else
            txtROTextBox.Visible = Me.Visible
            txtROTextBoxRO.Visible = False
        End If
        ROTextBox_Resize(Nothing, Nothing)
    End Sub

    Private Sub txtROTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtROTextBox.TextChanged
        RaiseEvent rotxtTextChanged()
    End Sub

    Private Sub ROTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Not rotxtMultiline Then
            Dim height As Integer = System.Math.Max(txtROTextBox.Height, txtROTextBoxRO.Height)
            If Me.Height <> height Then
                Me.Height = height
            End If
        End If
    End Sub

    Private Sub ROTextBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ShowControl()
    End Sub

End Class
