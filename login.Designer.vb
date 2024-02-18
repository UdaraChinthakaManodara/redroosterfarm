<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        untxt = New TextBox()
        pswtxt = New TextBox()
        logintxt = New Button()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_login_96
        PictureBox1.Location = New Point(171, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(99, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(91, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 18)
        Label1.TabIndex = 1
        Label1.Text = "User Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(91, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 18)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' untxt
        ' 
        untxt.Location = New Point(91, 223)
        untxt.Name = "untxt"
        untxt.Size = New Size(259, 27)
        untxt.TabIndex = 3
        ' 
        ' pswtxt
        ' 
        pswtxt.Location = New Point(91, 307)
        pswtxt.Name = "pswtxt"
        pswtxt.Size = New Size(259, 27)
        pswtxt.TabIndex = 4
        ' 
        ' logintxt
        ' 
        logintxt.BackColor = Color.Red
        logintxt.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        logintxt.ForeColor = SystemColors.Control
        logintxt.Location = New Point(91, 382)
        logintxt.Name = "logintxt"
        logintxt.Size = New Size(259, 41)
        logintxt.TabIndex = 5
        logintxt.Text = "Login"
        logintxt.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(186, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 36)
        Label3.TabIndex = 6
        Label3.Text = "Login"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(451, 513)
        Controls.Add(Label3)
        Controls.Add(logintxt)
        Controls.Add(pswtxt)
        Controls.Add(untxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents untxt As TextBox
    Friend WithEvents pswtxt As TextBox
    Friend WithEvents logintxt As Button
    Friend WithEvents Label3 As Label
End Class
