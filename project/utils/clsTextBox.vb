Public Class clsTextBox

    Private Const EM_SETTABSTOPS As Integer = &HCB

    Public Declare Auto Function SendMessage Lib "User32" _
             (ByVal hwnd As IntPtr, _
              ByVal wMsg As Integer, _
              ByVal wParam As Integer, _
              ByVal lParam() As Integer) As Integer

    Public Shared Sub SetTabWidth(ByVal textBox As TextBox, ByVal numberOfSpaces As Integer)
        Dim TabArray() As Integer = {8}

        TabArray(0) = numberOfSpaces * 4
        SendMessage(textBox.Handle, EM_SETTABSTOPS, 1, TabArray)
    End Sub

End Class
