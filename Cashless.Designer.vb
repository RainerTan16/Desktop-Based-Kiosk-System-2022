<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashless
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashless))
        BtnPayMaya = New Button()
        BtnGCash = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtnPayMaya
        ' 
        BtnPayMaya.BackgroundImage = CType(resources.GetObject("BtnPayMaya.BackgroundImage"), Image)
        BtnPayMaya.BackgroundImageLayout = ImageLayout.Zoom
        BtnPayMaya.FlatStyle = FlatStyle.Popup
        BtnPayMaya.Location = New Point(233, 193)
        BtnPayMaya.Name = "BtnPayMaya"
        BtnPayMaya.Size = New Size(134, 132)
        BtnPayMaya.TabIndex = 8
        BtnPayMaya.UseVisualStyleBackColor = True
        ' 
        ' BtnGCash
        ' 
        BtnGCash.BackgroundImage = CType(resources.GetObject("BtnGCash.BackgroundImage"), Image)
        BtnGCash.BackgroundImageLayout = ImageLayout.Zoom
        BtnGCash.FlatStyle = FlatStyle.Popup
        BtnGCash.Location = New Point(29, 193)
        BtnGCash.Name = "BtnGCash"
        BtnGCash.Size = New Size(150, 132)
        BtnGCash.TabIndex = 7
        BtnGCash.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(65, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 45)
        Label1.TabIndex = 6
        Label1.Text = "CHOOSE TO PAY"
        ' 
        ' Cashless
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(396, 429)
        Controls.Add(BtnPayMaya)
        Controls.Add(BtnGCash)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Cashless"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cashless"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnPayMaya As Button
    Friend WithEvents BtnGCash As Button
    Friend WithEvents Label1 As Label
End Class
