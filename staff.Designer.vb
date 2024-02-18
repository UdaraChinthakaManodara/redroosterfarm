<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
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
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        st_fname = New TextBox()
        st_Lname = New TextBox()
        st_addrs = New TextBox()
        st_con = New TextBox()
        st_sal = New TextBox()
        st_gencmb = New ComboBox()
        st_depcmb = New ComboBox()
        st_dob = New DateTimePicker()
        addbtn = New Button()
        editbtn = New Button()
        delbtn = New Button()
        st_age = New NumericUpDown()
        stfDataGridView = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(st_age, ComponentModel.ISupportInitialize).BeginInit()
        CType(stfDataGridView, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Location = New Point(504, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 31)
        Label1.TabIndex = 5
        Label1.Text = "Red Rooster Farm"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(308, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 19)
        Label8.TabIndex = 7
        Label8.Text = "First Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(599, 104)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 19)
        Label9.TabIndex = 8
        Label9.Text = "Last Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(879, 104)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 19)
        Label10.TabIndex = 9
        Label10.Text = "Date Of Birth"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(317, 181)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 19)
        Label11.TabIndex = 10
        Label11.Text = "Gender"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(610, 176)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 19)
        Label12.TabIndex = 11
        Label12.Text = "Address"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(611, 261)
        Label13.Name = "Label13"
        Label13.Size = New Size(68, 19)
        Label13.TabIndex = 12
        Label13.Text = "Contact"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(317, 261)
        Label14.Name = "Label14"
        Label14.Size = New Size(101, 19)
        Label14.TabIndex = 13
        Label14.Text = "Department"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(906, 176)
        Label15.Name = "Label15"
        Label15.Size = New Size(39, 19)
        Label15.TabIndex = 14
        Label15.Text = "Age"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(906, 261)
        Label16.Name = "Label16"
        Label16.Size = New Size(55, 19)
        Label16.TabIndex = 15
        Label16.Text = "Salary"
        ' 
        ' st_fname
        ' 
        st_fname.Location = New Point(287, 126)
        st_fname.Name = "st_fname"
        st_fname.Size = New Size(151, 27)
        st_fname.TabIndex = 30
        ' 
        ' st_Lname
        ' 
        st_Lname.Location = New Point(574, 128)
        st_Lname.Name = "st_Lname"
        st_Lname.Size = New Size(151, 27)
        st_Lname.TabIndex = 31
        ' 
        ' st_addrs
        ' 
        st_addrs.Location = New Point(574, 203)
        st_addrs.Name = "st_addrs"
        st_addrs.Size = New Size(151, 27)
        st_addrs.TabIndex = 32
        ' 
        ' st_con
        ' 
        st_con.Location = New Point(574, 283)
        st_con.Name = "st_con"
        st_con.Size = New Size(151, 27)
        st_con.TabIndex = 34
        ' 
        ' st_sal
        ' 
        st_sal.Location = New Point(847, 283)
        st_sal.Name = "st_sal"
        st_sal.Size = New Size(159, 27)
        st_sal.TabIndex = 35
        ' 
        ' st_gencmb
        ' 
        st_gencmb.FormattingEnabled = True
        st_gencmb.Items.AddRange(New Object() {"Male", "Female"})
        st_gencmb.Location = New Point(287, 202)
        st_gencmb.Name = "st_gencmb"
        st_gencmb.Size = New Size(151, 28)
        st_gencmb.TabIndex = 36
        ' 
        ' st_depcmb
        ' 
        st_depcmb.FormattingEnabled = True
        st_depcmb.Items.AddRange(New Object() {"production", "delivary"})
        st_depcmb.Location = New Point(287, 283)
        st_depcmb.Name = "st_depcmb"
        st_depcmb.Size = New Size(151, 28)
        st_depcmb.TabIndex = 37
        ' 
        ' st_dob
        ' 
        st_dob.Location = New Point(847, 126)
        st_dob.Name = "st_dob"
        st_dob.Size = New Size(159, 27)
        st_dob.TabIndex = 38
        ' 
        ' addbtn
        ' 
        addbtn.BackColor = Color.Navy
        addbtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addbtn.ForeColor = Color.White
        addbtn.Location = New Point(287, 361)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(156, 31)
        addbtn.TabIndex = 39
        addbtn.Text = "Add"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' editbtn
        ' 
        editbtn.BackColor = Color.Green
        editbtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        editbtn.ForeColor = Color.White
        editbtn.Location = New Point(574, 361)
        editbtn.Name = "editbtn"
        editbtn.Size = New Size(156, 31)
        editbtn.TabIndex = 40
        editbtn.Text = "Edit"
        editbtn.UseVisualStyleBackColor = False
        ' 
        ' delbtn
        ' 
        delbtn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        delbtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        delbtn.ForeColor = Color.White
        delbtn.Location = New Point(849, 361)
        delbtn.Name = "delbtn"
        delbtn.Size = New Size(156, 31)
        delbtn.TabIndex = 41
        delbtn.Text = "Delete"
        delbtn.UseVisualStyleBackColor = False
        ' 
        ' st_age
        ' 
        st_age.Location = New Point(847, 204)
        st_age.Name = "st_age"
        st_age.Size = New Size(159, 27)
        st_age.TabIndex = 42
        st_age.TextAlign = HorizontalAlignment.Center
        st_age.Value = New Decimal(New Integer() {18, 0, 0, 0})
        ' 
        ' stfDataGridView
        ' 
        stfDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        stfDataGridView.Location = New Point(287, 412)
        stfDataGridView.Name = "stfDataGridView"
        stfDataGridView.RowHeadersWidth = 51
        stfDataGridView.RowTemplate.Height = 29
        stfDataGridView.Size = New Size(719, 183)
        stfDataGridView.TabIndex = 43
        ' 
        ' staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1070, 627)
        Controls.Add(stfDataGridView)
        Controls.Add(st_age)
        Controls.Add(delbtn)
        Controls.Add(editbtn)
        Controls.Add(addbtn)
        Controls.Add(st_dob)
        Controls.Add(st_depcmb)
        Controls.Add(st_gencmb)
        Controls.Add(st_sal)
        Controls.Add(st_con)
        Controls.Add(st_addrs)
        Controls.Add(st_Lname)
        Controls.Add(st_fname)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "staff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "staff"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(st_age, ComponentModel.ISupportInitialize).EndInit()
        CType(stfDataGridView, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents st_fname As TextBox
    Friend WithEvents st_Lname As TextBox
    Friend WithEvents st_addrs As TextBox
    Friend WithEvents st_con As TextBox
    Friend WithEvents st_sal As TextBox
    Friend WithEvents st_gencmb As ComboBox
    Friend WithEvents st_depcmb As ComboBox
    Friend WithEvents st_dob As DateTimePicker
    Friend WithEvents addbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents st_age As NumericUpDown
    Friend WithEvents stfDataGridView As DataGridView
End Class
