<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        BtnTakeOut = New Button()
        BtnDineIn = New Button()
        PictureBox2 = New PictureBox()
        BtnClose = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(105, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 34)
        Label1.TabIndex = 7
        Label1.Text = "Dining Location"
        ' 
        ' BtnTakeOut
        ' 
        BtnTakeOut.BackColor = Color.White
        BtnTakeOut.BackgroundImageLayout = ImageLayout.Zoom
        BtnTakeOut.FlatStyle = FlatStyle.Popup
        BtnTakeOut.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnTakeOut.Location = New Point(256, 310)
        BtnTakeOut.Name = "BtnTakeOut"
        BtnTakeOut.Size = New Size(101, 43)
        BtnTakeOut.TabIndex = 6
        BtnTakeOut.Text = "TAKE OUT"
        BtnTakeOut.UseVisualStyleBackColor = False
        ' 
        ' BtnDineIn
        ' 
        BtnDineIn.BackColor = Color.White
        BtnDineIn.BackgroundImageLayout = ImageLayout.None
        BtnDineIn.FlatStyle = FlatStyle.Popup
        BtnDineIn.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDineIn.Location = New Point(49, 310)
        BtnDineIn.Name = "BtnDineIn"
        BtnDineIn.Size = New Size(106, 43)
        BtnDineIn.TabIndex = 5
        BtnDineIn.Text = "DINE IN"
        BtnDineIn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(150, 55)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(107, 105)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' BtnClose
        ' 
        BtnClose.Font = New Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnClose.Location = New Point(379, 0)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(33, 31)
        BtnClose.TabIndex = 8
        BtnClose.Text = "X"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(412, 468)
        Controls.Add(BtnClose)
        Controls.Add(Label1)
        Controls.Add(BtnTakeOut)
        Controls.Add(BtnDineIn)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dining  Location"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTakeOut As Button
    Friend WithEvents BtnDineIn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnClose As Button

End Class
