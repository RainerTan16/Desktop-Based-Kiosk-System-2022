<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayMethod
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayMethod))
        BtnCashless = New Button()
        BtnCash = New Button()
        Label1 = New Label()
        BtnClose = New Button()
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' BtnCashless
        ' 
        BtnCashless.BackColor = Color.White
        BtnCashless.BackgroundImageLayout = ImageLayout.Zoom
        BtnCashless.FlatStyle = FlatStyle.Popup
        BtnCashless.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCashless.Location = New Point(245, 298)
        BtnCashless.Name = "BtnCashless"
        BtnCashless.Size = New Size(106, 43)
        BtnCashless.TabIndex = 5
        BtnCashless.Text = "CASHLESS"
        BtnCashless.UseVisualStyleBackColor = False
        ' 
        ' BtnCash
        ' 
        BtnCash.BackColor = Color.White
        BtnCash.BackgroundImageLayout = ImageLayout.Zoom
        BtnCash.FlatStyle = FlatStyle.Popup
        BtnCash.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCash.Location = New Point(67, 298)
        BtnCash.Name = "BtnCash"
        BtnCash.Size = New Size(106, 43)
        BtnCash.TabIndex = 4
        BtnCash.Text = "CASH"
        BtnCash.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(42, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 32)
        Label1.TabIndex = 3
        Label1.Text = "How would you like to pay"
        ' 
        ' BtnClose
        ' 
        BtnClose.Font = New Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnClose.Location = New Point(378, 0)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(34, 30)
        BtnClose.TabIndex = 6
        BtnClose.Text = "X"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.White
        BtnBack.BackgroundImageLayout = ImageLayout.Zoom
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBack.Location = New Point(346, 432)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(66, 35)
        BtnBack.TabIndex = 7
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' PayMethod
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(412, 468)
        Controls.Add(BtnBack)
        Controls.Add(BtnClose)
        Controls.Add(BtnCashless)
        Controls.Add(BtnCash)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "PayMethod"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PayMethod"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCashless As Button
    Friend WithEvents BtnCash As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnBack As Button
End Class
