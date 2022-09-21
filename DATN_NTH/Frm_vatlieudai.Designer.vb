<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_vatlieudai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_vatlieudai))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbb_thep = New System.Windows.Forms.ComboBox()
        Me.txtEs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRsc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_betong = New System.Windows.Forms.ComboBox()
        Me.txtEb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRbt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbb_thep)
        Me.GroupBox2.Controls.Add(Me.txtEs)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtRsc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtRs)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(237, 193)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vật Liệu Thép"
        '
        'cbb_thep
        '
        Me.cbb_thep.FormattingEnabled = True
        Me.cbb_thep.Items.AddRange(New Object() {"CB240-T", "CB300-V", "CB400-V", "CB500-V"})
        Me.cbb_thep.Location = New System.Drawing.Point(96, 38)
        Me.cbb_thep.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_thep.Name = "cbb_thep"
        Me.cbb_thep.Size = New System.Drawing.Size(76, 24)
        Me.cbb_thep.TabIndex = 2
        Me.cbb_thep.Text = "CB300-V"
        '
        'txtEs
        '
        Me.txtEs.Enabled = False
        Me.txtEs.Location = New System.Drawing.Point(97, 138)
        Me.txtEs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEs.Name = "txtEs"
        Me.txtEs.Size = New System.Drawing.Size(76, 22)
        Me.txtEs.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Es:"
        '
        'txtRsc
        '
        Me.txtRsc.Enabled = False
        Me.txtRsc.Location = New System.Drawing.Point(97, 105)
        Me.txtRsc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRsc.Name = "txtRsc"
        Me.txtRsc.Size = New System.Drawing.Size(76, 22)
        Me.txtRsc.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 108)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Rsc:"
        '
        'txtRs
        '
        Me.txtRs.Enabled = False
        Me.txtRs.Location = New System.Drawing.Point(97, 71)
        Me.txtRs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRs.Name = "txtRs"
        Me.txtRs.Size = New System.Drawing.Size(76, 22)
        Me.txtRs.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Rs:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(182, 142)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "kN/m2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(182, 108)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "kN/m2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(182, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "kN/m2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nhóm Thép:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_betong)
        Me.GroupBox1.Controls.Add(Me.txtEb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRbt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(219, 194)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vật Liệu Bê Tông"
        '
        'cbb_betong
        '
        Me.cbb_betong.FormattingEnabled = True
        Me.cbb_betong.Items.AddRange(New Object() {"B20", "B25", "B30", "B35"})
        Me.cbb_betong.Location = New System.Drawing.Point(72, 38)
        Me.cbb_betong.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_betong.Name = "cbb_betong"
        Me.cbb_betong.Size = New System.Drawing.Size(76, 24)
        Me.cbb_betong.TabIndex = 2
        Me.cbb_betong.Text = "B25"
        '
        'txtEb
        '
        Me.txtEb.Enabled = False
        Me.txtEb.Location = New System.Drawing.Point(72, 138)
        Me.txtEb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEb.Name = "txtEb"
        Me.txtEb.Size = New System.Drawing.Size(76, 22)
        Me.txtEb.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Eb:"
        '
        'txtRbt
        '
        Me.txtRbt.Enabled = False
        Me.txtRbt.Location = New System.Drawing.Point(72, 105)
        Me.txtRbt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRbt.Name = "txtRbt"
        Me.txtRbt.Size = New System.Drawing.Size(76, 22)
        Me.txtRbt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Rbt:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(159, 142)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "kN/m2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 108)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "kN/m2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(159, 75)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "kN/m2"
        '
        'txtRb
        '
        Me.txtRb.Enabled = False
        Me.txtRb.Location = New System.Drawing.Point(72, 71)
        Me.txtRb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRb.Name = "txtRb"
        Me.txtRb.Size = New System.Drawing.Size(76, 22)
        Me.txtRb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rb:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bê Tông:"
        '
        'btn_luu
        '
        Me.btn_luu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_luu.Image = CType(resources.GetObject("btn_luu.Image"), System.Drawing.Image)
        Me.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_luu.Location = New System.Drawing.Point(192, 222)
        Me.btn_luu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(89, 47)
        Me.btn_luu.TabIndex = 8
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'Frm_vatlieudai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 291)
        Me.Controls.Add(Me.btn_luu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_vatlieudai"
        Me.Text = "Khai báo vật liệu làm đài móng"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_luu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbb_thep As ComboBox
    Friend WithEvents txtEs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRsc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbb_betong As ComboBox
    Friend WithEvents txtEb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRbt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
