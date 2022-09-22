<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NoiLuc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_NoiLuc))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHSantoan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMy = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.dgv_diachat = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_load_excel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHSantoan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtQy)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQx)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMy)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMx)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtN)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(309, 252)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nội Lực Tính Toán"
        '
        'txtHSantoan
        '
        Me.txtHSantoan.Location = New System.Drawing.Point(127, 199)
        Me.txtHSantoan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHSantoan.Name = "txtHSantoan"
        Me.txtHSantoan.Size = New System.Drawing.Size(116, 22)
        Me.txtHSantoan.TabIndex = 1
        Me.txtHSantoan.Text = "1.15"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 203)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Hệ số an toàn:"
        '
        'txtQy
        '
        Me.txtQy.Location = New System.Drawing.Point(127, 166)
        Me.txtQy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQy.Name = "txtQy"
        Me.txtQy.Size = New System.Drawing.Size(116, 22)
        Me.txtQy.TabIndex = 1
        Me.txtQy.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Qy:"
        '
        'txtQx
        '
        Me.txtQx.Location = New System.Drawing.Point(127, 133)
        Me.txtQx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQx.Name = "txtQx"
        Me.txtQx.Size = New System.Drawing.Size(116, 22)
        Me.txtQx.TabIndex = 1
        Me.txtQx.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Qx:"
        '
        'txtMy
        '
        Me.txtMy.Location = New System.Drawing.Point(127, 100)
        Me.txtMy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMy.Name = "txtMy"
        Me.txtMy.Size = New System.Drawing.Size(116, 22)
        Me.txtMy.TabIndex = 1
        Me.txtMy.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "My:"
        '
        'txtMx
        '
        Me.txtMx.Location = New System.Drawing.Point(127, 66)
        Me.txtMx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMx.Name = "txtMx"
        Me.txtMx.Size = New System.Drawing.Size(116, 22)
        Me.txtMx.TabIndex = 1
        Me.txtMx.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mx:"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(127, 33)
        Me.txtN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(116, 22)
        Me.txtN.TabIndex = 1
        Me.txtN.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 103)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "kN.m"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "kN.m"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(253, 170)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "kN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(253, 137)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "kN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "kN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N:"
        '
        'btn_luu
        '
        Me.btn_luu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_luu.Enabled = False
        Me.btn_luu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_luu.Image = CType(resources.GetObject("btn_luu.Image"), System.Drawing.Image)
        Me.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_luu.Location = New System.Drawing.Point(13, 285)
        Me.btn_luu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(146, 42)
        Me.btn_luu.TabIndex = 5
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_luu.UseVisualStyleBackColor = False
        '
        'dgv_diachat
        '
        Me.dgv_diachat.AllowUserToAddRows = False
        Me.dgv_diachat.AllowUserToDeleteRows = False
        Me.dgv_diachat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_diachat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_diachat.Location = New System.Drawing.Point(340, 32)
        Me.dgv_diachat.Name = "dgv_diachat"
        Me.dgv_diachat.ReadOnly = True
        Me.dgv_diachat.RowHeadersWidth = 51
        Me.dgv_diachat.RowTemplate.Height = 24
        Me.dgv_diachat.Size = New System.Drawing.Size(944, 242)
        Me.dgv_diachat.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Fz(Max)"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Mx(Max)"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "My(Max)"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fx(Max)"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fy(Max)"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'btn_load_excel
        '
        Me.btn_load_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_load_excel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_load_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_load_excel.Location = New System.Drawing.Point(167, 285)
        Me.btn_load_excel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_load_excel.Name = "btn_load_excel"
        Me.btn_load_excel.Size = New System.Drawing.Size(155, 42)
        Me.btn_load_excel.TabIndex = 5
        Me.btn_load_excel.Text = "Load File ExCel"
        Me.btn_load_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_load_excel.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Frm_NoiLuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 342)
        Me.Controls.Add(Me.dgv_diachat)
        Me.Controls.Add(Me.btn_load_excel)
        Me.Controls.Add(Me.btn_luu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_NoiLuc"
        Me.Text = "Nhập nội lực"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_luu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHSantoan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMy As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_diachat As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btn_load_excel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
