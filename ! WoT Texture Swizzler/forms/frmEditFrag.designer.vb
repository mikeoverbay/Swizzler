<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditFrag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditFrag))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.vert_tb = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.CTM1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cm_cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cm_copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cm_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cm_undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.frag_tb = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.CTM2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cm2_cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cm2_copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm2_paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cm2_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cm2_undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.recompile_bt = New System.Windows.Forms.Button()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.vert_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTM1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.frag_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTM2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(3, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(527, 467)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.vert_tb)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(519, 441)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vertex Program"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'vert_tb
        '
        Me.vert_tb.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.vert_tb.AutoIndent = False
        Me.vert_tb.AutoIndentChars = False
        Me.vert_tb.AutoIndentExistingLines = False
        Me.vert_tb.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.vert_tb.BackBrush = Nothing
        Me.vert_tb.BackColor = System.Drawing.Color.Black
        Me.vert_tb.CaretColor = System.Drawing.Color.White
        Me.vert_tb.CharHeight = 14
        Me.vert_tb.CharWidth = 8
        Me.vert_tb.ContextMenuStrip = Me.CTM1
        Me.vert_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vert_tb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.vert_tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vert_tb.ForeColor = System.Drawing.Color.White
        Me.vert_tb.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vert_tb.IsReplaceMode = False
        Me.vert_tb.LineNumberColor = System.Drawing.Color.Cyan
        Me.vert_tb.Location = New System.Drawing.Point(3, 3)
        Me.vert_tb.Name = "vert_tb"
        Me.vert_tb.Paddings = New System.Windows.Forms.Padding(0)
        Me.vert_tb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vert_tb.ServiceColors = CType(resources.GetObject("vert_tb.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.vert_tb.Size = New System.Drawing.Size(513, 435)
        Me.vert_tb.TabIndex = 0
        Me.vert_tb.Zoom = 100
        '
        'CTM1
        '
        Me.CTM1.AutoSize = False
        Me.CTM1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cm_cut, Me.ToolStripSeparator2, Me.cm_copy, Me.cm_paste, Me.ToolStripSeparator3, Me.cm_delete, Me.ToolStripSeparator5, Me.cm_undo, Me.cm_redo})
        Me.CTM1.Name = "CTM1"
        Me.CTM1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CTM1.Size = New System.Drawing.Size(100, 175)
        '
        'cm_cut
        '
        Me.cm_cut.AutoSize = False
        Me.cm_cut.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Cut_6523
        Me.cm_cut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm_cut.Name = "cm_cut"
        Me.cm_cut.Size = New System.Drawing.Size(152, 22)
        Me.cm_cut.Text = "Cut"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(96, 6)
        '
        'cm_copy
        '
        Me.cm_copy.AutoSize = False
        Me.cm_copy.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Copy_6524
        Me.cm_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm_copy.Name = "cm_copy"
        Me.cm_copy.Size = New System.Drawing.Size(152, 22)
        Me.cm_copy.Text = "Copy"
        '
        'cm_paste
        '
        Me.cm_paste.AutoSize = False
        Me.cm_paste.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Paste_6520
        Me.cm_paste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm_paste.Name = "cm_paste"
        Me.cm_paste.Size = New System.Drawing.Size(152, 22)
        Me.cm_paste.Text = "Paste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(96, 6)
        '
        'cm_delete
        '
        Me.cm_delete.AutoSize = False
        Me.cm_delete.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Clearallrequests_8816
        Me.cm_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm_delete.Name = "cm_delete"
        Me.cm_delete.Size = New System.Drawing.Size(152, 22)
        Me.cm_delete.Text = "Delete"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(96, 6)
        '
        'cm_undo
        '
        Me.cm_undo.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Undo_16x
        Me.cm_undo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm_undo.Name = "cm_undo"
        Me.cm_undo.Size = New System.Drawing.Size(107, 22)
        Me.cm_undo.Text = "Undo"
        '
        'cm_redo
        '
        Me.cm_redo.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Redo_16x
        Me.cm_redo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm_redo.Name = "cm_redo"
        Me.cm_redo.Size = New System.Drawing.Size(107, 22)
        Me.cm_redo.Text = "Redo"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.frag_tb)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(519, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fragment Program"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frag_tb
        '
        Me.frag_tb.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.frag_tb.AutoIndent = False
        Me.frag_tb.AutoIndentChars = False
        Me.frag_tb.AutoIndentExistingLines = False
        Me.frag_tb.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.frag_tb.BackBrush = Nothing
        Me.frag_tb.BackColor = System.Drawing.Color.Black
        Me.frag_tb.CaretColor = System.Drawing.Color.White
        Me.frag_tb.CharHeight = 14
        Me.frag_tb.CharWidth = 8
        Me.frag_tb.ContextMenuStrip = Me.CTM2
        Me.frag_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.frag_tb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.frag_tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frag_tb.ForeColor = System.Drawing.Color.White
        Me.frag_tb.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.frag_tb.IsReplaceMode = False
        Me.frag_tb.LineNumberColor = System.Drawing.Color.Cyan
        Me.frag_tb.Location = New System.Drawing.Point(3, 3)
        Me.frag_tb.Name = "frag_tb"
        Me.frag_tb.Paddings = New System.Windows.Forms.Padding(0)
        Me.frag_tb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.frag_tb.ServiceColors = CType(resources.GetObject("frag_tb.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.frag_tb.Size = New System.Drawing.Size(513, 435)
        Me.frag_tb.TabIndex = 0
        Me.frag_tb.Zoom = 100
        '
        'CTM2
        '
        Me.CTM2.AutoSize = False
        Me.CTM2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cm2_cut, Me.ToolStripSeparator1, Me.cm2_copy, Me.cm2_paste, Me.ToolStripSeparator4, Me.cm2_delete, Me.ToolStripSeparator6, Me.cm2_undo, Me.Redo})
        Me.CTM2.Name = "CTM1"
        Me.CTM2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CTM2.Size = New System.Drawing.Size(100, 175)
        '
        'cm2_cut
        '
        Me.cm2_cut.AutoSize = False
        Me.cm2_cut.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Cut_6523
        Me.cm2_cut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm2_cut.Name = "cm2_cut"
        Me.cm2_cut.Size = New System.Drawing.Size(152, 22)
        Me.cm2_cut.Text = "Cut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(96, 6)
        '
        'cm2_copy
        '
        Me.cm2_copy.AutoSize = False
        Me.cm2_copy.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Copy_6524
        Me.cm2_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm2_copy.Name = "cm2_copy"
        Me.cm2_copy.Size = New System.Drawing.Size(152, 22)
        Me.cm2_copy.Text = "Copy"
        '
        'cm2_paste
        '
        Me.cm2_paste.AutoSize = False
        Me.cm2_paste.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Paste_6520
        Me.cm2_paste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm2_paste.Name = "cm2_paste"
        Me.cm2_paste.Size = New System.Drawing.Size(152, 22)
        Me.cm2_paste.Text = "Paste"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(96, 6)
        '
        'cm2_delete
        '
        Me.cm2_delete.AutoSize = False
        Me.cm2_delete.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Clearallrequests_8816
        Me.cm2_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm2_delete.Name = "cm2_delete"
        Me.cm2_delete.Size = New System.Drawing.Size(152, 22)
        Me.cm2_delete.Text = "Delete"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(96, 6)
        '
        'cm2_undo
        '
        Me.cm2_undo.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Undo_16x
        Me.cm2_undo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cm2_undo.Name = "cm2_undo"
        Me.cm2_undo.Size = New System.Drawing.Size(107, 22)
        Me.cm2_undo.Text = "Undo"
        '
        'Redo
        '
        Me.Redo.Image = Global.WoT_Texture_Swizzler.My.Resources.Resources.Redo_16x
        Me.Redo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Redo.Name = "Redo"
        Me.Redo.Size = New System.Drawing.Size(107, 22)
        Me.Redo.Text = "Redo"
        '
        'recompile_bt
        '
        Me.recompile_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recompile_bt.ForeColor = System.Drawing.Color.Black
        Me.recompile_bt.Location = New System.Drawing.Point(440, 469)
        Me.recompile_bt.Name = "recompile_bt"
        Me.recompile_bt.Size = New System.Drawing.Size(75, 23)
        Me.recompile_bt.TabIndex = 4
        Me.recompile_bt.Text = "Recompile"
        Me.recompile_bt.UseVisualStyleBackColor = True
        '
        'CB1
        '
        Me.CB1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CB1.BackColor = System.Drawing.Color.Black
        Me.CB1.ForeColor = System.Drawing.Color.White
        Me.CB1.FormattingEnabled = True
        Me.CB1.Location = New System.Drawing.Point(81, 471)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(153, 21)
        Me.CB1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 475)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Shader"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.WoT_Texture_Swizzler.My.Resources.Resources.question
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(406, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEditFrag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 497)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.recompile_bt)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditFrag"
        Me.Text = "Shader Program Editor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.vert_tb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTM1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.frag_tb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTM2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
	Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
	Friend WithEvents recompile_bt As System.Windows.Forms.Button
	Friend WithEvents CB1 As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents vert_tb As FastColoredTextBoxNS.FastColoredTextBox
	Friend WithEvents frag_tb As FastColoredTextBoxNS.FastColoredTextBox
	Friend WithEvents CTM1 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents cm_cut As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm_copy As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents cm_paste As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm_delete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CTM2 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents cm2_cut As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm2_copy As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents cm2_paste As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm2_delete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm_undo As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents cm_redo As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm2_undo As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Redo As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
