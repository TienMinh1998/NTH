<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BoTriCoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_BoTriCoc))
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbKiemtra = New System.Windows.Forms.Label()
        Me.btn_kiemtra = New System.Windows.Forms.Button()
        Me.txtLd = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_botricoc = New System.Windows.Forms.DataGridView()
        Me.cl_stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_po = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbbSCT = New System.Windows.Forms.ComboBox()
        Me.cbbSococ = New System.Windows.Forms.ComboBox()
        Me.btn_Botricoc = New System.Windows.Forms.Button()
        Me.txtKC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsococsobo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_sct = New System.Windows.Forms.Button()
        Me.txtPspt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPcpt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPvl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_botricoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_luu
        '
        Me.btn_luu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_luu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_luu.Image = CType(resources.GetObject("btn_luu.Image"), System.Drawing.Image)
        Me.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_luu.Location = New System.Drawing.Point(567, 427)
        Me.btn_luu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(130, 47)
        Me.btn_luu.TabIndex = 8
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_luu.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbKiemtra)
        Me.GroupBox4.Controls.Add(Me.btn_kiemtra)
        Me.GroupBox4.Controls.Add(Me.txtLd)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtBd)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(367, 211)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(330, 206)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kích Thước Đài Móng"
        '
        'lbKiemtra
        '
        Me.lbKiemtra.AutoSize = True
        Me.lbKiemtra.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbKiemtra.ForeColor = System.Drawing.Color.Blue
        Me.lbKiemtra.Location = New System.Drawing.Point(16, 139)
        Me.lbKiemtra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbKiemtra.Name = "lbKiemtra"
        Me.lbKiemtra.Size = New System.Drawing.Size(82, 21)
        Me.lbKiemtra.TabIndex = 3
        Me.lbKiemtra.Text = "Kết quả:"
        '
        'btn_kiemtra
        '
        Me.btn_kiemtra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_kiemtra.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_kiemtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_kiemtra.Location = New System.Drawing.Point(211, 39)
        Me.btn_kiemtra.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_kiemtra.Name = "btn_kiemtra"
        Me.btn_kiemtra.Size = New System.Drawing.Size(111, 39)
        Me.btn_kiemtra.TabIndex = 2
        Me.btn_kiemtra.Text = "Kiểm Tra"
        Me.btn_kiemtra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_kiemtra.UseVisualStyleBackColor = False
        '
        'txtLd
        '
        Me.txtLd.Enabled = False
        Me.txtLd.Location = New System.Drawing.Point(69, 74)
        Me.txtLd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLd.Name = "txtLd"
        Me.txtLd.Size = New System.Drawing.Size(68, 22)
        Me.txtLd.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(145, 78)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "m"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 78)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "L ="
        '
        'txtBd
        '
        Me.txtBd.Enabled = False
        Me.txtBd.Location = New System.Drawing.Point(69, 41)
        Me.txtBd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBd.Name = "txtBd"
        Me.txtBd.Size = New System.Drawing.Size(68, 22)
        Me.txtBd.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(144, 44)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "m"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 44)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "B ="
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_botricoc)
        Me.GroupBox3.Location = New System.Drawing.Point(367, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(330, 180)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tải Trọng Tác Dụng Lên Cọc"
        '
        'dgv_botricoc
        '
        Me.dgv_botricoc.AllowUserToAddRows = False
        Me.dgv_botricoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_botricoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl_stt, Me.cl_x, Me.cl_y, Me.cl_p, Me.cl_po})
        Me.dgv_botricoc.Location = New System.Drawing.Point(20, 23)
        Me.dgv_botricoc.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_botricoc.Name = "dgv_botricoc"
        Me.dgv_botricoc.RowHeadersVisible = False
        Me.dgv_botricoc.RowHeadersWidth = 51
        Me.dgv_botricoc.Size = New System.Drawing.Size(302, 148)
        Me.dgv_botricoc.TabIndex = 3
        '
        'cl_stt
        '
        Me.cl_stt.HeaderText = "STT"
        Me.cl_stt.MinimumWidth = 6
        Me.cl_stt.Name = "cl_stt"
        Me.cl_stt.Width = 30
        '
        'cl_x
        '
        Me.cl_x.HeaderText = "X(i)"
        Me.cl_x.MinimumWidth = 6
        Me.cl_x.Name = "cl_x"
        Me.cl_x.Width = 50
        '
        'cl_y
        '
        Me.cl_y.HeaderText = "Y(i)"
        Me.cl_y.MinimumWidth = 6
        Me.cl_y.Name = "cl_y"
        Me.cl_y.Width = 50
        '
        'cl_p
        '
        Me.cl_p.HeaderText = "P(i)"
        Me.cl_p.MinimumWidth = 6
        Me.cl_p.Name = "cl_p"
        Me.cl_p.Width = 60
        '
        'cl_po
        '
        Me.cl_po.HeaderText = "Po(i)"
        Me.cl_po.MinimumWidth = 6
        Me.cl_po.Name = "cl_po"
        Me.cl_po.Width = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbbSCT)
        Me.GroupBox2.Controls.Add(Me.cbbSococ)
        Me.GroupBox2.Controls.Add(Me.btn_Botricoc)
        Me.GroupBox2.Controls.Add(Me.txtKC)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtsococsobo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 211)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(327, 207)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Số Lượng Cọc"
        '
        'cbbSCT
        '
        Me.cbbSCT.FormattingEnabled = True
        Me.cbbSCT.Items.AddRange(New Object() {"Pcpt", "Pspt", "Pvl"})
        Me.cbbSCT.Location = New System.Drawing.Point(190, 25)
        Me.cbbSCT.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbSCT.Name = "cbbSCT"
        Me.cbbSCT.Size = New System.Drawing.Size(93, 24)
        Me.cbbSCT.TabIndex = 4
        '
        'cbbSococ
        '
        Me.cbbSococ.FormattingEnabled = True
        Me.cbbSococ.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8"})
        Me.cbbSococ.Location = New System.Drawing.Point(190, 91)
        Me.cbbSococ.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbSococ.Name = "cbbSococ"
        Me.cbbSococ.Size = New System.Drawing.Size(93, 24)
        Me.cbbSococ.TabIndex = 3
        '
        'btn_Botricoc
        '
        Me.btn_Botricoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Botricoc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_Botricoc.Image = CType(resources.GetObject("btn_Botricoc.Image"), System.Drawing.Image)
        Me.btn_Botricoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Botricoc.Location = New System.Drawing.Point(18, 148)
        Me.btn_Botricoc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Botricoc.Name = "btn_Botricoc"
        Me.btn_Botricoc.Size = New System.Drawing.Size(121, 42)
        Me.btn_Botricoc.TabIndex = 2
        Me.btn_Botricoc.Text = "Bố Trí Cọc"
        Me.btn_Botricoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Botricoc.UseVisualStyleBackColor = False
        '
        'txtKC
        '
        Me.txtKC.Location = New System.Drawing.Point(190, 124)
        Me.txtKC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKC.Name = "txtKC"
        Me.txtKC.Size = New System.Drawing.Size(93, 22)
        Me.txtKC.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 128)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Khoảng Cách Cọc (d):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Số Cọc Chọn:"
        '
        'txtsococsobo
        '
        Me.txtsococsobo.Enabled = False
        Me.txtsococsobo.Location = New System.Drawing.Point(190, 58)
        Me.txtsococsobo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsococsobo.Name = "txtsococsobo"
        Me.txtsococsobo.Size = New System.Drawing.Size(93, 22)
        Me.txtsococsobo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Số Cọc Sơ Bộ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SCT Của Cọc:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_sct)
        Me.GroupBox1.Controls.Add(Me.txtPspt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPcpt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPvl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(328, 180)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sức Chịu Tải"
        '
        'btn_sct
        '
        Me.btn_sct.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_sct.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_sct.Image = CType(resources.GetObject("btn_sct.Image"), System.Drawing.Image)
        Me.btn_sct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sct.Location = New System.Drawing.Point(18, 132)
        Me.btn_sct.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sct.Name = "btn_sct"
        Me.btn_sct.Size = New System.Drawing.Size(121, 39)
        Me.btn_sct.TabIndex = 2
        Me.btn_sct.Text = "Tính SCT"
        Me.btn_sct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sct.UseVisualStyleBackColor = False
        '
        'txtPspt
        '
        Me.txtPspt.Enabled = False
        Me.txtPspt.Location = New System.Drawing.Point(192, 98)
        Me.txtPspt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPspt.Name = "txtPspt"
        Me.txtPspt.Size = New System.Drawing.Size(93, 22)
        Me.txtPspt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sức Chịu Tải Theo SPT:"
        '
        'txtPcpt
        '
        Me.txtPcpt.Enabled = False
        Me.txtPcpt.Location = New System.Drawing.Point(192, 65)
        Me.txtPcpt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPcpt.Name = "txtPcpt"
        Me.txtPcpt.Size = New System.Drawing.Size(93, 22)
        Me.txtPcpt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sức Chịu Tải Theo CPT:"
        '
        'txtPvl
        '
        Me.txtPvl.Enabled = False
        Me.txtPvl.Location = New System.Drawing.Point(192, 32)
        Me.txtPvl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPvl.Name = "txtPvl"
        Me.txtPvl.Size = New System.Drawing.Size(93, 22)
        Me.txtPvl.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(292, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "kN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "kN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "kN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sức Chịu Tải Theo Vật Liệu:"
        '
        'Frm_BoTriCoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 487)
        Me.Controls.Add(Me.btn_luu)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_BoTriCoc"
        Me.Text = "Frm_BoTriCoc"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_botricoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_luu As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbKiemtra As Label
    Friend WithEvents btn_kiemtra As Button
    Friend WithEvents txtLd As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBd As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgv_botricoc As DataGridView
    Friend WithEvents cl_stt As DataGridViewTextBoxColumn
    Friend WithEvents cl_x As DataGridViewTextBoxColumn
    Friend WithEvents cl_y As DataGridViewTextBoxColumn
    Friend WithEvents cl_p As DataGridViewTextBoxColumn
    Friend WithEvents cl_po As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbbSCT As ComboBox
    Friend WithEvents cbbSococ As ComboBox
    Friend WithEvents btn_Botricoc As Button
    Friend WithEvents txtKC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsococsobo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_sct As Button
    Friend WithEvents txtPspt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPcpt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPvl As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
