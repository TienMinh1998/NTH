<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DiaChat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DiaChat))
        Me.cl_dungtrongrieng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHsa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHsk = New System.Windows.Forms.TextBox()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.cl_hesoalpha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cl_hesok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbbTrangThai = New System.Windows.Forms.ComboBox()
        Me.cbbLoaiDat = New System.Windows.Forms.ComboBox()
        Me.cl_suckhangxuyen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_doroi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_gocmasat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_modundanhoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_chison = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_chieuday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtN30 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.dgv_diachat = New System.Windows.Forms.DataGridView()
        Me.cl_lopdat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_loaidat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_trangthaidat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDoRoi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGocMS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmodun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDungTrong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtChieuDay = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLopDat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_hoanthanh = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TệpTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_nhapexcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_xuatexcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cl_dungtrongrieng
        '
        Me.cl_dungtrongrieng.HeaderText = "Dung Trọng Riêng"
        Me.cl_dungtrongrieng.MinimumWidth = 6
        Me.cl_dungtrongrieng.Name = "cl_dungtrongrieng"
        Me.cl_dungtrongrieng.ReadOnly = True
        Me.cl_dungtrongrieng.Width = 50
        '
        'txtHsa
        '
        Me.txtHsa.Enabled = False
        Me.txtHsa.Location = New System.Drawing.Point(156, 380)
        Me.txtHsa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHsa.Name = "txtHsa"
        Me.txtHsa.Size = New System.Drawing.Size(88, 22)
        Me.txtHsa.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 384)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Hệ số alpha"
        '
        'txtHsk
        '
        Me.txtHsk.Enabled = False
        Me.txtHsk.Location = New System.Drawing.Point(156, 348)
        Me.txtHsk.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHsk.Name = "txtHsk"
        Me.txtHsk.Size = New System.Drawing.Size(88, 22)
        Me.txtHsk.TabIndex = 1
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_sua.Image = CType(resources.GetObject("btn_sua.Image"), System.Drawing.Image)
        Me.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sua.Location = New System.Drawing.Point(102, 484)
        Me.btn_sua.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(73, 46)
        Me.btn_sua.TabIndex = 5
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_them.Image = CType(resources.GetObject("btn_them.Image"), System.Drawing.Image)
        Me.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_them.Location = New System.Drawing.Point(16, 483)
        Me.btn_them.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(78, 46)
        Me.btn_them.TabIndex = 5
        Me.btn_them.Text = "Thêm"
        Me.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'cl_hesoalpha
        '
        Me.cl_hesoalpha.HeaderText = "alpha"
        Me.cl_hesoalpha.MinimumWidth = 6
        Me.cl_hesoalpha.Name = "cl_hesoalpha"
        Me.cl_hesoalpha.ReadOnly = True
        Me.cl_hesoalpha.Width = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 352)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Hệ số k"
        '
        'cl_hesok
        '
        Me.cl_hesok.HeaderText = "k"
        Me.cl_hesok.MinimumWidth = 6
        Me.cl_hesok.Name = "cl_hesok"
        Me.cl_hesok.ReadOnly = True
        Me.cl_hesok.Width = 40
        '
        'cbbTrangThai
        '
        Me.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTrangThai.FormattingEnabled = True
        Me.cbbTrangThai.Location = New System.Drawing.Point(157, 91)
        Me.cbbTrangThai.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbTrangThai.Name = "cbbTrangThai"
        Me.cbbTrangThai.Size = New System.Drawing.Size(87, 24)
        Me.cbbTrangThai.TabIndex = 2
        '
        'cbbLoaiDat
        '
        Me.cbbLoaiDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbLoaiDat.FormattingEnabled = True
        Me.cbbLoaiDat.Items.AddRange(New Object() {"Sét", "Sét pha", "Cát pha", "Cát", "Cuội sỏi"})
        Me.cbbLoaiDat.Location = New System.Drawing.Point(157, 60)
        Me.cbbLoaiDat.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbLoaiDat.Name = "cbbLoaiDat"
        Me.cbbLoaiDat.Size = New System.Drawing.Size(87, 24)
        Me.cbbLoaiDat.TabIndex = 2
        '
        'cl_suckhangxuyen
        '
        Me.cl_suckhangxuyen.HeaderText = "Sức kháng xuyên"
        Me.cl_suckhangxuyen.MinimumWidth = 6
        Me.cl_suckhangxuyen.Name = "cl_suckhangxuyen"
        Me.cl_suckhangxuyen.ReadOnly = True
        Me.cl_suckhangxuyen.Width = 50
        '
        'cl_doroi
        '
        Me.cl_doroi.HeaderText = "Độ Rời"
        Me.cl_doroi.MinimumWidth = 6
        Me.cl_doroi.Name = "cl_doroi"
        Me.cl_doroi.ReadOnly = True
        Me.cl_doroi.Width = 50
        '
        'cl_gocmasat
        '
        Me.cl_gocmasat.HeaderText = "Góc MS Trong"
        Me.cl_gocmasat.MinimumWidth = 6
        Me.cl_gocmasat.Name = "cl_gocmasat"
        Me.cl_gocmasat.ReadOnly = True
        Me.cl_gocmasat.Width = 50
        '
        'cl_modundanhoi
        '
        Me.cl_modundanhoi.HeaderText = "Modun Đàn Hồi"
        Me.cl_modundanhoi.MinimumWidth = 6
        Me.cl_modundanhoi.Name = "cl_modundanhoi"
        Me.cl_modundanhoi.ReadOnly = True
        Me.cl_modundanhoi.Width = 80
        '
        'cl_chison
        '
        Me.cl_chison.HeaderText = "N"
        Me.cl_chison.MinimumWidth = 6
        Me.cl_chison.Name = "cl_chison"
        Me.cl_chison.ReadOnly = True
        Me.cl_chison.Width = 50
        '
        'cl_chieuday
        '
        Me.cl_chieuday.HeaderText = "Chiều Dày"
        Me.cl_chieuday.MinimumWidth = 6
        Me.cl_chieuday.Name = "cl_chieuday"
        Me.cl_chieuday.ReadOnly = True
        Me.cl_chieuday.Width = 50
        '
        'txtN30
        '
        Me.txtN30.Location = New System.Drawing.Point(156, 316)
        Me.txtN30.Margin = New System.Windows.Forms.Padding(4)
        Me.txtN30.Name = "txtN30"
        Me.txtN30.Size = New System.Drawing.Size(88, 22)
        Me.txtN30.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_diachat)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(362, 49)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(933, 421)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông Số Các Lớp Đất"
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(262, 484)
        Me.btn_xoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(81, 46)
        Me.btn_xoa.TabIndex = 5
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_luu
        '
        Me.btn_luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_luu.Image = CType(resources.GetObject("btn_luu.Image"), System.Drawing.Image)
        Me.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_luu.Location = New System.Drawing.Point(183, 484)
        Me.btn_luu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(71, 46)
        Me.btn_luu.TabIndex = 5
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'dgv_diachat
        '
        Me.dgv_diachat.AllowUserToDeleteRows = False
        Me.dgv_diachat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_diachat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl_lopdat, Me.cl_loaidat, Me.cl_trangthaidat, Me.cl_chieuday, Me.cl_dungtrongrieng, Me.cl_modundanhoi, Me.cl_gocmasat, Me.cl_doroi, Me.cl_suckhangxuyen, Me.cl_chison, Me.cl_hesok, Me.cl_hesoalpha})
        Me.dgv_diachat.Location = New System.Drawing.Point(23, 36)
        Me.dgv_diachat.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_diachat.Name = "dgv_diachat"
        Me.dgv_diachat.ReadOnly = True
        Me.dgv_diachat.RowHeadersVisible = False
        Me.dgv_diachat.RowHeadersWidth = 51
        Me.dgv_diachat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_diachat.Size = New System.Drawing.Size(883, 366)
        Me.dgv_diachat.TabIndex = 4
        '
        'cl_lopdat
        '
        Me.cl_lopdat.HeaderText = "Lớp Đất"
        Me.cl_lopdat.MinimumWidth = 6
        Me.cl_lopdat.Name = "cl_lopdat"
        Me.cl_lopdat.ReadOnly = True
        Me.cl_lopdat.Width = 30
        '
        'cl_loaidat
        '
        Me.cl_loaidat.HeaderText = "Loại Đất"
        Me.cl_loaidat.MinimumWidth = 6
        Me.cl_loaidat.Name = "cl_loaidat"
        Me.cl_loaidat.ReadOnly = True
        Me.cl_loaidat.Width = 80
        '
        'cl_trangthaidat
        '
        Me.cl_trangthaidat.HeaderText = "Trạng Thái"
        Me.cl_trangthaidat.MinimumWidth = 6
        Me.cl_trangthaidat.Name = "cl_trangthaidat"
        Me.cl_trangthaidat.ReadOnly = True
        Me.cl_trangthaidat.Width = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbbTrangThai)
        Me.GroupBox1.Controls.Add(Me.cbbLoaiDat)
        Me.GroupBox1.Controls.Add(Me.txtHsa)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtHsk)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtN30)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtQc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDoRoi)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtGocMS)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtmodun)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDungTrong)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtChieuDay)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLopDat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(333, 422)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập Liệu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 320)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Chỉ số N"
        '
        'txtQc
        '
        Me.txtQc.Location = New System.Drawing.Point(156, 284)
        Me.txtQc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQc.Name = "txtQc"
        Me.txtQc.Size = New System.Drawing.Size(88, 22)
        Me.txtQc.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 288)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sức kháng xuyên"
        '
        'txtDoRoi
        '
        Me.txtDoRoi.Location = New System.Drawing.Point(156, 252)
        Me.txtDoRoi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDoRoi.Name = "txtDoRoi"
        Me.txtDoRoi.Size = New System.Drawing.Size(88, 22)
        Me.txtDoRoi.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 256)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Độ rời"
        '
        'txtGocMS
        '
        Me.txtGocMS.Location = New System.Drawing.Point(156, 220)
        Me.txtGocMS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGocMS.Name = "txtGocMS"
        Me.txtGocMS.Size = New System.Drawing.Size(88, 22)
        Me.txtGocMS.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 224)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Góc ma sát trong"
        '
        'txtmodun
        '
        Me.txtmodun.Location = New System.Drawing.Point(156, 188)
        Me.txtmodun.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmodun.Name = "txtmodun"
        Me.txtmodun.Size = New System.Drawing.Size(88, 22)
        Me.txtmodun.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Modun đàn hồi"
        '
        'txtDungTrong
        '
        Me.txtDungTrong.Location = New System.Drawing.Point(156, 156)
        Me.txtDungTrong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDungTrong.Name = "txtDungTrong"
        Me.txtDungTrong.Size = New System.Drawing.Size(88, 22)
        Me.txtDungTrong.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dung trọng riêng"
        '
        'txtChieuDay
        '
        Me.txtChieuDay.Location = New System.Drawing.Point(156, 124)
        Me.txtChieuDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChieuDay.Name = "txtChieuDay"
        Me.txtChieuDay.Size = New System.Drawing.Size(88, 22)
        Me.txtChieuDay.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(253, 288)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "kN/m2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(253, 256)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "kN/m2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(253, 224)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "độ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(253, 192)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "kN/m2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(253, 160)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "kN/m3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(253, 128)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "m"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Chiều dày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Trạng thái đất"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Loại đất"
        '
        'txtLopDat
        '
        Me.txtLopDat.Enabled = False
        Me.txtLopDat.Location = New System.Drawing.Point(156, 28)
        Me.txtLopDat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLopDat.Name = "txtLopDat"
        Me.txtLopDat.Size = New System.Drawing.Size(88, 22)
        Me.txtLopDat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lớp đất"
        '
        'btn_hoanthanh
        '
        Me.btn_hoanthanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_hoanthanh.Image = CType(resources.GetObject("btn_hoanthanh.Image"), System.Drawing.Image)
        Me.btn_hoanthanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hoanthanh.Location = New System.Drawing.Point(1112, 483)
        Me.btn_hoanthanh.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_hoanthanh.Name = "btn_hoanthanh"
        Me.btn_hoanthanh.Size = New System.Drawing.Size(145, 47)
        Me.btn_hoanthanh.TabIndex = 9
        Me.btn_hoanthanh.Text = "Hoàn Thành"
        Me.btn_hoanthanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hoanthanh.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TệpTinToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1291, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TệpTinToolStripMenuItem
        '
        Me.TệpTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nhapexcel, Me.btn_xuatexcel})
        Me.TệpTinToolStripMenuItem.Image = CType(resources.GetObject("TệpTinToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TệpTinToolStripMenuItem.Name = "TệpTinToolStripMenuItem"
        Me.TệpTinToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.TệpTinToolStripMenuItem.Text = "Tệp tin"
        '
        'btn_nhapexcel
        '
        Me.btn_nhapexcel.Image = CType(resources.GetObject("btn_nhapexcel.Image"), System.Drawing.Image)
        Me.btn_nhapexcel.Name = "btn_nhapexcel"
        Me.btn_nhapexcel.Size = New System.Drawing.Size(224, 26)
        Me.btn_nhapexcel.Text = "Nhập Excel"
        '
        'btn_xuatexcel
        '
        Me.btn_xuatexcel.Image = CType(resources.GetObject("btn_xuatexcel.Image"), System.Drawing.Image)
        Me.btn_xuatexcel.Name = "btn_xuatexcel"
        Me.btn_xuatexcel.Size = New System.Drawing.Size(224, 26)
        Me.btn_xuatexcel.Text = "Xuất Excel"
        '
        'Frm_DiaChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 543)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_luu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_hoanthanh)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frm_DiaChat"
        Me.Text = "Nhập Địa Chất"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cl_dungtrongrieng As DataGridViewTextBoxColumn
    Friend WithEvents txtHsa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHsk As TextBox
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_them As Button
    Friend WithEvents cl_hesoalpha As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents cl_hesok As DataGridViewTextBoxColumn
    Friend WithEvents cbbTrangThai As ComboBox
    Friend WithEvents cbbLoaiDat As ComboBox
    Friend WithEvents cl_suckhangxuyen As DataGridViewTextBoxColumn
    Friend WithEvents cl_doroi As DataGridViewTextBoxColumn
    Friend WithEvents cl_gocmasat As DataGridViewTextBoxColumn
    Friend WithEvents cl_modundanhoi As DataGridViewTextBoxColumn
    Friend WithEvents cl_chison As DataGridViewTextBoxColumn
    Friend WithEvents cl_chieuday As DataGridViewTextBoxColumn
    Friend WithEvents txtN30 As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_luu As Button
    Friend WithEvents dgv_diachat As DataGridView
    Friend WithEvents cl_lopdat As DataGridViewTextBoxColumn
    Friend WithEvents cl_loaidat As DataGridViewTextBoxColumn
    Friend WithEvents cl_trangthaidat As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtQc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDoRoi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGocMS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmodun As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDungTrong As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtChieuDay As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLopDat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_hoanthanh As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TệpTinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_nhapexcel As ToolStripMenuItem
    Friend WithEvents btn_xuatexcel As ToolStripMenuItem
End Class
