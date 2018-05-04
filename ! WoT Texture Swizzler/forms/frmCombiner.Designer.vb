<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombiner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCombiner))
        Me.red_group = New System.Windows.Forms.GroupBox()
        Me.r_enable = New System.Windows.Forms.CheckBox()
        Me.r_filename = New System.Windows.Forms.TextBox()
        Me.r_open = New System.Windows.Forms.Button()
        Me.r_a = New System.Windows.Forms.RadioButton()
        Me.r_b = New System.Windows.Forms.RadioButton()
        Me.r_g = New System.Windows.Forms.RadioButton()
        Me.r_r = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.g_enable = New System.Windows.Forms.CheckBox()
        Me.g_filename = New System.Windows.Forms.TextBox()
        Me.g_open = New System.Windows.Forms.Button()
        Me.g_a = New System.Windows.Forms.RadioButton()
        Me.g_b = New System.Windows.Forms.RadioButton()
        Me.g_g = New System.Windows.Forms.RadioButton()
        Me.g_r = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.b_enable = New System.Windows.Forms.CheckBox()
        Me.b_filename = New System.Windows.Forms.TextBox()
        Me.b_open = New System.Windows.Forms.Button()
        Me.b_a = New System.Windows.Forms.RadioButton()
        Me.b_b = New System.Windows.Forms.RadioButton()
        Me.b_g = New System.Windows.Forms.RadioButton()
        Me.b_r = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.a_enable = New System.Windows.Forms.CheckBox()
        Me.a_filename = New System.Windows.Forms.TextBox()
        Me.a_open = New System.Windows.Forms.Button()
        Me.a_a = New System.Windows.Forms.RadioButton()
        Me.a_b = New System.Windows.Forms.RadioButton()
        Me.a_g = New System.Windows.Forms.RadioButton()
        Me.a_r = New System.Windows.Forms.RadioButton()
        Me.combiner_active_cb = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.r_track = New System.Windows.Forms.TrackBar()
        Me.r_text = New System.Windows.Forms.Label()
        Me.g_text = New System.Windows.Forms.Label()
        Me.g_track = New System.Windows.Forms.TrackBar()
        Me.a_text = New System.Windows.Forms.Label()
        Me.a_track = New System.Windows.Forms.TrackBar()
        Me.b_text = New System.Windows.Forms.Label()
        Me.b_track = New System.Windows.Forms.TrackBar()
        Me.red_group.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.r_track, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_track, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a_track, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b_track, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'red_group
        '
        Me.red_group.BackColor = System.Drawing.Color.Silver
        Me.red_group.Controls.Add(Me.r_enable)
        Me.red_group.Controls.Add(Me.r_filename)
        Me.red_group.Controls.Add(Me.r_open)
        Me.red_group.Controls.Add(Me.r_a)
        Me.red_group.Controls.Add(Me.r_b)
        Me.red_group.Controls.Add(Me.r_g)
        Me.red_group.Controls.Add(Me.r_r)
        Me.red_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.red_group.ForeColor = System.Drawing.Color.Red
        Me.red_group.Location = New System.Drawing.Point(9, 4)
        Me.red_group.Margin = New System.Windows.Forms.Padding(6)
        Me.red_group.Name = "red_group"
        Me.red_group.Size = New System.Drawing.Size(450, 47)
        Me.red_group.TabIndex = 2
        Me.red_group.TabStop = False
        Me.red_group.Text = "Red"
        '
        'r_enable
        '
        Me.r_enable.Appearance = System.Windows.Forms.Appearance.Button
        Me.r_enable.BackColor = System.Drawing.Color.Silver
        Me.r_enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.r_enable.ForeColor = System.Drawing.Color.Black
        Me.r_enable.Location = New System.Drawing.Point(55, 15)
        Me.r_enable.Name = "r_enable"
        Me.r_enable.Size = New System.Drawing.Size(27, 23)
        Me.r_enable.TabIndex = 3
        Me.r_enable.Tag = "1"
        Me.r_enable.Text = "E"
        Me.r_enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.r_enable.UseVisualStyleBackColor = False
        '
        'r_filename
        '
        Me.r_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r_filename.Location = New System.Drawing.Point(88, 17)
        Me.r_filename.Name = "r_filename"
        Me.r_filename.Size = New System.Drawing.Size(193, 20)
        Me.r_filename.TabIndex = 5
        '
        'r_open
        '
        Me.r_open.ForeColor = System.Drawing.Color.Black
        Me.r_open.Location = New System.Drawing.Point(7, 15)
        Me.r_open.Name = "r_open"
        Me.r_open.Size = New System.Drawing.Size(47, 23)
        Me.r_open.TabIndex = 4
        Me.r_open.Tag = "1"
        Me.r_open.Text = "Load"
        Me.r_open.UseVisualStyleBackColor = True
        '
        'r_a
        '
        Me.r_a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_a.AutoSize = True
        Me.r_a.ForeColor = System.Drawing.Color.Black
        Me.r_a.Location = New System.Drawing.Point(407, 18)
        Me.r_a.Name = "r_a"
        Me.r_a.Size = New System.Drawing.Size(33, 17)
        Me.r_a.TabIndex = 3
        Me.r_a.Tag = "8"
        Me.r_a.Text = "A"
        Me.r_a.UseVisualStyleBackColor = True
        '
        'r_b
        '
        Me.r_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_b.AutoSize = True
        Me.r_b.ForeColor = System.Drawing.Color.Blue
        Me.r_b.Location = New System.Drawing.Point(368, 18)
        Me.r_b.Name = "r_b"
        Me.r_b.Size = New System.Drawing.Size(33, 17)
        Me.r_b.TabIndex = 2
        Me.r_b.Tag = "4"
        Me.r_b.Text = "B"
        Me.r_b.UseVisualStyleBackColor = True
        '
        'r_g
        '
        Me.r_g.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_g.AutoSize = True
        Me.r_g.ForeColor = System.Drawing.Color.Green
        Me.r_g.Location = New System.Drawing.Point(328, 18)
        Me.r_g.Name = "r_g"
        Me.r_g.Size = New System.Drawing.Size(34, 17)
        Me.r_g.TabIndex = 1
        Me.r_g.Tag = "2"
        Me.r_g.Text = "G"
        Me.r_g.UseVisualStyleBackColor = True
        '
        'r_r
        '
        Me.r_r.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r_r.AutoSize = True
        Me.r_r.Checked = True
        Me.r_r.Location = New System.Drawing.Point(288, 18)
        Me.r_r.Name = "r_r"
        Me.r_r.Size = New System.Drawing.Size(34, 17)
        Me.r_r.TabIndex = 0
        Me.r_r.TabStop = True
        Me.r_r.Tag = "1"
        Me.r_r.Text = "R"
        Me.r_r.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.g_enable)
        Me.GroupBox1.Controls.Add(Me.g_filename)
        Me.GroupBox1.Controls.Add(Me.g_open)
        Me.GroupBox1.Controls.Add(Me.g_a)
        Me.GroupBox1.Controls.Add(Me.g_b)
        Me.GroupBox1.Controls.Add(Me.g_g)
        Me.GroupBox1.Controls.Add(Me.g_r)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 79)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 47)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Green"
        '
        'g_enable
        '
        Me.g_enable.Appearance = System.Windows.Forms.Appearance.Button
        Me.g_enable.BackColor = System.Drawing.Color.Silver
        Me.g_enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.g_enable.ForeColor = System.Drawing.Color.Black
        Me.g_enable.Location = New System.Drawing.Point(55, 15)
        Me.g_enable.Name = "g_enable"
        Me.g_enable.Size = New System.Drawing.Size(27, 23)
        Me.g_enable.TabIndex = 3
        Me.g_enable.Tag = "2"
        Me.g_enable.Text = "E"
        Me.g_enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.g_enable.UseVisualStyleBackColor = False
        '
        'g_filename
        '
        Me.g_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.g_filename.Location = New System.Drawing.Point(88, 17)
        Me.g_filename.Name = "g_filename"
        Me.g_filename.Size = New System.Drawing.Size(193, 20)
        Me.g_filename.TabIndex = 5
        '
        'g_open
        '
        Me.g_open.ForeColor = System.Drawing.Color.Black
        Me.g_open.Location = New System.Drawing.Point(7, 15)
        Me.g_open.Name = "g_open"
        Me.g_open.Size = New System.Drawing.Size(47, 23)
        Me.g_open.TabIndex = 4
        Me.g_open.Tag = "2"
        Me.g_open.Text = "Load"
        Me.g_open.UseVisualStyleBackColor = True
        '
        'g_a
        '
        Me.g_a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_a.AutoSize = True
        Me.g_a.ForeColor = System.Drawing.Color.Black
        Me.g_a.Location = New System.Drawing.Point(406, 18)
        Me.g_a.Name = "g_a"
        Me.g_a.Size = New System.Drawing.Size(33, 17)
        Me.g_a.TabIndex = 3
        Me.g_a.Tag = "8"
        Me.g_a.Text = "A"
        Me.g_a.UseVisualStyleBackColor = True
        '
        'g_b
        '
        Me.g_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_b.AutoSize = True
        Me.g_b.ForeColor = System.Drawing.Color.Blue
        Me.g_b.Location = New System.Drawing.Point(367, 18)
        Me.g_b.Name = "g_b"
        Me.g_b.Size = New System.Drawing.Size(33, 17)
        Me.g_b.TabIndex = 2
        Me.g_b.Tag = "4"
        Me.g_b.Text = "B"
        Me.g_b.UseVisualStyleBackColor = True
        '
        'g_g
        '
        Me.g_g.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_g.AutoSize = True
        Me.g_g.Checked = True
        Me.g_g.ForeColor = System.Drawing.Color.Green
        Me.g_g.Location = New System.Drawing.Point(327, 18)
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
        Me.g_r.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_r.AutoSize = True
        Me.g_r.ForeColor = System.Drawing.Color.Red
        Me.g_r.Location = New System.Drawing.Point(287, 18)
        Me.g_r.Name = "g_r"
        Me.g_r.Size = New System.Drawing.Size(34, 17)
        Me.g_r.TabIndex = 0
        Me.g_r.Tag = "1"
        Me.g_r.Text = "R"
        Me.g_r.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.b_enable)
        Me.GroupBox2.Controls.Add(Me.b_filename)
        Me.GroupBox2.Controls.Add(Me.b_open)
        Me.GroupBox2.Controls.Add(Me.b_a)
        Me.GroupBox2.Controls.Add(Me.b_b)
        Me.GroupBox2.Controls.Add(Me.b_g)
        Me.GroupBox2.Controls.Add(Me.b_r)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(9, 160)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 47)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Blue"
        '
        'b_enable
        '
        Me.b_enable.Appearance = System.Windows.Forms.Appearance.Button
        Me.b_enable.BackColor = System.Drawing.Color.Silver
        Me.b_enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b_enable.ForeColor = System.Drawing.Color.Black
        Me.b_enable.Location = New System.Drawing.Point(55, 15)
        Me.b_enable.Name = "b_enable"
        Me.b_enable.Size = New System.Drawing.Size(27, 23)
        Me.b_enable.TabIndex = 3
        Me.b_enable.Tag = "3"
        Me.b_enable.Text = "E"
        Me.b_enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.b_enable.UseVisualStyleBackColor = False
        '
        'b_filename
        '
        Me.b_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.b_filename.Location = New System.Drawing.Point(88, 17)
        Me.b_filename.Name = "b_filename"
        Me.b_filename.Size = New System.Drawing.Size(193, 20)
        Me.b_filename.TabIndex = 5
        '
        'b_open
        '
        Me.b_open.ForeColor = System.Drawing.Color.Black
        Me.b_open.Location = New System.Drawing.Point(7, 15)
        Me.b_open.Name = "b_open"
        Me.b_open.Size = New System.Drawing.Size(47, 23)
        Me.b_open.TabIndex = 4
        Me.b_open.Tag = "4"
        Me.b_open.Text = "Load"
        Me.b_open.UseVisualStyleBackColor = True
        '
        'b_a
        '
        Me.b_a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_a.AutoSize = True
        Me.b_a.ForeColor = System.Drawing.Color.Black
        Me.b_a.Location = New System.Drawing.Point(407, 18)
        Me.b_a.Name = "b_a"
        Me.b_a.Size = New System.Drawing.Size(33, 17)
        Me.b_a.TabIndex = 3
        Me.b_a.Tag = "8"
        Me.b_a.Text = "A"
        Me.b_a.UseVisualStyleBackColor = True
        '
        'b_b
        '
        Me.b_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_b.AutoSize = True
        Me.b_b.Checked = True
        Me.b_b.ForeColor = System.Drawing.Color.Blue
        Me.b_b.Location = New System.Drawing.Point(368, 18)
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
        Me.b_g.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_g.AutoSize = True
        Me.b_g.ForeColor = System.Drawing.Color.Green
        Me.b_g.Location = New System.Drawing.Point(329, 18)
        Me.b_g.Name = "b_g"
        Me.b_g.Size = New System.Drawing.Size(34, 17)
        Me.b_g.TabIndex = 1
        Me.b_g.Tag = "2"
        Me.b_g.Text = "G"
        Me.b_g.UseVisualStyleBackColor = True
        '
        'b_r
        '
        Me.b_r.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_r.AutoSize = True
        Me.b_r.ForeColor = System.Drawing.Color.Red
        Me.b_r.Location = New System.Drawing.Point(289, 18)
        Me.b_r.Name = "b_r"
        Me.b_r.Size = New System.Drawing.Size(34, 17)
        Me.b_r.TabIndex = 0
        Me.b_r.Tag = "1"
        Me.b_r.Text = "R"
        Me.b_r.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.a_enable)
        Me.GroupBox3.Controls.Add(Me.a_filename)
        Me.GroupBox3.Controls.Add(Me.a_open)
        Me.GroupBox3.Controls.Add(Me.a_a)
        Me.GroupBox3.Controls.Add(Me.a_b)
        Me.GroupBox3.Controls.Add(Me.a_g)
        Me.GroupBox3.Controls.Add(Me.a_r)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(9, 238)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 47)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alpha"
        '
        'a_enable
        '
        Me.a_enable.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_enable.BackColor = System.Drawing.Color.Silver
        Me.a_enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.a_enable.Location = New System.Drawing.Point(55, 15)
        Me.a_enable.Name = "a_enable"
        Me.a_enable.Size = New System.Drawing.Size(27, 23)
        Me.a_enable.TabIndex = 3
        Me.a_enable.Tag = "4"
        Me.a_enable.Text = "E"
        Me.a_enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_enable.UseVisualStyleBackColor = False
        '
        'a_filename
        '
        Me.a_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a_filename.Location = New System.Drawing.Point(88, 17)
        Me.a_filename.Name = "a_filename"
        Me.a_filename.Size = New System.Drawing.Size(193, 20)
        Me.a_filename.TabIndex = 5
        '
        'a_open
        '
        Me.a_open.ForeColor = System.Drawing.Color.Black
        Me.a_open.Location = New System.Drawing.Point(7, 15)
        Me.a_open.Name = "a_open"
        Me.a_open.Size = New System.Drawing.Size(47, 23)
        Me.a_open.TabIndex = 4
        Me.a_open.Tag = "8"
        Me.a_open.Text = "Load"
        Me.a_open.UseVisualStyleBackColor = True
        '
        'a_a
        '
        Me.a_a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a_a.AutoSize = True
        Me.a_a.Checked = True
        Me.a_a.ForeColor = System.Drawing.Color.Black
        Me.a_a.Location = New System.Drawing.Point(407, 18)
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
        Me.a_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a_b.AutoSize = True
        Me.a_b.ForeColor = System.Drawing.Color.Blue
        Me.a_b.Location = New System.Drawing.Point(368, 18)
        Me.a_b.Name = "a_b"
        Me.a_b.Size = New System.Drawing.Size(33, 17)
        Me.a_b.TabIndex = 2
        Me.a_b.Tag = "4"
        Me.a_b.Text = "B"
        Me.a_b.UseVisualStyleBackColor = True
        '
        'a_g
        '
        Me.a_g.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a_g.AutoSize = True
        Me.a_g.ForeColor = System.Drawing.Color.Green
        Me.a_g.Location = New System.Drawing.Point(328, 18)
        Me.a_g.Name = "a_g"
        Me.a_g.Size = New System.Drawing.Size(34, 17)
        Me.a_g.TabIndex = 1
        Me.a_g.Tag = "2"
        Me.a_g.Text = "G"
        Me.a_g.UseVisualStyleBackColor = True
        '
        'a_r
        '
        Me.a_r.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a_r.AutoSize = True
        Me.a_r.ForeColor = System.Drawing.Color.Red
        Me.a_r.Location = New System.Drawing.Point(288, 18)
        Me.a_r.Name = "a_r"
        Me.a_r.Size = New System.Drawing.Size(34, 17)
        Me.a_r.TabIndex = 0
        Me.a_r.Tag = "1"
        Me.a_r.Text = "R"
        Me.a_r.UseVisualStyleBackColor = True
        '
        'combiner_active_cb
        '
        Me.combiner_active_cb.Appearance = System.Windows.Forms.Appearance.Button
        Me.combiner_active_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.combiner_active_cb.Location = New System.Drawing.Point(390, 316)
        Me.combiner_active_cb.Name = "combiner_active_cb"
        Me.combiner_active_cb.Size = New System.Drawing.Size(68, 24)
        Me.combiner_active_cb.TabIndex = 6
        Me.combiner_active_cb.Text = "Active"
        Me.combiner_active_cb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.combiner_active_cb.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*"
        '
        'r_track
        '
        Me.r_track.AutoSize = False
        Me.r_track.Location = New System.Drawing.Point(291, 60)
        Me.r_track.Maximum = 125
        Me.r_track.Name = "r_track"
        Me.r_track.Size = New System.Drawing.Size(171, 16)
        Me.r_track.TabIndex = 6
        Me.r_track.TickStyle = System.Windows.Forms.TickStyle.None
        Me.r_track.Value = 100
        '
        'r_text
        '
        Me.r_text.AutoSize = True
        Me.r_text.Font = New System.Drawing.Font("Segoe Marker", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_text.Location = New System.Drawing.Point(263, 60)
        Me.r_text.Name = "r_text"
        Me.r_text.Size = New System.Drawing.Size(22, 13)
        Me.r_text.TabIndex = 8
        Me.r_text.Text = "100"
        Me.r_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_text
        '
        Me.g_text.AutoSize = True
        Me.g_text.Font = New System.Drawing.Font("Segoe Marker", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_text.Location = New System.Drawing.Point(263, 135)
        Me.g_text.Name = "g_text"
        Me.g_text.Size = New System.Drawing.Size(22, 13)
        Me.g_text.TabIndex = 10
        Me.g_text.Text = "100"
        Me.g_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'g_track
        '
        Me.g_track.AutoSize = False
        Me.g_track.Location = New System.Drawing.Point(291, 135)
        Me.g_track.Maximum = 125
        Me.g_track.Name = "g_track"
        Me.g_track.Size = New System.Drawing.Size(171, 16)
        Me.g_track.TabIndex = 9
        Me.g_track.TickStyle = System.Windows.Forms.TickStyle.None
        Me.g_track.Value = 100
        '
        'a_text
        '
        Me.a_text.AutoSize = True
        Me.a_text.Font = New System.Drawing.Font("Segoe Marker", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_text.Location = New System.Drawing.Point(263, 294)
        Me.a_text.Name = "a_text"
        Me.a_text.Size = New System.Drawing.Size(22, 13)
        Me.a_text.TabIndex = 12
        Me.a_text.Text = "100"
        Me.a_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'a_track
        '
        Me.a_track.AutoSize = False
        Me.a_track.Location = New System.Drawing.Point(291, 294)
        Me.a_track.Maximum = 125
        Me.a_track.Name = "a_track"
        Me.a_track.Size = New System.Drawing.Size(171, 16)
        Me.a_track.TabIndex = 11
        Me.a_track.TickStyle = System.Windows.Forms.TickStyle.None
        Me.a_track.Value = 100
        '
        'b_text
        '
        Me.b_text.AutoSize = True
        Me.b_text.Font = New System.Drawing.Font("Segoe Marker", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_text.Location = New System.Drawing.Point(263, 216)
        Me.b_text.Name = "b_text"
        Me.b_text.Size = New System.Drawing.Size(22, 13)
        Me.b_text.TabIndex = 14
        Me.b_text.Text = "100"
        Me.b_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'b_track
        '
        Me.b_track.AutoSize = False
        Me.b_track.Location = New System.Drawing.Point(291, 216)
        Me.b_track.Maximum = 125
        Me.b_track.Name = "b_track"
        Me.b_track.Size = New System.Drawing.Size(171, 16)
        Me.b_track.TabIndex = 13
        Me.b_track.TickStyle = System.Windows.Forms.TickStyle.None
        Me.b_track.Value = 100
        '
        'frmCombiner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(468, 348)
        Me.Controls.Add(Me.b_text)
        Me.Controls.Add(Me.b_track)
        Me.Controls.Add(Me.a_text)
        Me.Controls.Add(Me.a_track)
        Me.Controls.Add(Me.g_text)
        Me.Controls.Add(Me.g_track)
        Me.Controls.Add(Me.r_text)
        Me.Controls.Add(Me.r_track)
        Me.Controls.Add(Me.combiner_active_cb)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.red_group)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCombiner"
        Me.Text = "Combiner"
        Me.TopMost = True
        Me.red_group.ResumeLayout(False)
        Me.red_group.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.r_track, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_track, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a_track, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b_track, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents red_group As System.Windows.Forms.GroupBox
    Friend WithEvents r_filename As System.Windows.Forms.TextBox
    Friend WithEvents r_open As System.Windows.Forms.Button
    Friend WithEvents r_a As System.Windows.Forms.RadioButton
    Friend WithEvents r_b As System.Windows.Forms.RadioButton
    Friend WithEvents r_g As System.Windows.Forms.RadioButton
    Friend WithEvents r_r As System.Windows.Forms.RadioButton
    Friend WithEvents r_enable As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents g_enable As System.Windows.Forms.CheckBox
    Friend WithEvents g_filename As System.Windows.Forms.TextBox
    Friend WithEvents g_open As System.Windows.Forms.Button
    Friend WithEvents g_a As System.Windows.Forms.RadioButton
    Friend WithEvents g_b As System.Windows.Forms.RadioButton
    Friend WithEvents g_g As System.Windows.Forms.RadioButton
    Friend WithEvents g_r As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents b_enable As System.Windows.Forms.CheckBox
    Friend WithEvents b_filename As System.Windows.Forms.TextBox
    Friend WithEvents b_open As System.Windows.Forms.Button
    Friend WithEvents b_a As System.Windows.Forms.RadioButton
    Friend WithEvents b_b As System.Windows.Forms.RadioButton
    Friend WithEvents b_g As System.Windows.Forms.RadioButton
    Friend WithEvents b_r As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents a_enable As System.Windows.Forms.CheckBox
    Friend WithEvents a_filename As System.Windows.Forms.TextBox
    Friend WithEvents a_open As System.Windows.Forms.Button
    Friend WithEvents a_a As System.Windows.Forms.RadioButton
    Friend WithEvents a_b As System.Windows.Forms.RadioButton
    Friend WithEvents a_g As System.Windows.Forms.RadioButton
    Friend WithEvents a_r As System.Windows.Forms.RadioButton
    Friend WithEvents combiner_active_cb As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents r_track As System.Windows.Forms.TrackBar
    Friend WithEvents r_text As System.Windows.Forms.Label
    Friend WithEvents g_text As System.Windows.Forms.Label
    Friend WithEvents g_track As System.Windows.Forms.TrackBar
    Friend WithEvents a_text As System.Windows.Forms.Label
    Friend WithEvents a_track As System.Windows.Forms.TrackBar
    Friend WithEvents b_text As System.Windows.Forms.Label
    Friend WithEvents b_track As System.Windows.Forms.TrackBar
End Class
