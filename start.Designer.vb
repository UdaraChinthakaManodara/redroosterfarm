<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_bird_96
        PictureBox1.Location = New Point(152, 89)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(238, 129)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(199, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 22)
        Label1.TabIndex = 1
        Label1.Text = "Red Rooster Farm"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(40, 317)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(482, 12)
        ProgressBar1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 376)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Cursor = Cursors.Arrow
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
