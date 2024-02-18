<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
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
        Panel1 = New Panel()
        Label7 = New Label()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        exptxt = New Label()
        proname_txt = New Label()
        Label12 = New Label()
        Label14 = New Label()
        protype_cmb = New ComboBox()
        proname_cmb = New ComboBox()
        quantitycmb = New NumericUpDown()
        costtxt = New TextBox()
        expd_txt = New DateTimePicker()
        reftxt = New ComboBox()
        addbtn = New Button()
        editbtn = New Button()
        delbtn = New Button()
        stockDataGridView = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(quantitycmb, ComponentModel.ISupportInitialize).BeginInit()
        CType(stockDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(238, 627)
        Panel1.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(88, 561)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 23)
        Label7.TabIndex = 12
        Label7.Text = "Logout"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.icons8_login_961
        PictureBox7.Location = New Point(48, 557)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(34, 28)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 11
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.icons8_kawaii_coffee_50
        PictureBox6.Location = New Point(48, 430)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(25, 29)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 10
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.icons8_sales_30
        PictureBox5.Location = New Point(48, 363)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(25, 29)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icons8_delivery_50
        PictureBox4.Location = New Point(48, 299)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 29)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_order_30
        PictureBox3.Location = New Point(48, 235)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_employee_24
        PictureBox2.Location = New Point(48, 171)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(79, 435)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 24)
        Label6.TabIndex = 6
        Label6.Text = "Production"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(79, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 24)
        Label5.TabIndex = 5
        Label5.Text = "Sells"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(79, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 24)
        Label4.TabIndex = 4
        Label4.Text = "Orders"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(79, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 24)
        Label3.TabIndex = 3
        Label3.Text = "Delivery "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(79, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 24)
        Label2.TabIndex = 2
        Label2.Text = "Employee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_bird_96
        PictureBox1.Location = New Point(48, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(108, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(529, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 31)
        Label1.TabIndex = 5
        Label1.Text = "Red Rooster Farm"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(327, 99)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 19)
        Label8.TabIndex = 6
        Label8.Text = "Production Type"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(890, 99)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 19)
        Label9.TabIndex = 31
        Label9.Text = "Quantity"
        ' 
        ' exptxt
        ' 
        exptxt.AutoSize = True
        exptxt.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        exptxt.Location = New Point(610, 203)
        exptxt.Name = "exptxt"
        exptxt.Size = New Size(96, 19)
        exptxt.TabIndex = 32
        exptxt.Text = "Expire Date"
        ' 
        ' proname_txt
        ' 
        proname_txt.AutoSize = True
        proname_txt.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        proname_txt.Location = New Point(591, 99)
        proname_txt.Name = "proname_txt"
        proname_txt.Size = New Size(143, 19)
        proname_txt.TabIndex = 33
        proname_txt.Text = "Production Name"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(361, 203)
        Label12.Name = "Label12"
        Label12.Size = New Size(42, 19)
        Label12.TabIndex = 34
        Label12.Text = "Cost"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(846, 203)
        Label14.Name = "Label14"
        Label14.Size = New Size(89, 19)
        Label14.TabIndex = 36
        Label14.Text = "Ref Officer"
        ' 
        ' protype_cmb
        ' 
        protype_cmb.FormattingEnabled = True
        protype_cmb.Location = New Point(331, 138)
        protype_cmb.Name = "protype_cmb"
        protype_cmb.Size = New Size(118, 28)
        protype_cmb.TabIndex = 37
        ' 
        ' proname_cmb
        ' 
        proname_cmb.FormattingEnabled = True
        proname_cmb.Location = New Point(601, 138)
        proname_cmb.Name = "proname_cmb"
        proname_cmb.Size = New Size(116, 28)
        proname_cmb.TabIndex = 38
        ' 
        ' quantitycmb
        ' 
        quantitycmb.Location = New Point(873, 138)
        quantitycmb.Name = "quantitycmb"
        quantitycmb.Size = New Size(112, 27)
        quantitycmb.TabIndex = 39
        ' 
        ' costtxt
        ' 
        costtxt.Location = New Point(331, 235)
        costtxt.Name = "costtxt"
        costtxt.Size = New Size(118, 27)
        costtxt.TabIndex = 40
        ' 
        ' expd_txt
        ' 
        expd_txt.Location = New Point(601, 233)
        expd_txt.Name = "expd_txt"
        expd_txt.Size = New Size(116, 27)
        expd_txt.TabIndex = 41
        ' 
        ' reftxt
        ' 
        reftxt.FormattingEnabled = True
        reftxt.Items.AddRange(New Object() {"officer_01", "officer_02", "officer_03", "officer_04", "officer_05"})
        reftxt.Location = New Point(874, 234)
        reftxt.Name = "reftxt"
        reftxt.Size = New Size(111, 28)
        reftxt.TabIndex = 42
        ' 
        ' addbtn
        ' 
        addbtn.BackColor = Color.Navy
        addbtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addbtn.ForeColor = Color.White
        addbtn.Location = New Point(327, 553)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(156, 31)
        addbtn.TabIndex = 43
        addbtn.Text = "Add"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' editbtn
        ' 
        editbtn.BackColor = Color.Green
        editbtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        editbtn.ForeColor = Color.White
        editbtn.Location = New Point(578, 553)
        editbtn.Name = "editbtn"
        editbtn.Size = New Size(156, 31)
        editbtn.TabIndex = 44
        editbtn.Text = "Edit"
        editbtn.UseVisualStyleBackColor = False
        ' 
        ' delbtn
        ' 
        delbtn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        delbtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        delbtn.ForeColor = Color.White
        delbtn.Location = New Point(829, 553)
        delbtn.Name = "delbtn"
        delbtn.Size = New Size(156, 31)
        delbtn.TabIndex = 45
        delbtn.Text = "Delete"
        delbtn.UseVisualStyleBackColor = False
        ' 
        ' stockDataGridView
        ' 
        stockDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        stockDataGridView.Location = New Point(327, 289)
        stockDataGridView.Name = "stockDataGridView"
        stockDataGridView.RowHeadersWidth = 51
        stockDataGridView.RowTemplate.Height = 29
        stockDataGridView.Size = New Size(658, 234)
        stockDataGridView.TabIndex = 46
        ' 
        ' stock
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1070, 627)
        Controls.Add(stockDataGridView)
        Controls.Add(delbtn)
        Controls.Add(editbtn)
        Controls.Add(addbtn)
        Controls.Add(reftxt)
        Controls.Add(expd_txt)
        Controls.Add(costtxt)
        Controls.Add(quantitycmb)
        Controls.Add(proname_cmb)
        Controls.Add(protype_cmb)
        Controls.Add(Label14)
        Controls.Add(Label12)
        Controls.Add(proname_txt)
        Controls.Add(exptxt)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "stock"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(quantitycmb, ComponentModel.ISupportInitialize).EndInit()
        CType(stockDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents exptxt As Label
    Friend WithEvents proname_txt As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents protype_cmb As ComboBox
    Friend WithEvents proname_cmb As ComboBox
    Friend WithEvents quantitycmb As NumericUpDown
    Friend WithEvents costtxt As TextBox
    Friend WithEvents expd_txt As DateTimePicker
    Friend WithEvents reftxt As ComboBox
    Friend WithEvents addbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents stockDataGridView As DataGridView
End Class
