<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaveOptions
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.png_rb = New System.Windows.Forms.RadioButton()
        Me.jpg_rb = New System.Windows.Forms.RadioButton()
        Me.bitmap_rb = New System.Windows.Forms.RadioButton()
        Me.dx5_rb = New System.Windows.Forms.RadioButton()
        Me.mipmaps_cb = New System.Windows.Forms.CheckBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.format_group_box = New System.Windows.Forms.GroupBox()
        Me.BC1 = New System.Windows.Forms.RadioButton()
        Me.BC2 = New System.Windows.Forms.RadioButton()
        Me.BC3 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.format_group_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.png_rb)
        Me.GroupBox1.Controls.Add(Me.jpg_rb)
        Me.GroupBox1.Controls.Add(Me.bitmap_rb)
        Me.GroupBox1.Controls.Add(Me.dx5_rb)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Save As"
        '
        'png_rb
        '
        Me.png_rb.AutoSize = True
        Me.png_rb.Checked = True
        Me.png_rb.Location = New System.Drawing.Point(18, 80)
        Me.png_rb.Name = "png_rb"
        Me.png_rb.Size = New System.Drawing.Size(48, 17)
        Me.png_rb.TabIndex = 3
        Me.png_rb.TabStop = True
        Me.png_rb.Text = "PNG"
        Me.png_rb.UseVisualStyleBackColor = True
        '
        'jpg_rb
        '
        Me.jpg_rb.AutoSize = True
        Me.jpg_rb.Location = New System.Drawing.Point(18, 19)
        Me.jpg_rb.Name = "jpg_rb"
        Me.jpg_rb.Size = New System.Drawing.Size(45, 17)
        Me.jpg_rb.TabIndex = 2
        Me.jpg_rb.Text = "JPG"
        Me.jpg_rb.UseVisualStyleBackColor = True
        '
        'bitmap_rb
        '
        Me.bitmap_rb.AutoSize = True
        Me.bitmap_rb.Location = New System.Drawing.Point(18, 60)
        Me.bitmap_rb.Name = "bitmap_rb"
        Me.bitmap_rb.Size = New System.Drawing.Size(57, 17)
        Me.bitmap_rb.TabIndex = 1
        Me.bitmap_rb.Text = "Bitmap"
        Me.bitmap_rb.UseVisualStyleBackColor = True
        '
        'dx5_rb
        '
        Me.dx5_rb.AutoSize = True
        Me.dx5_rb.Location = New System.Drawing.Point(18, 39)
        Me.dx5_rb.Name = "dx5_rb"
        Me.dx5_rb.Size = New System.Drawing.Size(48, 17)
        Me.dx5_rb.TabIndex = 0
        Me.dx5_rb.Text = "DDS"
        Me.dx5_rb.UseVisualStyleBackColor = True
        '
        'mipmaps_cb
        '
        Me.mipmaps_cb.AutoSize = True
        Me.mipmaps_cb.Enabled = False
        Me.mipmaps_cb.ForeColor = System.Drawing.Color.White
        Me.mipmaps_cb.Location = New System.Drawing.Point(138, 107)
        Me.mipmaps_cb.Name = "mipmaps_cb"
        Me.mipmaps_cb.Size = New System.Drawing.Size(103, 17)
        Me.mipmaps_cb.TabIndex = 1
        Me.mipmaps_cb.Text = "Create MipMaps"
        Me.mipmaps_cb.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(138, 130)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(50, 23)
        Me.save_btn.TabIndex = 2
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(67, 130)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(50, 23)
        Me.cancel_btn.TabIndex = 3
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'format_group_box
        '
        Me.format_group_box.Controls.Add(Me.BC3)
        Me.format_group_box.Controls.Add(Me.BC2)
        Me.format_group_box.Controls.Add(Me.BC1)
        Me.format_group_box.Enabled = False
        Me.format_group_box.ForeColor = System.Drawing.Color.White
        Me.format_group_box.Location = New System.Drawing.Point(138, 12)
        Me.format_group_box.Name = "format_group_box"
        Me.format_group_box.Size = New System.Drawing.Size(103, 89)
        Me.format_group_box.TabIndex = 4
        Me.format_group_box.TabStop = False
        Me.format_group_box.Text = "DDS Format"
        '
        'BC1
        '
        Me.BC1.AutoSize = True
        Me.BC1.Location = New System.Drawing.Point(17, 19)
        Me.BC1.Name = "BC1"
        Me.BC1.Size = New System.Drawing.Size(71, 17)
        Me.BC1.TabIndex = 0
        Me.BC1.Text = "DDS BC1"
        Me.BC1.UseVisualStyleBackColor = True
        '
        'BC2
        '
        Me.BC2.AutoSize = True
        Me.BC2.Checked = True
        Me.BC2.Location = New System.Drawing.Point(17, 39)
        Me.BC2.Name = "BC2"
        Me.BC2.Size = New System.Drawing.Size(71, 17)
        Me.BC2.TabIndex = 1
        Me.BC2.TabStop = True
        Me.BC2.Text = "DDS BC3"
        Me.BC2.UseVisualStyleBackColor = True
        '
        'BC3
        '
        Me.BC3.AutoSize = True
        Me.BC3.Location = New System.Drawing.Point(17, 60)
        Me.BC3.Name = "BC3"
        Me.BC3.Size = New System.Drawing.Size(71, 17)
        Me.BC3.TabIndex = 2
        Me.BC3.Text = "DDS BC5"
        Me.BC3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WoT_Texture_Swizzler.My.Resources.Resources.question
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSaveOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(256, 161)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.format_group_box)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.mipmaps_cb)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSaveOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Save Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.format_group_box.ResumeLayout(False)
        Me.format_group_box.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents jpg_rb As System.Windows.Forms.RadioButton
    Friend WithEvents bitmap_rb As System.Windows.Forms.RadioButton
    Friend WithEvents dx5_rb As System.Windows.Forms.RadioButton
    Friend WithEvents mipmaps_cb As System.Windows.Forms.CheckBox
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents png_rb As System.Windows.Forms.RadioButton
    Friend WithEvents format_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents BC3 As System.Windows.Forms.RadioButton
    Friend WithEvents BC2 As System.Windows.Forms.RadioButton
    Friend WithEvents BC1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
