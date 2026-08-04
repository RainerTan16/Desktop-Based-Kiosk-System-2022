Public Class Form1

    Public Shared OrderType As String = ""
    Private Sub BtnDineIn_Click(sender As Object, e As EventArgs) Handles BtnDineIn.Click
        OrderType = "DINE IN"
        PayMethod.Show()
        Me.Hide()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim Response As String = MsgBox("Are you sure to close this application?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Exit")

        If Response = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnTakeOut_Click(sender As Object, e As EventArgs) Handles BtnTakeOut.Click
        OrderType = "TAKE OUT"
        PayMethod.Show()
        Me.Hide()
    End Sub
End Class
