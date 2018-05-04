<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.top_panel = New System.Windows.Forms.Panel()
        Me.quater_cb = New System.Windows.Forms.CheckBox()
        Me.reset_btn = New System.Windows.Forms.Button()
        Me.GenMask_cb = New System.Windows.Forms.CheckBox()
        Me.mask_tb = New System.Windows.Forms.TextBox()
        Me.multiply_cb = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.fill_alpha_cb = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_alpha = New System.Windows.Forms.Button()
        Me.b_blue = New System.Windows.Forms.Button()
        Me.b_green = New System.Windows.Forms.Button()
        Me.b_red = New System.Windows.Forms.Button()
        Me.convert_rgb_NM_cb = New System.Windows.Forms.CheckBox()
        Me.alpha_blend_cb = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.show_mask_rb = New System.Windows.Forms.RadioButton()
        Me.output_rb = New System.Windows.Forms.RadioButton()
        Me.source_rb = New System.Windows.Forms.RadioButton()
        Me.scale_up_btn = New System.Windows.Forms.Button()
        Me.zoom = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scale_down_btn = New System.Windows.Forms.Button()
        Me.alpha_group = New System.Windows.Forms.GroupBox()
        Me.a_r = New System.Windows.Forms.RadioButton()
        Me.a_a = New System.Windows.Forms.RadioButton()
        Me.a_b = New System.Windows.Forms.RadioButton()
        Me.a_g = New System.Windows.Forms.RadioButton()
        Me.blue_group = New System.Windows.Forms.GroupBox()
        Me.b_a = New System.Windows.Forms.RadioButton()
        Me.b_b = New System.Windows.Forms.RadioButton()
        Me.b_g = New System.Windows.Forms.RadioButton()
        Me.b_r = New System.Windows.Forms.RadioButton()
        Me.green_group = New System.Windows.Forms.GroupBox()
        Me.g_a = New System.Windows.Forms.RadioButton()
        Me.g_b = New System.Windows.Forms.RadioButton()
        Me.g_g = New System.Windows.Forms.RadioButton()
        Me.g_r = New System.Windows.Forms.RadioButton()
        Me.red_group = New System.Windows.Forms.GroupBox()
        Me.r_a = New System.Windows.Forms.RadioButton()
        Me.r_b = New System.Windows.Forms.RadioButton()
        Me.r_g = New System.Windows.Forms.RadioButton()
        Me.r_r = New System.Windows.Forms.RadioButton()
        Me.mask_alpha_blend_cb = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.m_alpha_cb = New System.Windows.Forms.CheckBox()
        Me.m_blue_cb = New System.Windows.Forms.CheckBox()
        Me.m_green_cb = New System.Windows.Forms.CheckBox()
        Me.m_red_cb = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sub_rb = New System.Windows.Forms.RadioButton()
        Me.mask_invert_rb = New System.Windows.Forms.RadioButton()
        Me.mask_rb = New System.Windows.Forms.RadioButton()
        Me.add_rb = New System.Windows.Forms.RadioButton()
        Me.mask_cb = New System.Windows.Forms.CheckBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_open = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_mask = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_save = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_edit_shaders = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_combiner = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_top_most = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pb3 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.m_flip_y_cb = New System.Windows.Forms.CheckBox()
        Me.m_flip_x_cb = New System.Windows.Forms.CheckBox()
        Me.top_panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.alpha_group.SuspendLayout()
        Me.blue_group.SuspendLayout()
        Me.green_group.SuspendLayout()
        Me.red_group.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.pb3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'top_panel
        '
        Me.top_panel.BackColor = System.Drawing.Color.Silver
        Me.top_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.top_panel.Controls.Add(Me.Panel2)
        Me.top_panel.Controls.Add(Me.quater_cb)
        Me.top_panel.Controls.Add(Me.reset_btn)
        Me.top_panel.Controls.Add(Me.GenMask_cb)
        Me.top_panel.Controls.Add(Me.mask_tb)
        Me.top_panel.Controls.Add(Me.multiply_cb)
        Me.top_panel.Controls.Add(Me.ComboBox1)
        Me.top_panel.Controls.Add(Me.fill_alpha_cb)
        Me.top_panel.Controls.Add(Me.Label1)
        Me.top_panel.Controls.Add(Me.b_alpha)
        Me.top_panel.Controls.Add(Me.b_blue)
        Me.top_panel.Controls.Add(Me.b_green)
        Me.top_panel.Controls.Add(Me.b_red)
        Me.top_panel.Controls.Add(Me.alpha_blend_cb)
        Me.top_panel.Controls.Add(Me.GroupBox1)
        Me.top_panel.Controls.Add(Me.scale_up_btn)
        Me.top_panel.Controls.Add(Me.zoom)
        Me.top_panel.Controls.Add(Me.Label2)
        Me.top_panel.Controls.Add(Me.scale_down_btn)
        Me.top_panel.Controls.Add(Me.alpha_group)
        Me.top_panel.Controls.Add(Me.blue_group)
        Me.top_panel.Controls.Add(Me.green_group)
        Me.top_panel.Controls.Add(Me.red_group)
        Me.top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.top_panel.Location = New System.Drawing.Point(0, 24)
        Me.top_panel.Name = "top_panel"
        Me.top_panel.Size = New System.Drawing.Size(873, 105)
        Me.top_panel.TabIndex = 1
        '
        'quater_cb
        '
        Me.quater_cb.Appearance = System.Windows.Forms.Appearance.Button
        Me.quater_cb.Location = New System.Drawing.Point(108, 76)
        Me.quater_cb.Name = "quater_cb"
        Me.quater_cb.Size = New System.Drawing.Size(93, 24)
        Me.quater_cb.TabIndex = 29
        Me.quater_cb.Text = "Save 1/4 Size"
        Me.quater_cb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.quater_cb.UseVisualStyleBackColor = True
        '
        'reset_btn
        '
        Me.reset_btn.Location = New System.Drawing.Point(9, 77)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.Size = New System.Drawing.Size(75, 23)
        Me.reset_btn.TabIndex = 28
        Me.reset_btn.Text = "Reset Routing"
        Me.reset_btn.UseVisualStyleBackColor = True
        '
        'GenMask_cb
        '
        Me.GenMask_cb.AutoSize = True
        Me.GenMask_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenMask_cb.Location = New System.Drawing.Point(650, 23)
        Me.GenMask_cb.Name = "GenMask_cb"
        Me.GenMask_cb.Size = New System.Drawing.Size(83, 17)
        Me.GenMask_cb.TabIndex = 27
        Me.GenMask_cb.Text = "Gen Mask"
        Me.GenMask_cb.UseVisualStyleBackColor = True
        '
        'mask_tb
        '
        Me.mask_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mask_tb.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mask_tb.Location = New System.Drawing.Point(583, 74)
        Me.mask_tb.Name = "mask_tb"
        Me.mask_tb.Size = New System.Drawing.Size(169, 19)
        Me.mask_tb.TabIndex = 26
        '
        'multiply_cb
        '
        Me.multiply_cb.AutoSize = True
        Me.multiply_cb.Checked = True
        Me.multiply_cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.multiply_cb.Location = New System.Drawing.Point(583, 23)
        Me.multiply_cb.Name = "multiply_cb"
        Me.multiply_cb.Size = New System.Drawing.Size(61, 17)
        Me.multiply_cb.TabIndex = 25
        Me.multiply_cb.Text = "Multiply"
        Me.multiply_cb.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"00%", "05%", "10%", "15%", "20%", "25%", "30%", "35%", "40%", "45%", "50%", "55%", "60%", "65%", "70%", "75%", "80%", "85%", "90%", "95%", "100%"})
        Me.ComboBox1.Location = New System.Drawing.Point(583, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'fill_alpha_cb
        '
        Me.fill_alpha_cb.AutoSize = True
        Me.fill_alpha_cb.Location = New System.Drawing.Point(583, 5)
        Me.fill_alpha_cb.Name = "fill_alpha_cb"
        Me.fill_alpha_cb.Size = New System.Drawing.Size(126, 17)
        Me.fill_alpha_cb.TabIndex = 23
        Me.fill_alpha_cb.Text = "Modify Alpha Opacity"
        Me.fill_alpha_cb.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(512, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "View Mask"
        '
        'b_alpha
        '
        Me.b_alpha.AutoSize = True
        Me.b_alpha.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.b_alpha.ForeColor = System.Drawing.Color.White
        Me.b_alpha.Location = New System.Drawing.Point(543, 50)
        Me.b_alpha.Name = "b_alpha"
        Me.b_alpha.Size = New System.Drawing.Size(25, 23)
        Me.b_alpha.TabIndex = 21
        Me.b_alpha.Text = "A"
        Me.b_alpha.UseVisualStyleBackColor = False
        '
        'b_blue
        '
        Me.b_blue.AutoSize = True
        Me.b_blue.BackColor = System.Drawing.Color.Blue
        Me.b_blue.ForeColor = System.Drawing.Color.White
        Me.b_blue.Location = New System.Drawing.Point(512, 50)
        Me.b_blue.Name = "b_blue"
        Me.b_blue.Size = New System.Drawing.Size(25, 23)
        Me.b_blue.TabIndex = 20
        Me.b_blue.Text = "B"
        Me.b_blue.UseVisualStyleBackColor = False
        '
        'b_green
        '
        Me.b_green.AutoSize = True
        Me.b_green.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_green.Location = New System.Drawing.Point(543, 24)
        Me.b_green.Name = "b_green"
        Me.b_green.Size = New System.Drawing.Size(25, 23)
        Me.b_green.TabIndex = 19
        Me.b_green.Text = "G"
        Me.b_green.UseVisualStyleBackColor = False
        '
        'b_red
        '
        Me.b_red.AutoSize = True
        Me.b_red.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_red.Location = New System.Drawing.Point(512, 24)
        Me.b_red.Name = "b_red"
        Me.b_red.Size = New System.Drawing.Size(25, 23)
        Me.b_red.TabIndex = 18
        Me.b_red.Text = "R"
        Me.b_red.UseVisualStyleBackColor = False
        '
        'convert_rgb_NM_cb
        '
        Me.convert_rgb_NM_cb.AutoSize = True
        Me.convert_rgb_NM_cb.Location = New System.Drawing.Point(16, 15)
        Me.convert_rgb_NM_cb.Name = "convert_rgb_NM_cb"
        Me.convert_rgb_NM_cb.Size = New System.Drawing.Size(69, 17)
        Me.convert_rgb_NM_cb.TabIndex = 17
        Me.convert_rgb_NM_cb.Text = "RGB NM"
        Me.convert_rgb_NM_cb.UseVisualStyleBackColor = True
        '
        'alpha_blend_cb
        '
        Me.alpha_blend_cb.AutoSize = True
        Me.alpha_blend_cb.Location = New System.Drawing.Point(419, 81)
        Me.alpha_blend_cb.Name = "alpha_blend_cb"
        Me.alpha_blend_cb.Size = New System.Drawing.Size(83, 17)
        Me.alpha_blend_cb.TabIndex = 16
        Me.alpha_blend_cb.Text = "Alpha Blend"
        Me.alpha_blend_cb.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.show_mask_rb)
        Me.GroupBox1.Controls.Add(Me.output_rb)
        Me.GroupBox1.Controls.Add(Me.source_rb)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(85, 70)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'show_mask_rb
        '
        Me.show_mask_rb.AutoSize = True
        Me.show_mask_rb.Location = New System.Drawing.Point(10, 49)
        Me.show_mask_rb.Name = "show_mask_rb"
        Me.show_mask_rb.Size = New System.Drawing.Size(51, 17)
        Me.show_mask_rb.TabIndex = 3
        Me.show_mask_rb.Text = "Mask"
        '
        'output_rb
        '
        Me.output_rb.AutoSize = True
        Me.output_rb.Checked = True
        Me.output_rb.Location = New System.Drawing.Point(10, 31)
        Me.output_rb.Name = "output_rb"
        Me.output_rb.Size = New System.Drawing.Size(57, 17)
        Me.output_rb.TabIndex = 2
        Me.output_rb.TabStop = True
        Me.output_rb.Text = "Output"
        '
        'source_rb
        '
        Me.source_rb.AutoSize = True
        Me.source_rb.Location = New System.Drawing.Point(10, 14)
        Me.source_rb.Name = "source_rb"
        Me.source_rb.Size = New System.Drawing.Size(59, 17)
        Me.source_rb.TabIndex = 0
        Me.source_rb.Text = "Source"
        Me.source_rb.UseVisualStyleBackColor = True
        '
        'scale_up_btn
        '
        Me.scale_up_btn.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.ASC_large
        Me.scale_up_btn.Location = New System.Drawing.Point(267, 77)
        Me.scale_up_btn.Name = "scale_up_btn"
        Me.scale_up_btn.Size = New System.Drawing.Size(33, 20)
        Me.scale_up_btn.TabIndex = 10
        Me.scale_up_btn.UseVisualStyleBackColor = True
        '
        'zoom
        '
        Me.zoom.AutoSize = True
        Me.zoom.ForeColor = System.Drawing.Color.Black
        Me.zoom.Location = New System.Drawing.Point(226, 74)
        Me.zoom.Name = "zoom"
        Me.zoom.Size = New System.Drawing.Size(37, 13)
        Me.zoom.TabIndex = 13
        Me.zoom.Text = "Zoom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(343, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Size"
        '
        'scale_down_btn
        '
        Me.scale_down_btn.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.DESC_large
        Me.scale_down_btn.Location = New System.Drawing.Point(306, 77)
        Me.scale_down_btn.Name = "scale_down_btn"
        Me.scale_down_btn.Size = New System.Drawing.Size(33, 20)
        Me.scale_down_btn.TabIndex = 11
        Me.scale_down_btn.UseVisualStyleBackColor = True
        '
        'alpha_group
        '
        Me.alpha_group.BackColor = System.Drawing.Color.Silver
        Me.alpha_group.Controls.Add(Me.a_r)
        Me.alpha_group.Controls.Add(Me.a_a)
        Me.alpha_group.Controls.Add(Me.a_b)
        Me.alpha_group.Controls.Add(Me.a_g)
        Me.alpha_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alpha_group.ForeColor = System.Drawing.Color.Black
        Me.alpha_group.Location = New System.Drawing.Point(306, 4)
        Me.alpha_group.Name = "alpha_group"
        Me.alpha_group.Size = New System.Drawing.Size(93, 70)
        Me.alpha_group.TabIndex = 4
        Me.alpha_group.TabStop = False
        Me.alpha_group.Text = "Alpha"
        '
        'a_r
        '
        Me.a_r.AutoSize = True
        Me.a_r.ForeColor = System.Drawing.Color.Red
        Me.a_r.Location = New System.Drawing.Point(7, 20)
        Me.a_r.Name = "a_r"
        Me.a_r.Size = New System.Drawing.Size(34, 17)
        Me.a_r.TabIndex = 4
        Me.a_r.TabStop = True
        Me.a_r.Tag = "1"
        Me.a_r.Text = "R"
        Me.a_r.UseVisualStyleBackColor = True
        '
        'a_a
        '
        Me.a_a.AutoSize = True
        Me.a_a.Checked = True
        Me.a_a.ForeColor = System.Drawing.Color.Black
        Me.a_a.Location = New System.Drawing.Point(45, 42)
        Me.a_a.Name = "a_a"
        Me.a_a.Size = New System.Drawing.Size(33, 17)
        Me.a_a.TabIndex = 3
        Me.a_a.TabStop = True
        Me.a_a.Tag = "8"
        Me.a_a.Text = "A"
        Me.a_a.UseVisualStyleBackColor = True
        '
        'a_b
        '
        Me.a_b.AutoSize = True
        Me.a_b.ForeColor = System.Drawing.Color.Blue
        Me.a_b.Location = New System.Drawing.Point(45, 19)
        Me.a_b.Name = "a_b"
        Me.a_b.Size = New System.Drawing.Size(33, 17)
        Me.a_b.TabIndex = 2
        Me.a_b.Tag = "4"
        Me.a_b.Text = "B"
        Me.a_b.UseVisualStyleBackColor = True
        '
        'a_g
        '
        Me.a_g.AutoSize = True
        Me.a_g.ForeColor = System.Drawing.Color.Green
        Me.a_g.Location = New System.Drawing.Point(6, 42)
        Me.a_g.Name = "a_g"
        Me.a_g.Size = New System.Drawing.Size(34, 17)
        Me.a_g.TabIndex = 1
        Me.a_g.Tag = "2"
        Me.a_g.Text = "G"
        Me.a_g.UseVisualStyleBackColor = True
        '
        'blue_group
        '
        Me.blue_group.BackColor = System.Drawing.Color.Silver
        Me.blue_group.Controls.Add(Me.b_a)
        Me.blue_group.Controls.Add(Me.b_b)
        Me.blue_group.Controls.Add(Me.b_g)
        Me.blue_group.Controls.Add(Me.b_r)
        Me.blue_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blue_group.ForeColor = System.Drawing.Color.Blue
        Me.blue_group.Location = New System.Drawing.Point(207, 4)
        Me.blue_group.Name = "blue_group"
        Me.blue_group.Size = New System.Drawing.Size(93, 70)
        Me.blue_group.TabIndex = 3
        Me.blue_group.TabStop = False
        Me.blue_group.Text = "Blue"
        '
        'b_a
        '
        Me.b_a.AutoSize = True
        Me.b_a.ForeColor = System.Drawing.Color.Black
        Me.b_a.Location = New System.Drawing.Point(45, 42)
        Me.b_a.Name = "b_a"
        Me.b_a.Size = New System.Drawing.Size(33, 17)
        Me.b_a.TabIndex = 3
        Me.b_a.Tag = "8"
        Me.b_a.Text = "A"
        Me.b_a.UseVisualStyleBackColor = True
        '
        'b_b
        '
        Me.b_b.AutoSize = True
        Me.b_b.Checked = True
        Me.b_b.ForeColor = System.Drawing.Color.Blue
        Me.b_b.Location = New System.Drawing.Point(45, 19)
        Me.b_b.Name = "b_b"
        Me.b_b.Size = New System.Drawing.Size(33, 17)
        Me.b_b.TabIndex = 2
        Me.b_b.TabStop = True
        Me.b_b.Tag = "4"
        Me.b_b.Text = "B"
        Me.b_b.UseVisualStyleBackColor = True
        '
        'b_g
        '
        Me.b_g.AutoSize = True
        Me.b_g.ForeColor = System.Drawing.Color.Green
        Me.b_g.Location = New System.Drawing.Point(6, 42)
        Me.b_g.Name = "b_g"
        Me.b_g.Size = New System.Drawing.Size(34, 17)
        Me.b_g.TabIndex = 1
        Me.b_g.Tag = "2"
        Me.b_g.Text = "G"
        Me.b_g.UseVisualStyleBackColor = True
        '
        'b_r
        '
        Me.b_r.AutoSize = True
        Me.b_r.ForeColor = System.Drawing.Color.Red
        Me.b_r.Location = New System.Drawing.Point(6, 19)
        Me.b_r.Name = "b_r"
        Me.b_r.Size = New System.Drawing.Size(34, 17)
        Me.b_r.TabIndex = 0
        Me.b_r.Tag = "1"
        Me.b_r.Text = "R"
        Me.b_r.UseVisualStyleBackColor = True
        '
        'green_group
        '
        Me.green_group.BackColor = System.Drawing.Color.Silver
        Me.green_group.Controls.Add(Me.g_a)
        Me.green_group.Controls.Add(Me.g_b)
        Me.green_group.Controls.Add(Me.g_g)
        Me.green_group.Controls.Add(Me.g_r)
        Me.green_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.green_group.ForeColor = System.Drawing.Color.Green
        Me.green_group.Location = New System.Drawing.Point(108, 4)
        Me.green_group.Name = "green_group"
        Me.green_group.Size = New System.Drawing.Size(93, 70)
        Me.green_group.TabIndex = 2
        Me.green_group.TabStop = False
        Me.green_group.Text = "Green"
        '
        'g_a
        '
        Me.g_a.AutoSize = True
        Me.g_a.ForeColor = System.Drawing.Color.Black
        Me.g_a.Location = New System.Drawing.Point(45, 42)
        Me.g_a.Name = "g_a"
        Me.g_a.Size = New System.Drawing.Size(33, 17)
        Me.g_a.TabIndex = 3
        Me.g_a.Tag = "8"
        Me.g_a.Text = "A"
        Me.g_a.UseVisualStyleBackColor = True
        '
        'g_b
        '
        Me.g_b.AutoSize = True
        Me.g_b.ForeColor = System.Drawing.Color.Blue
        Me.g_b.Location = New System.Drawing.Point(45, 19)
        Me.g_b.Name = "g_b"
        Me.g_b.Size = New System.Drawing.Size(33, 17)
        Me.g_b.TabIndex = 2
        Me.g_b.Tag = "4"
        Me.g_b.Text = "B"
        Me.g_b.UseVisualStyleBackColor = True
        '
        'g_g
        '
        Me.g_g.AutoSize = True
        Me.g_g.Checked = True
        Me.g_g.ForeColor = System.Drawing.Color.Green
        Me.g_g.Location = New System.Drawing.Point(6, 42)
        Me.g_g.Name = "g_g"
        Me.g_g.Size = New System.Drawing.Size(34, 17)
        Me.g_g.TabIndex = 1
        Me.g_g.TabStop = True
        Me.g_g.Tag = "2"
        Me.g_g.Text = "G"
        Me.g_g.UseVisualStyleBackColor = True
        '
        'g_r
        '
        Me.g_r.AutoSize = True
        Me.g_r.ForeColor = System.Drawing.Color.Red
        Me.g_r.Location = New System.Drawing.Point(6, 19)
        Me.g_r.Name = "g_r"
        Me.g_r.Size = New System.Drawing.Size(34, 17)
        Me.g_r.TabIndex = 0
        Me.g_r.Tag = "1"
        Me.g_r.Text = "R"
        Me.g_r.UseVisualStyleBackColor = True
        '
        'red_group
        '
        Me.red_group.BackColor = System.Drawing.Color.Silver
        Me.red_group.Controls.Add(Me.r_a)
        Me.red_group.Controls.Add(Me.r_b)
        Me.red_group.Controls.Add(Me.r_g)
        Me.red_group.Controls.Add(Me.r_r)
        Me.red_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.red_group.ForeColor = System.Drawing.Color.Red
        Me.red_group.Location = New System.Drawing.Point(9, 4)
        Me.red_group.Name = "red_group"
        Me.red_group.Size = New System.Drawing.Size(93, 70)
        Me.red_group.TabIndex = 1
        Me.red_group.TabStop = False
        Me.red_group.Text = "Red"
        '
        'r_a
        '
        Me.r_a.AutoSize = True
        Me.r_a.ForeColor = System.Drawing.Color.Black
        Me.r_a.Location = New System.Drawing.Point(45, 42)
        Me.r_a.Name = "r_a"
        Me.r_a.Size = New System.Drawing.Size(33, 17)
        Me.r_a.TabIndex = 3
        Me.r_a.Tag = "8"
        Me.r_a.Text = "A"
        Me.r_a.UseVisualStyleBackColor = True
        '
        'r_b
        '
        Me.r_b.AutoSize = True
        Me.r_b.ForeColor = System.Drawing.Color.Blue
        Me.r_b.Location = New System.Drawing.Point(45, 19)
        Me.r_b.Name = "r_b"
        Me.r_b.Size = New System.Drawing.Size(33, 17)
        Me.r_b.TabIndex = 2
        Me.r_b.Tag = "4"
        Me.r_b.Text = "B"
        Me.r_b.UseVisualStyleBackColor = True
        '
        'r_g
        '
        Me.r_g.AutoSize = True
        Me.r_g.ForeColor = System.Drawing.Color.Green
        Me.r_g.Location = New System.Drawing.Point(6, 42)
        Me.r_g.Name = "r_g"
        Me.r_g.Size = New System.Drawing.Size(34, 17)
        Me.r_g.TabIndex = 1
        Me.r_g.Tag = "2"
        Me.r_g.Text = "G"
        Me.r_g.UseVisualStyleBackColor = True
        '
        'r_r
        '
        Me.r_r.AutoSize = True
        Me.r_r.Checked = True
        Me.r_r.Location = New System.Drawing.Point(6, 19)
        Me.r_r.Name = "r_r"
        Me.r_r.Size = New System.Drawing.Size(34, 17)
        Me.r_r.TabIndex = 0
        Me.r_r.TabStop = True
        Me.r_r.Tag = "1"
        Me.r_r.Text = "R"
        Me.r_r.UseVisualStyleBackColor = True
        '
        'mask_alpha_blend_cb
        '
        Me.mask_alpha_blend_cb.AutoSize = True
        Me.mask_alpha_blend_cb.Checked = True
        Me.mask_alpha_blend_cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mask_alpha_blend_cb.Location = New System.Drawing.Point(12, 229)
        Me.mask_alpha_blend_cb.Name = "mask_alpha_blend_cb"
        Me.mask_alpha_blend_cb.Size = New System.Drawing.Size(83, 17)
        Me.mask_alpha_blend_cb.TabIndex = 35
        Me.mask_alpha_blend_cb.Tag = "8"
        Me.mask_alpha_blend_cb.Text = "Blend Alpha"
        Me.mask_alpha_blend_cb.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.WoT_Texture_Swizzler.My.MySettings.Default, "mask_mix_amount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(3, 193)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(118, 43)
        Me.TrackBar1.TabIndex = 34
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = Global.WoT_Texture_Swizzler.My.MySettings.Default.mask_mix_amount
        '
        'm_alpha_cb
        '
        Me.m_alpha_cb.AutoSize = True
        Me.m_alpha_cb.Checked = True
        Me.m_alpha_cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_alpha_cb.Location = New System.Drawing.Point(12, 170)
        Me.m_alpha_cb.Name = "m_alpha_cb"
        Me.m_alpha_cb.Size = New System.Drawing.Size(53, 17)
        Me.m_alpha_cb.TabIndex = 33
        Me.m_alpha_cb.Tag = "8"
        Me.m_alpha_cb.Text = "Alpha"
        Me.m_alpha_cb.UseVisualStyleBackColor = True
        '
        'm_blue_cb
        '
        Me.m_blue_cb.AutoSize = True
        Me.m_blue_cb.Checked = True
        Me.m_blue_cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_blue_cb.ForeColor = System.Drawing.Color.Blue
        Me.m_blue_cb.Location = New System.Drawing.Point(12, 154)
        Me.m_blue_cb.Name = "m_blue_cb"
        Me.m_blue_cb.Size = New System.Drawing.Size(47, 17)
        Me.m_blue_cb.TabIndex = 32
        Me.m_blue_cb.Tag = "4"
        Me.m_blue_cb.Text = "Blue"
        Me.m_blue_cb.UseVisualStyleBackColor = True
        '
        'm_green_cb
        '
        Me.m_green_cb.AutoSize = True
        Me.m_green_cb.Checked = True
        Me.m_green_cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_green_cb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.m_green_cb.Location = New System.Drawing.Point(12, 138)
        Me.m_green_cb.Name = "m_green_cb"
        Me.m_green_cb.Size = New System.Drawing.Size(55, 17)
        Me.m_green_cb.TabIndex = 31
        Me.m_green_cb.Tag = "2"
        Me.m_green_cb.Text = "Green"
        Me.m_green_cb.UseVisualStyleBackColor = True
        '
        'm_red_cb
        '
        Me.m_red_cb.AutoSize = True
        Me.m_red_cb.Checked = True
        Me.m_red_cb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_red_cb.ForeColor = System.Drawing.Color.Red
        Me.m_red_cb.Location = New System.Drawing.Point(12, 121)
        Me.m_red_cb.Name = "m_red_cb"
        Me.m_red_cb.Size = New System.Drawing.Size(46, 17)
        Me.m_red_cb.TabIndex = 30
        Me.m_red_cb.Tag = "1"
        Me.m_red_cb.Text = "Red"
        Me.m_red_cb.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Affected Channels"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sub_rb)
        Me.GroupBox2.Controls.Add(Me.mask_invert_rb)
        Me.GroupBox2.Controls.Add(Me.mask_rb)
        Me.GroupBox2.Controls.Add(Me.add_rb)
        Me.GroupBox2.Controls.Add(Me.mask_cb)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 84)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'sub_rb
        '
        Me.sub_rb.AutoSize = True
        Me.sub_rb.Location = New System.Drawing.Point(7, 31)
        Me.sub_rb.Name = "sub_rb"
        Me.sub_rb.Size = New System.Drawing.Size(65, 17)
        Me.sub_rb.TabIndex = 3
        Me.sub_rb.Text = "Subtract"
        Me.sub_rb.UseVisualStyleBackColor = True
        '
        'mask_invert_rb
        '
        Me.mask_invert_rb.AutoSize = True
        Me.mask_invert_rb.Location = New System.Drawing.Point(7, 62)
        Me.mask_invert_rb.Name = "mask_invert_rb"
        Me.mask_invert_rb.Size = New System.Drawing.Size(81, 17)
        Me.mask_invert_rb.TabIndex = 2
        Me.mask_invert_rb.Text = "Mask Invert"
        Me.mask_invert_rb.UseVisualStyleBackColor = True
        '
        'mask_rb
        '
        Me.mask_rb.AutoSize = True
        Me.mask_rb.Location = New System.Drawing.Point(7, 47)
        Me.mask_rb.Name = "mask_rb"
        Me.mask_rb.Size = New System.Drawing.Size(51, 17)
        Me.mask_rb.TabIndex = 1
        Me.mask_rb.Text = "Mask"
        Me.mask_rb.UseVisualStyleBackColor = True
        '
        'add_rb
        '
        Me.add_rb.AutoSize = True
        Me.add_rb.Checked = True
        Me.add_rb.Location = New System.Drawing.Point(7, 16)
        Me.add_rb.Name = "add_rb"
        Me.add_rb.Size = New System.Drawing.Size(65, 17)
        Me.add_rb.TabIndex = 0
        Me.add_rb.TabStop = True
        Me.add_rb.Text = "Replace"
        Me.add_rb.UseVisualStyleBackColor = True
        '
        'mask_cb
        '
        Me.mask_cb.AutoSize = True
        Me.mask_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mask_cb.Location = New System.Drawing.Point(7, -1)
        Me.mask_cb.Name = "mask_cb"
        Me.mask_cb.Size = New System.Drawing.Size(82, 17)
        Me.mask_cb.TabIndex = 27
        Me.mask_cb.Text = "Use Mask"
        Me.mask_cb.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.m_help, Me.m_combiner, Me.m_top_most})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(873, 24)
        Me.MenuStrip.TabIndex = 2
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_open, Me.m_mask, Me.ToolStripSeparator2, Me.m_save, Me.ToolStripSeparator1, Me.m_edit_shaders})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'm_open
        '
        Me.m_open.Name = "m_open"
        Me.m_open.Size = New System.Drawing.Size(167, 22)
        Me.m_open.Tag = "0"
        Me.m_open.Text = "Open Image"
        '
        'm_mask
        '
        Me.m_mask.Name = "m_mask"
        Me.m_mask.Size = New System.Drawing.Size(167, 22)
        Me.m_mask.Text = "Load Mask Image"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'm_save
        '
        Me.m_save.Name = "m_save"
        Me.m_save.Size = New System.Drawing.Size(167, 22)
        Me.m_save.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'm_edit_shaders
        '
        Me.m_edit_shaders.Name = "m_edit_shaders"
        Me.m_edit_shaders.Size = New System.Drawing.Size(167, 22)
        Me.m_edit_shaders.Text = "Edit Shaders"
        '
        'm_help
        '
        Me.m_help.Name = "m_help"
        Me.m_help.Size = New System.Drawing.Size(44, 20)
        Me.m_help.Text = "Help"
        '
        'm_combiner
        '
        Me.m_combiner.CheckOnClick = True
        Me.m_combiner.Name = "m_combiner"
        Me.m_combiner.Size = New System.Drawing.Size(72, 20)
        Me.m_combiner.Text = "Combiner"
        '
        'm_top_most
        '
        Me.m_top_most.Checked = True
        Me.m_top_most.CheckOnClick = True
        Me.m_top_most.CheckState = System.Windows.Forms.CheckState.Checked
        Me.m_top_most.ForeColor = System.Drawing.Color.Red
        Me.m_top_most.Name = "m_top_most"
        Me.m_top_most.Size = New System.Drawing.Size(70, 20)
        Me.m_top_most.Text = "Top Most"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "DDS (*.dds)|*.dds|All Files (*.*)|*.*"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*"
        '
        'pb3
        '
        Me.pb3.Controls.Add(Me.pb1)
        Me.pb3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb3.Location = New System.Drawing.Point(123, 129)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(750, 323)
        Me.pb3.TabIndex = 3
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.White
        Me.pb1.Location = New System.Drawing.Point(296, 71)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(200, 100)
        Me.pb1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.mask_alpha_blend_cb)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.m_alpha_cb)
        Me.Panel1.Controls.Add(Me.m_red_cb)
        Me.Panel1.Controls.Add(Me.m_blue_cb)
        Me.Panel1.Controls.Add(Me.m_green_cb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(123, 323)
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Mix Amount"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.m_flip_x_cb)
        Me.Panel2.Controls.Add(Me.m_flip_y_cb)
        Me.Panel2.Controls.Add(Me.convert_rgb_NM_cb)
        Me.Panel2.Location = New System.Drawing.Point(758, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(111, 105)
        Me.Panel2.TabIndex = 30
        '
        'm_flip_y_cb
        '
        Me.m_flip_y_cb.AutoSize = True
        Me.m_flip_y_cb.Location = New System.Drawing.Point(16, 49)
        Me.m_flip_y_cb.Name = "m_flip_y_cb"
        Me.m_flip_y_cb.Size = New System.Drawing.Size(52, 17)
        Me.m_flip_y_cb.TabIndex = 18
        Me.m_flip_y_cb.Text = "Flip Y"
        Me.m_flip_y_cb.UseVisualStyleBackColor = True
        '
        'm_flip_x_cb
        '
        Me.m_flip_x_cb.AutoSize = True
        Me.m_flip_x_cb.Location = New System.Drawing.Point(16, 72)
        Me.m_flip_x_cb.Name = "m_flip_x_cb"
        Me.m_flip_x_cb.Size = New System.Drawing.Size(52, 17)
        Me.m_flip_x_cb.TabIndex = 19
        Me.m_flip_x_cb.Text = "Flip X"
        Me.m_flip_x_cb.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(873, 452)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.top_panel)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(650, 250)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RGBA Channel Swizzler"
        Me.TopMost = True
        Me.top_panel.ResumeLayout(False)
        Me.top_panel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.alpha_group.ResumeLayout(False)
        Me.alpha_group.PerformLayout()
        Me.blue_group.ResumeLayout(False)
        Me.blue_group.PerformLayout()
        Me.green_group.ResumeLayout(False)
        Me.green_group.PerformLayout()
        Me.red_group.ResumeLayout(False)
        Me.red_group.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.pb3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents top_panel As System.Windows.Forms.Panel
    Friend WithEvents alpha_group As System.Windows.Forms.GroupBox
    Friend WithEvents a_a As System.Windows.Forms.RadioButton
    Friend WithEvents a_b As System.Windows.Forms.RadioButton
    Friend WithEvents a_g As System.Windows.Forms.RadioButton
    Friend WithEvents a_r As System.Windows.Forms.RadioButton
    Friend WithEvents blue_group As System.Windows.Forms.GroupBox
    Friend WithEvents b_a As System.Windows.Forms.RadioButton
    Friend WithEvents b_b As System.Windows.Forms.RadioButton
    Friend WithEvents b_g As System.Windows.Forms.RadioButton
    Friend WithEvents b_r As System.Windows.Forms.RadioButton
    Friend WithEvents green_group As System.Windows.Forms.GroupBox
    Friend WithEvents g_a As System.Windows.Forms.RadioButton
    Friend WithEvents g_b As System.Windows.Forms.RadioButton
    Friend WithEvents g_g As System.Windows.Forms.RadioButton
    Friend WithEvents g_r As System.Windows.Forms.RadioButton
    Friend WithEvents red_group As System.Windows.Forms.GroupBox
    Friend WithEvents r_a As System.Windows.Forms.RadioButton
    Friend WithEvents r_b As System.Windows.Forms.RadioButton
    Friend WithEvents r_g As System.Windows.Forms.RadioButton
    Friend WithEvents r_r As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scale_up_btn As System.Windows.Forms.Button
    Friend WithEvents zoom As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents scale_down_btn As System.Windows.Forms.Button
    Friend WithEvents m_top_most As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents output_rb As System.Windows.Forms.RadioButton
    Friend WithEvents source_rb As System.Windows.Forms.RadioButton

    Private Sub a_red_CheckedChanged(sender As Object, e As EventArgs) Handles a_r.CheckedChanged

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents alpha_blend_cb As System.Windows.Forms.CheckBox
    Friend WithEvents convert_rgb_NM_cb As System.Windows.Forms.CheckBox
    Friend WithEvents pb3 As System.Windows.Forms.Panel
    Friend WithEvents pb1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents m_edit_shaders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_alpha As System.Windows.Forms.Button
    Friend WithEvents b_blue As System.Windows.Forms.Button
    Friend WithEvents b_green As System.Windows.Forms.Button
    Friend WithEvents b_red As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents fill_alpha_cb As System.Windows.Forms.CheckBox
    Friend WithEvents multiply_cb As System.Windows.Forms.CheckBox
    Friend WithEvents m_mask As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mask_tb As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents mask_invert_rb As System.Windows.Forms.RadioButton
    Friend WithEvents mask_rb As System.Windows.Forms.RadioButton
    Friend WithEvents add_rb As System.Windows.Forms.RadioButton
    Friend WithEvents mask_cb As System.Windows.Forms.CheckBox
    Friend WithEvents m_alpha_cb As System.Windows.Forms.CheckBox
    Friend WithEvents m_blue_cb As System.Windows.Forms.CheckBox
    Friend WithEvents m_green_cb As System.Windows.Forms.CheckBox
    Friend WithEvents m_red_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents show_mask_rb As System.Windows.Forms.RadioButton
    Friend WithEvents sub_rb As System.Windows.Forms.RadioButton
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents mask_alpha_blend_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GenMask_cb As System.Windows.Forms.CheckBox
    Friend WithEvents reset_btn As System.Windows.Forms.Button
    Friend WithEvents quater_cb As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents m_combiner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents m_flip_x_cb As System.Windows.Forms.CheckBox
    Friend WithEvents m_flip_y_cb As System.Windows.Forms.CheckBox
End Class
