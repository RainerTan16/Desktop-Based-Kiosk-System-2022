Public Class PayMethod
    Public Shared PaymentMethod As String = ""
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim Response As String = MsgBox("Are you sure to close this application?", MsgBoxStyle.OkCancel, "Exit")

        If Response = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCash_Click(sender As Object, e As EventArgs) Handles BtnCash.Click
        PaymentMethod = "CASH"
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCashless_Click(sender As Object, e As EventArgs) Handles BtnCashless.Click
        PaymentMethod = "CASHLESS"
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class