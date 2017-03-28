Public Class RONumericUpDown

    Private _isReadOnly As Boolean

    Public Event ronudValueChanged()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RONumericUpDown")> _
    <System.ComponentModel.Description("The font used to display text in the ronumericupdown.")> _
    Public Property ronudFont() As System.Drawing.Font
        Get
            Return nudRONumericUpDown.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            nudRONumericUpDown.Font = value
            txtRONumericUpDown.Font = value
            RONumericUpDown_Resize(Nothing, Nothing)
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RONumericUpDown")> _
    <System.ComponentModel.Description("Indicates the amount to increment or to decrement on each button click.")> _
    Public Property ronudIncrement() As Integer
        Get
            Return nudRONumericUpDown.Increment
        End Get
        Set(ByVal value As Integer)
            nudRONumericUpDown.Increment = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RONumericUpDown")> _
    <System.ComponentModel.Description("Indicates the maximum value for the ronumericupdown control.")> _
    Public Property ronudMaximum() As Integer
        Get
            Return nudRONumericUpDown.Maximum
        End Get
        Set(ByVal value As Integer)
            nudRONumericUpDown.Maximum = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RONumericUpDown")> _
    <System.ComponentModel.Description("Indicates the minimum value for the ronumericupdown control.")> _
    Public Property ronudMinimum() As Integer
        Get
            Return nudRONumericUpDown.Minimum
        End Get
        Set(ByVal value As Integer)
            nudRONumericUpDown.Minimum = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
     <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("RONumericUpDown")> _
    <System.ComponentModel.Description("Controls whether the value in the ronumericupdown control can be changed or not.")> _
    Public Property ronudReadOnly() As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(ByVal value As Boolean)
            _isReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("RONumericUpDown")> _
    <System.ComponentModel.Description("The current value of the ronumericupdown.")> _
    Public Property ronudValue() As Integer
        Get
            Return nudRONumericUpDown.Value
        End Get
        Set(ByVal value As Integer)
            nudRONumericUpDown.Value = value
            ShowControl()
        End Set
    End Property

    Private Sub ShowControl()
        If _isReadOnly Then
            txtRONumericUpDown.Visible = Me.Visible
            nudRONumericUpDown.Visible = False
            txtRONumericUpDown.Text = nudRONumericUpDown.Value.ToString
        Else
            nudRONumericUpDown.Visible = Me.Visible
            txtRONumericUpDown.Visible = False
        End If
        RONumericUpDown_Resize(Nothing, Nothing)
    End Sub

    Private Sub nudRONumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudRONumericUpDown.ValueChanged
        txtRONumericUpDown.Text = nudRONumericUpDown.Value.ToString
        RaiseEvent ronudValueChanged()
    End Sub

    Private Sub RONumericUpDown_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim height As Integer = System.Math.Max(nudRONumericUpDown.Height, txtRONumericUpDown.Height)
        If Me.Height <> height Then
            Me.Height = height
        End If
    End Sub

    Private Sub RONumericUpDown_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ShowControl()
    End Sub

End Class
