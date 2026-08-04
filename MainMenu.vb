Public Class MainMenu
    Public QuantitySpicy = 0, QuantityCrispy = 0, QuantityDouble = 0, QuantityRush = 0, QuantityNormalBurger = 0
    Public QuantityGolden = 0, QuantityCheesy = 0, QuantityOnion = 0, QuantityFries = 0, QuantityMozza = 0
    Public QuantitySoda = 0, QuantityMilk = 0, QuantityLemon = 0, QuantityIce = 0
    Public Orderlist As New List(Of String)
    Public Pricelist As Integer = 0

    Public Sub Empty()
        MsgBox("Quantity is empty", MsgBoxStyle.Exclamation, "Empty")
    End Sub

    Private Sub BtnPlusSpicy_Click_1(sender As Object, e As EventArgs) Handles BtnPlusSpicy.Click
        QuantitySpicy += 1
        TxtQuantitySpicy.Text = QuantitySpicy.ToString
    End Sub

    Private Sub BtnMinusSpicy_Click_1(sender As Object, e As EventArgs) Handles BtnMinusSpicy.Click
        If QuantitySpicy > 0 Then
            QuantitySpicy -= 1
            TxtQuantitySpicy.Text = QuantitySpicy.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusGolden_Click(sender As Object, e As EventArgs) Handles BtnPlusGolden.Click
        QuantityGolden += 1
        TxtQuantityGolden.Text = QuantityGolden.ToString
    End Sub

    Private Sub BtnMinusGolden_Click(sender As Object, e As EventArgs) Handles BtnMinusGolden.Click
        If QuantityGolden > 0 Then
            QuantityGolden -= 1
            TxtQuantityGolden.Text = QuantityGolden.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusCheesy_Click(sender As Object, e As EventArgs) Handles BtnPlusCheesy.Click
        QuantityCheesy += 1
        TxtQuantityCheesy.Text = QuantityCheesy.ToString
    End Sub

    Private Sub BtnMinusCheesy_Click(sender As Object, e As EventArgs) Handles BtnMinusCheesy.Click
        If QuantityCheesy > 0 Then
            QuantityCheesy -= 1
            TxtQuantityCheesy.Text = QuantityCheesy.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusOnion_Click(sender As Object, e As EventArgs) Handles BtnPlusOnion.Click
        QuantityOnion += 1
        TxtQuantityOnion.Text = QuantityOnion.ToString
    End Sub

    Private Sub BtnMinusOnion_Click(sender As Object, e As EventArgs) Handles BtnMinusOnion.Click
        If QuantityOnion > 0 Then
            QuantityOnion -= 1
            TxtQuantityOnion.Text = QuantityOnion.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusFries_Click(sender As Object, e As EventArgs) Handles BtnPlusFries.Click
        QuantityFries += 1
        TxtQuantityFries.Text = QuantityFries.ToString
    End Sub

    Private Sub BtnMinusFries_Click(sender As Object, e As EventArgs) Handles BtnMinusFries.Click
        If QuantityFries > 0 Then
            QuantityFries -= 1
            TxtQuantityFries.Text = QuantityFries.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusMozza_Click(sender As Object, e As EventArgs) Handles BtnPlusMozza.Click
        QuantityMozza += 1
        TxtQuantityMozza.Text = QuantityMozza.ToString
    End Sub

    Private Sub BtnMinusMozza_Click(sender As Object, e As EventArgs) Handles BtnMinusMozza.Click
        If QuantityMozza > 0 Then
            QuantityMozza -= 1
            TxtQuantityMozza.Text = QuantityMozza.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnBurger_Click(sender As Object, e As EventArgs) Handles BtnBurger.Click
        PanelNewBurger.BringToFront()
        PanelSelectMenu.Hide()
    End Sub

    Private Sub BtnFries_Click(sender As Object, e As EventArgs) Handles BtnFries.Click
        PanelFries.BringToFront()
        PanelSelectMenu.Hide()
    End Sub

    Private Sub BtnDrinks_Click(sender As Object, e As EventArgs) Handles BtnDrinks.Click
        PanelDrinks.BringToFront()
        PanelSelectMenu.Hide()
    End Sub

    Public Sub Quantity()
        QuantitySpicy = 0
        QuantityCrispy = 0
        QuantityDouble = 0
        QuantityRush = 0
        QuantityNormalBurger = 0
        QuantityGolden = 0
        QuantityCheesy = 0
        QuantityOnion = 0
        QuantityMozza = 0
        QuantityFries = 0
        QuantitySoda = 0
        QuantityMilk = 0
        QuantityLemon = 0
        QuantityIce = 0

        TxtQuantitySpicy.Clear()
        TxtQuantityCrispy.Clear()
        TxtQuantityDouble.Clear()
        TxtQuantityRush.Clear()
        TxtQuantityBurger.Clear()
        TxtQuantityGolden.Clear()
        TxtQuantityCheesy.Clear()
        TxtQuantityOnion.Clear()
        TxtQuantityMozza.Clear()
        TxtQuantityFries.Clear()
        TxtQuantitySoda.Clear()
        TxtQuantityMilkshake.Clear()
        TxtQuantityLemon.Clear()
        TxtQuantityIce.Clear()
    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        Dim OrderSummary As String = "Qty       Item Name                    Price" & vbCrLf
        OrderSummary &= "----------------------------------------------" & vbCrLf

        Orderlist.Clear()
        Pricelist = 0

        If QuantitySpicy = 0 AndAlso QuantityCrispy = 0 AndAlso QuantityDouble = 0 AndAlso QuantityRush = 0 AndAlso
       QuantityNormalBurger = 0 AndAlso QuantityGolden = 0 AndAlso QuantityCheesy = 0 AndAlso QuantityOnion = 0 AndAlso
       QuantityMozza = 0 AndAlso QuantityFries = 0 AndAlso QuantitySoda = 0 AndAlso QuantityMilk = 0 AndAlso
       QuantityLemon = 0 AndAlso QuantityIce = 0 Then

            MsgBox("Please select an order before proceeding!", MsgBoxStyle.Exclamation, "No Order Selected")
            Exit Sub
        End If

        If QuantitySpicy > 0 Then
            Dim TotalSpicy As Integer = 100 * QuantitySpicy
            Dim Orderline As String = QuantitySpicy.ToString.PadRight(8) & " Burger Inferno".PadRight(32) & TotalSpicy & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalSpicy
        End If

        If QuantityCrispy > 0 Then
            Dim TotalCrispy As Integer = 90 * QuantityCrispy
            Dim Orderline As String = QuantityCrispy.ToString.PadRight(8) & " Crispy Crunch".PadRight(33) & TotalCrispy & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalCrispy
        End If

        If QuantityDouble > 0 Then
            Dim TotalDouble As Integer = 90 * QuantityDouble
            Dim Orderline As String = QuantityDouble.ToString.PadRight(8) & "Double Trouble".PadRight(32) & TotalDouble & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalDouble
        End If

        If QuantityRush > 0 Then
            Dim TotalRush As Integer = 70 * QuantityRush
            Dim Orderline As String = QuantityRush.ToString.PadRight(8) & " Rush Classic".PadRight(35) & TotalRush & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalRush
        End If

        If QuantityNormalBurger > 0 Then
            Dim TotalBurger As Integer = 70 * QuantityNormalBurger
            Dim Orderline As String = QuantityNormalBurger.ToString.PadRight(8) & " Bruger".PadRight(39) & TotalBurger & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalBurger
        End If

        If QuantitySoda > 0 Then
            Dim TotalSoda As Integer = 70 * QuantitySoda
            Dim Orderline As String = QuantitySoda.ToString.PadRight(8) & " Classic Soda".PadRight(35) & TotalSoda & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalSoda
        End If

        If QuantityMilk > 0 Then
            Dim TotalMilk As Integer = 70 * QuantityMilk
            Dim Orderline As String = QuantityMilk.ToString.PadRight(8) & " Milkshakes".PadRight(35) & TotalMilk & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalMilk
        End If

        If QuantityLemon > 0 Then
            Dim TotalLemon As Integer = 70 * QuantityLemon
            Dim Orderline As String = QuantityLemon.ToString.PadRight(8) & " Iced Lemonade".PadRight(32) & TotalLemon & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalLemon
        End If

        If QuantityIce > 0 Then
            Dim TotalIce As Integer = 50 * QuantityIce
            Dim Orderline As String = QuantityIce.ToString.PadRight(8) & " Ice Tea".PadRight(40) & TotalIce & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalIce
        End If

        If QuantityGolden > 0 Then
            Dim TotalGolden As Integer = 90 * QuantityGolden
            Dim Orderline As String = QuantityGolden.ToString.PadRight(8) & " Golden Fries".PadRight(35) & TotalGolden & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalGolden
        End If

        If QuantityCheesy > 0 Then
            Dim TotalCheesy As Integer = 90 * QuantityCheesy
            Dim Orderline As String = QuantityCheesy.ToString.PadRight(8) & " Cheesy Fries".PadRight(36) & TotalCheesy & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalCheesy
        End If

        If QuantityOnion > 0 Then
            Dim TotalOnion As Integer = 90 * QuantityOnion
            Dim Orderline As String = QuantityOnion.ToString.PadRight(8) & " Onion Rings".PadRight(34) & TotalOnion & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalOnion
        End If

        If QuantityMozza > 0 Then
            Dim TotalMozza As Integer = 80 * QuantityMozza
            Dim Orderline As String = QuantityMozza.ToString.PadRight(8) & " Mozza Sticks".PadRight(35) & TotalMozza & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalMozza
        End If

        If QuantityFries > 0 Then
            Dim TotalFries As Integer = 70 * QuantityFries
            Dim Orderline As String = QuantityFries.ToString.PadRight(8) & " Fries".PadRight(42) & TotalFries & " ₱"
            Orderlist.Add(Orderline)
            Pricelist += TotalFries
        End If

        For Each Item In Orderlist
            OrderSummary &= Item & vbCrLf
        Next

        OrderSummary &= "----------------------------------------------" & vbCrLf
        OrderSummary &= "Total Price: ".PadRight(46) & Pricelist & "₱"

        Quantity()

        MsgBox("Order Type: " & Form1.OrderType & vbCrLf & "Payment Method: " & PayMethod.PaymentMethod & vbCrLf & vbCrLf & vbCrLf & OrderSummary, MsgBoxStyle.Information, "Order")
        MsgBox("Thank you for order to us", MsgBoxStyle.Information, "Greeting")

        If PayMethod.PaymentMethod = "CASHLESS" Then
            Cashless.Show()
            Me.Hide()
        Else
            Form1.Show()
            Me.Hide()
        End If
        'End If


    End Sub

    Private Sub BtnPlusCrispy_Click_1(sender As Object, e As EventArgs) Handles BtnPlusCrispy.Click
        QuantityCrispy += 1
        TxtQuantityCrispy.Text = QuantityCrispy.ToString
    End Sub

    Private Sub BtnMinusCrispy_Click_1(sender As Object, e As EventArgs) Handles BtnMinusCrispy.Click
        If QuantityCrispy > 0 Then
            QuantityCrispy -= 1
            TxtQuantityCrispy.Text = QuantityCrispy.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusDouble_Click_1(sender As Object, e As EventArgs) Handles BtnPlusDouble.Click
        QuantityDouble += 1
        TxtQuantityDouble.Text = QuantityDouble.ToString
    End Sub

    Private Sub BtnMinusDouble_Click(sender As Object, e As EventArgs) Handles BtnMinusDouble.Click
        If QuantityDouble > 0 Then
            QuantityDouble -= 1
            TxtQuantityDouble.Text = QuantityDouble.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusRush_Click(sender As Object, e As EventArgs) Handles BtnPlusRush.Click
        QuantityRush += 1
        TxtQuantityRush.Text = QuantityRush.ToString
    End Sub

    Private Sub BtnMinusRush_Click(sender As Object, e As EventArgs) Handles BtnMinusRush.Click
        If QuantityRush > 0 Then
            QuantityRush -= 1
            TxtQuantityRush.Text = QuantityRush.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusNormalBurger_Click_1(sender As Object, e As EventArgs) Handles BtnPlusNormalBurger.Click
        QuantityNormalBurger += 1
        TxtQuantityBurger.Text = QuantityNormalBurger.ToString
    End Sub

    Private Sub BtnMinusNormalBurger_Click_1(sender As Object, e As EventArgs) Handles BtnMinusNormalBurger.Click
        QuantityNormalBurger += 1
        TxtQuantityBurger.Text = QuantityNormalBurger.ToString
    End Sub

    Private Sub BtnPlusSoda_Click(sender As Object, e As EventArgs) Handles BtnPlusSoda.Click
        QuantitySoda += 1
        TxtQuantitySoda.Text = QuantitySoda.ToString
    End Sub

    Private Sub BtnMinusSoda_Click(sender As Object, e As EventArgs) Handles BtnMinusSoda.Click
        If QuantitySoda > 0 Then
            QuantitySoda -= 1
            TxtQuantitySoda.Text = QuantitySoda.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusMilk_Click(sender As Object, e As EventArgs) Handles BtnPlusMilk.Click
        QuantityMilk += 1
        TxtQuantityMilkshake.Text = QuantityMilk.ToString
    End Sub

    Private Sub BtnMinusMilk_Click(sender As Object, e As EventArgs) Handles BtnMinusMilk.Click
        If QuantityMilk > 0 Then
            QuantityMilk -= 1
            TxtQuantityMilkshake.Text = QuantityMilk.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusLemon_Click(sender As Object, e As EventArgs) Handles BtnPlusLemon.Click
        QuantityLemon += 1
        TxtQuantityLemon.Text = QuantityLemon.ToString
    End Sub

    Private Sub BtnMinusLemon_Click(sender As Object, e As EventArgs) Handles BtnMinusLemon.Click
        If QuantityLemon > 0 Then
            QuantityLemon -= 1
            TxtQuantityLemon.Text = QuantityLemon.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnPlusIce_Click(sender As Object, e As EventArgs) Handles BtnPlusIce.Click
        QuantityIce += 1
        TxtQuantityIce.Text = QuantityIce.ToString
    End Sub

    Private Sub BtnMinusIcedTea_Click(sender As Object, e As EventArgs) Handles BtnMinusIcedTea.Click
        If QuantityIce > 0 Then
            QuantityIce -= 1
            TxtQuantityIce.Text = QuantityIce.ToString
        Else
            Empty()
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        PayMethod.Show()
        Me.Hide()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Dim Response As MsgBoxResult
        Response = MsgBox("Are you sure to delete you order?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Warning!")
        If Response = MsgBoxResult.Yes Then
            Quantity()
        End If

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelSelectMenu.BringToFront()
    End Sub
End Class