Public Class ROActiveStatus

    Private _activity As Boolean = True
    Private _isReadOnly As Boolean
    Private _interrelated As Boolean
    Private _interrelating As Boolean = False

    Private _activityIsNull As Boolean = False

    Public Event roasCheckedChangedAfter()
    Public Event roasCheckedChangedBefore()

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.Category("ROActiveStatus")> _
    <System.ComponentModel.Description("The font used to display text in the roactivestatus.")> _
    Public Property roasFont() As System.Drawing.Font
        Get
            Return grpROActiveStatus.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            grpROActiveStatus.Font = value
            rochkActive.rochkFont = value
            rochkInactive.rochkFont = value
            rochkCalibration.rochkFont = value
            rochkService.rochkFont = value
            rochkLent.rochkFont = value
            rochkStorage.rochkFont = value
            rochkMissing.rochkFont = value
            rochkScrapped.rochkFont = value
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROActiveStatus")> _
    <System.ComponentModel.Description("Controls whether the value in the roactivestatus control can be changed or not.")> _
    Public Property roasReadOnly() As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(ByVal value As Boolean)
            _isReadOnly = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("ROActiveStatus")> _
    <System.ComponentModel.Description("Controls whether the checkboxes in the roactivestatus control are interrelated.")> _
    Public Property roasInterrelated() As Boolean
        Get
            Return _interrelated
        End Get
        Set(ByVal value As Boolean)
            _interrelated = value
            ShowControl()
        End Set
    End Property

    Public Sub roasSetText( _
        ByVal groupText As String, _
        ByVal activeText As String, _
        ByVal inactiveText As String, _
        ByVal calibrationText As String, _
        ByVal serviceText As String, _
        ByVal lentText As String, _
        ByVal storageText As String, _
        ByVal missingText As String, _
        ByVal scrappedText As String _
    )
        grpROActiveStatus.Text = groupText
        rochkActive.rochkText = activeText
        rochkInactive.rochkText = inactiveText
        rochkCalibration.rochkText = calibrationText
        rochkService.rochkText = serviceText
        rochkLent.rochkText = lentText
        rochkStorage.rochkText = storageText
        rochkMissing.rochkText = missingText
        rochkScrapped.rochkText = scrappedText
    End Sub

    <System.ComponentModel.Browsable(False)> _
    Public Property roasActivity() As Boolean
        Get
            Return _activity
        End Get
        Set(ByVal value As Boolean)
            _activity = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasActivityIsNull() As Boolean
        Get
            Return _activityIsNull
        End Get
        Set(ByVal value As Boolean)
            _activityIsNull = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasActiveChecked() As Boolean
        Get
            Return rochkActive.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkActive.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasInactiveChecked() As Boolean
        Get
            Return rochkInactive.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkInactive.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasCalibrationChecked() As Boolean
        Get
            Return rochkCalibration.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkCalibration.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasServiceChecked() As Boolean
        Get
            Return rochkService.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkService.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasLentChecked() As Boolean
        Get
            Return rochkLent.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkLent.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasLentEnabled() As Boolean
        Get
            Return rochkLent.Enabled
        End Get
        Set(ByVal value As Boolean)
            rochkLent.Enabled = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasStorageChecked() As Boolean
        Get
            Return rochkStorage.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkStorage.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasMissingChecked() As Boolean
        Get
            Return rochkMissing.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkMissing.rochkChecked = value
            ShowControl()
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    Public Property roasScrappedChecked() As Boolean
        Get
            Return rochkScrapped.rochkChecked
        End Get
        Set(ByVal value As Boolean)
            rochkScrapped.rochkChecked = value
            ShowControl()
        End Set
    End Property

    Private Sub ShowControl()
        If _isReadOnly Then
            rochkActive.rochkReadOnly = True
            rochkInactive.rochkReadOnly = True
            rochkCalibration.rochkReadOnly = True
            rochkService.rochkReadOnly = True
            rochkLent.rochkReadOnly = True
            rochkStorage.rochkReadOnly = True
            rochkMissing.rochkReadOnly = True
            rochkScrapped.rochkReadOnly = True
            rochkActive.Enabled = True
            rochkInactive.Enabled = True
            rochkStorage.Enabled = True
            rochkMissing.Enabled = True
            rochkScrapped.Enabled = True
        Else
            If _interrelated Then
                rochkActive.rochkReadOnly = False
                rochkInactive.rochkReadOnly = False
                rochkCalibration.rochkReadOnly = True
                rochkService.rochkReadOnly = True
                rochkLent.rochkReadOnly = True
                rochkStorage.rochkReadOnly = False
                rochkMissing.rochkReadOnly = False
                rochkScrapped.rochkReadOnly = False
                Interrelation()
            Else
                rochkActive.rochkReadOnly = False
                rochkInactive.rochkReadOnly = False
                rochkCalibration.rochkReadOnly = False
                rochkService.rochkReadOnly = False
                rochkLent.rochkReadOnly = False
                rochkStorage.rochkReadOnly = False
                rochkMissing.rochkReadOnly = False
                rochkScrapped.rochkReadOnly = False
            End If
        End If
    End Sub

    Private Sub Interrelation()
        _interrelating = True

        If _activityIsNull Then
            rochkActive.rochkChecked = False
            rochkInactive.rochkChecked = False
        End If

        If Not _activity Then
            rochkActive.rochkChecked = False
        End If
        If rochkActive.rochkChecked Then
            rochkScrapped.rochkChecked = False
        End If
        If rochkStorage.rochkChecked Then
            rochkMissing.rochkChecked = False
        End If
        If rochkMissing.rochkChecked Then
            rochkStorage.rochkChecked = False
            rochkScrapped.rochkChecked = False
        End If
        If rochkCalibration.rochkChecked Then
            rochkActive.rochkChecked = False
        End If
        If rochkService.rochkChecked Then
            rochkActive.rochkChecked = False
        End If
        If rochkScrapped.rochkChecked Then
            rochkActive.rochkChecked = False
            rochkMissing.rochkChecked = False
        End If

        If Not _activityIsNull Then
            rochkInactive.rochkChecked = Not rochkActive.rochkChecked
        End If

        rochkActive.Enabled = _activityIsNull OrElse _isReadOnly OrElse (_activity AndAlso _
            Not rochkCalibration.rochkChecked AndAlso Not rochkService.rochkChecked AndAlso Not rochkScrapped.rochkChecked)
        rochkInactive.Enabled = _activityIsNull OrElse _isReadOnly OrElse (_activity AndAlso _
            Not rochkCalibration.rochkChecked AndAlso Not rochkService.rochkChecked AndAlso Not rochkScrapped.rochkChecked)
        rochkStorage.Enabled = _isReadOnly OrElse Not rochkMissing.rochkChecked
        rochkMissing.Enabled = _isReadOnly OrElse (Not rochkStorage.rochkChecked AndAlso Not rochkScrapped.rochkChecked)
        rochkScrapped.Enabled = _isReadOnly OrElse (Not rochkActive.rochkChecked AndAlso Not rochkMissing.rochkChecked)
        _interrelating = False
    End Sub

    Private Sub rochkActive_rochkCheckedChanged() Handles rochkActive.rochkCheckedChanged
        RaiseEvent roasCheckedChangedBefore()
        If _interrelated AndAlso Not _interrelating Then
            _interrelating = True
            rochkInactive.rochkChecked = False
            _interrelating = False
            Interrelation()
        End If
        RaiseEvent roasCheckedChangedAfter()
    End Sub

    Private Sub rochkInactive_rochkCheckedChanged() Handles rochkInactive.rochkCheckedChanged
        RaiseEvent roasCheckedChangedBefore()
        If _interrelated AndAlso Not _interrelating Then
            _interrelating = True
            rochkActive.rochkChecked = False
            _interrelating = False
            Interrelation()
        End If
        RaiseEvent roasCheckedChangedAfter()
    End Sub

    Private Sub rochkStorage_rochkCheckedChanged() Handles rochkStorage.rochkCheckedChanged
        RaiseEvent roasCheckedChangedBefore()
        If _interrelated AndAlso Not _interrelating Then
            Interrelation()
        End If
        RaiseEvent roasCheckedChangedAfter()
    End Sub

    Private Sub rochkMissing_rochkCheckedChanged() Handles rochkMissing.rochkCheckedChanged
        RaiseEvent roasCheckedChangedBefore()
        If _interrelated AndAlso Not _interrelating Then
            Interrelation()
        End If
        RaiseEvent roasCheckedChangedAfter()
    End Sub

    Private Sub rochkScrapped_rochkCheckedChanged() Handles rochkScrapped.rochkCheckedChanged
        RaiseEvent roasCheckedChangedBefore()
        If _interrelated AndAlso Not _interrelating Then
            Interrelation()
        End If
        RaiseEvent roasCheckedChangedAfter()
    End Sub

End Class
