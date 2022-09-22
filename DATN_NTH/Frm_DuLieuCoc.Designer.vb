<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DuLieuCoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DuLieuCoc))
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbDKthep = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSothanhthep = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLngam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_luu
        '
        Me.btn_luu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_luu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_luu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_luu.Image = CType(resources.GetObject("btn_luu.Image"), System.Drawing.Image)
        Me.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_luu.Location = New System.Drawing.Point(306, 241)
        Me.btn_luu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(101, 42)
        Me.btn_luu.TabIndex = 11
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_luu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbbDKthep)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSothanhthep)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLngam)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(394, 210)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Số Khác Của Cọc"
        '
        'cbbDKthep
        '
        Me.cbbDKthep.FormattingEnabled = True
        Me.cbbDKthep.Items.AddRange(New Object() {"14", "16", "18", "20", "22", "25"})
        Me.cbbDKthep.Location = New System.Drawing.Point(182, 166)
        Me.cbbDKthep.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbDKthep.Name = "cbbDKthep"
        Me.cbbDKthep.Size = New System.Drawing.Size(116, 24)
        Me.cbbDKthep.TabIndex = 2
        Me.cbbDKthep.Text = "16"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Đường kính thép:"
        '
        'txtSothanhthep
        '
        Me.txtSothanhthep.Location = New System.Drawing.Point(182, 133)
        Me.txtSothanhthep.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSothanhthep.Name = "txtSothanhthep"
        Me.txtSothanhthep.Size = New System.Drawing.Size(116, 22)
        Me.txtSothanhthep.TabIndex = 1
        Me.txtSothanhthep.Text = "4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số thanh thép dọc"
        '
        'txtLngam
        '
        Me.txtLngam.Location = New System.Drawing.Point(182, 100)
        Me.txtLngam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLngam.Name = "txtLngam"
        Me.txtLngam.Size = New System.Drawing.Size(116, 22)
        Me.txtLngam.TabIndex = 1
        Me.txtLngam.Text = "0.5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chiều dài cọc ngàm vào đài:"
        '
        'txtLc
        '
        Me.txtLc.Location = New System.Drawing.Point(182, 66)
        Me.txtLc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLc.Name = "txtLc"
        Me.txtLc.Size = New System.Drawing.Size(116, 22)
        Me.txtLc.TabIndex = 1
        Me.txtLc.Text = "13"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chiều dài thực tế của cọc:"
        '
        'txtDc
        '
        Me.txtDc.Location = New System.Drawing.Point(182, 33)
        Me.txtDc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDc.Name = "txtDc"
        Me.txtDc.Size = New System.Drawing.Size(116, 22)
        Me.txtDc.TabIndex = 1
        Me.txtDc.Text = "0.3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "mm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(308, 103)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "m"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "m"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "m"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tiết diện cọc (Dc):"
        '
        'Frm_DuLieuCoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 292)
        Me.Controls.Add(Me.btn_luu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_DuLieuCoc"
        Me.Text = "Frm_DuLieuCoc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_luu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbbDKthep As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSothanhthep As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLngam As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
