Public Class Cashless
    Private Sub BtnGCash_Click(sender As Object, e As EventArgs) Handles BtnGCash.Click
        Dim GcashAmount As String = InputBox("Enter the Gcash Number: ", "Gcash Number")

        If String.IsNullOrEmpty(GcashAmount) OrElse Not IsNumeric(GcashAmount) OrElse GcashAmount.Length <> 11 Then
            MsgBox("Invalid, Please enter a valid 11-digit Gcash Number ", MsgBoxStyle.Exclamation, "Warning")
        Else
            MsgBox("Succesfully paid", MsgBoxStyle.Information, "Payment")
            MsgBox("Thank you for order to us", MsgBoxStyle.OkOnly, "Greeting")
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BtnPayMaya_Click(sender As Object, e As EventArgs) Handles BtnPayMaya.Click
        Dim PayMayaAmount As String = InputBox("Enter the PayMaya: ", "PayMaya Number")

        If String.IsNullOrEmpty(PayMayaAmount) OrElse Not IsNumeric(PayMayaAmount) OrElse PayMayaAmount.Length <> 11 Then
            MsgBox("Invalid, Please enter a valid 11-digit PayMaya Number ", MsgBoxStyle.Exclamation, "Warning")
        Else
            MsgBox("Succesfully paid", MsgBoxStyle.Information, "Payment")
            MsgBox("Thank you for order to us", MsgBoxStyle.OkOnly, "Greeting")
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class