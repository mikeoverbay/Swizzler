#Region "imports"
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Web
Imports Tao.OpenGl
Imports Tao.Platform.Windows
Imports Tao.FreeGlut
Imports Tao.FreeGlut.Glut
Imports Tao.DevIl
Imports Microsoft.VisualBasic.Strings
Imports System.Math
Imports System.Object
Imports System.Threading
Imports System.Data
#End Region



Public Class frmCombiner
    Private Sub frmCombiner_Load(sender As Object, e As EventArgs) Handles Me.Load
        assign_event_handlers()
        R_ = 1
        G_ = 2
        B_ = 4
        A_ = 8

    End Sub
    Private Sub frmCombiner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
        frmMain.m_combiner.Checked = False
    End Sub

    Private Sub assign_event_handlers()
        '--------------------------------------
        AddHandler r_r.Click, AddressOf r_assign_r
        AddHandler r_g.Click, AddressOf r_assign_r
        AddHandler r_b.Click, AddressOf r_assign_r
        AddHandler r_a.Click, AddressOf r_assign_r
        '--------------------------------------
        AddHandler g_r.Click, AddressOf g_assign_g
        AddHandler g_g.Click, AddressOf g_assign_g
        AddHandler g_b.Click, AddressOf g_assign_g
        AddHandler g_a.Click, AddressOf g_assign_g
        '--------------------------------------
        AddHandler b_r.Click, AddressOf b_assign_b
        AddHandler b_g.Click, AddressOf b_assign_b
        AddHandler b_b.Click, AddressOf b_assign_b
        AddHandler b_a.Click, AddressOf b_assign_b
        '--------------------------------------
        AddHandler a_r.Click, AddressOf a_assign_a
        AddHandler a_g.Click, AddressOf a_assign_a
        AddHandler a_b.Click, AddressOf a_assign_a
        AddHandler a_a.Click, AddressOf a_assign_a

        AddHandler r_open.Click, AddressOf load_combiner_image
        AddHandler g_open.Click, AddressOf load_combiner_image
        AddHandler b_open.Click, AddressOf load_combiner_image
        AddHandler a_open.Click, AddressOf load_combiner_image

        AddHandler r_enable.Click, AddressOf handle_enables
        AddHandler g_enable.Click, AddressOf handle_enables
        AddHandler b_enable.Click, AddressOf handle_enables
        AddHandler a_enable.Click, AddressOf handle_enables
    End Sub
    Private Sub handle_enables(sender As Object, e As EventArgs)
        If sender.checked Then
            sender.backcolor = Color.Orange
        Else
            sender.backcolor = Color.Silver
        End If
        sender = DirectCast(sender, CheckBox)
        frmMain.draw(True)
        frmMain.draw(True)

    End Sub

    Private Sub find_largest_image()
        'find out if this is the largest loaded image.
        get_max_size()
        rect_size = combiner_image_size
        rect_location = New Point(0, 0)
        'we just loaded a file in combiner so lets set rendering mode for combiner.
    End Sub

    Private Sub load_combiner_image(sender As Object, e As EventArgs)
        Dim switch As Integer = Int(sender.tag)
        If open_file(switch) = "" Then Return
        Select Case switch
            Case 1
                r_filename.Text = Path.GetFileName(source_filename)
                cb_image_r = current_texture_id(1)
                find_largest_image()
                r_enable.Checked = True
                r_enable.BackColor = Color.Orange
            Case 2
                g_filename.Text = Path.GetFileName(source_filename)
                cb_image_g = current_texture_id(2)
                find_largest_image()
                g_enable.Checked = True
                g_enable.BackColor = Color.Orange
            Case 4
                b_filename.Text = Path.GetFileName(source_filename)
                cb_image_b = current_texture_id(4)
                find_largest_image()
                b_enable.Checked = True
                b_enable.BackColor = Color.Orange
            Case 8
                a_filename.Text = Path.GetFileName(source_filename)
                cb_image_a = current_texture_id(8)
                find_largest_image()
                a_enable.Checked = True
                a_enable.BackColor = Color.Orange
        End Select
        combiner_active_cb.Checked = True
        frmMain.draw(True)
        frmMain.draw(True)

    End Sub

    Private Function open_file(ByVal id As Integer) As String
        OpenFileDialog1.Title = "Load Image"
        OpenFileDialog1.Filter = "DDS (DXT) (*.dds)|*.dds|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp|JPG (*.jpg)|*.jpg"
        If OpenFileDialog1.ShowDialog = Forms.DialogResult.OK Then
            source_filename = OpenFileDialog1.FileName
            Gl.glDeleteTextures(1, current_texture_id(id))
            Gl.glFinish()
            current_texture_id(id) = frmMain.load_image(source_filename, False)
            If current_texture_id(id) = -1 Then
                MsgBox("Could not open " + vbCrLf + source_filename, MsgBoxStyle.Exclamation, "File IO Error...")
                current_texture_id(id) = -1
                source_filename = "No File"
                Return ""
            End If
        End If
        Return source_filename
    End Function

    Private Sub r_assign_r(sender As Object, e As EventArgs)
        sender = DirectCast(sender, RadioButton)
        If Not _Started Then Return
        C_R_ = C_R_ And CInt(sender.tag)
        C_R_ = C_R_ Or CInt(sender.tag)
        frmMain.draw(True)
    End Sub
    Private Sub g_assign_g(sender As Object, e As EventArgs)
        sender = DirectCast(sender, RadioButton)
        If Not _Started Then Return
        C_G_ = C_G_ And CInt(sender.tag)
        C_G_ = C_G_ Or CInt(sender.tag)
        frmMain.draw(True)
    End Sub
    Private Sub b_assign_b(sender As Object, e As EventArgs)
        sender = DirectCast(sender, RadioButton)
        If Not _Started Then Return
        C_B_ = C_B_ And CInt(sender.tag)
        C_B_ = C_B_ Or CInt(sender.tag)
        frmMain.draw(True)
    End Sub
    Private Sub a_assign_a(sender As Object, e As EventArgs)
        sender = DirectCast(sender, RadioButton)
        If Not _Started Then Return
        C_A_ = C_A_ And CInt(sender.tag)
        C_A_ = C_A_ Or CInt(sender.tag)
        frmMain.draw(True)
    End Sub

    Private Sub combiner_active_cb_CheckedChanged(sender As Object, e As EventArgs) Handles combiner_active_cb.CheckedChanged
        'If combiner_active_cb.Checked Then
        '    old_sImageHeight = sImageHeight
        '    old_sImageWidth = sImageWidth
        '    old_rect_size = rect_size
        '    old_rect_location = rect_location

        'Else
        '    sImageHeight = old_sImageHeight
        '    sImageWidth = old_sImageWidth
        '    old_rect_size = rect_size
        '    old_rect_location = rect_location

        'End If
        If combiner_active_cb.Checked Then
            sImageWidth = combiner_image_size.X
            sImageHeight = combiner_image_size.Y
            rect_size = combiner_rec_size
            rect_location = New Point(0, 0)
            sBox.Width = sImageWidth
            sBox.Height = sImageHeight
            old_w = sImageWidth
            old_h = sImageHeight
            If temp_image > 0 Then
                Gl.glDeleteTextures(1, temp_image)
                Gl.glDeleteTextures(1, temp_image2)
            End If
            frmMain.create_temp_image()
            frmMain.create_temp2()
        Else
            sImageWidth = old_sImageWidth
            sImageHeight = old_sImageHeight
            rect_size = old_rect_size
            rect_location = New Point(0, 0)
            sBox = old_sbox
            old_w = sImageWidth
            old_h = sImageHeight
            If temp_image > 0 Then
                Gl.glDeleteTextures(1, temp_image)
                Gl.glDeleteTextures(1, temp_image2)
            End If
            frmMain.create_temp_image()
            frmMain.create_temp2()

        End If
        Zoom_Factor = 1.0
        frmMain.draw(True)
        frmMain.draw(True)
        frmMain.draw(True)

    End Sub


    Private Sub get_max_size()
        Dim x, y, w, h As Integer
        x = 0 : y = 0
        get_texture_size_from_id(w, h, cb_image_r)
        If w >= x Then x = w : If h >= y Then y = h
        get_texture_size_from_id(w, h, cb_image_g)
        If w >= x Then x = w : If h >= y Then y = h
        get_texture_size_from_id(w, h, cb_image_b)
        If w >= x Then x = w : If h >= y Then y = h
        get_texture_size_from_id(w, h, cb_image_a)
        If w >= x Then x = w : If h >= y Then y = h

        combiner_image_size.X = x
        combiner_rec_size.X = x
        sBox.Width = x

        combiner_image_size.Y = y
        combiner_rec_size.Y = y
        sBox.Height = y

    End Sub
    Private Sub get_texture_size_from_id(ByRef w As Integer, ByRef h As Integer, ByVal id As Integer)
        Dim miplevel As Integer = 0
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, id)
        Gl.glGetTexLevelParameteriv(Gl.GL_TEXTURE_2D, miplevel, Gl.GL_TEXTURE_WIDTH, w)
        Gl.glGetTexLevelParameteriv(Gl.GL_TEXTURE_2D, miplevel, Gl.GL_TEXTURE_HEIGHT, h)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
    End Sub


    Private Sub r_track_Scroll(sender As Object, e As EventArgs) Handles r_track.Scroll
        r_text.Text = r_track.Value.ToString
        frmMain.draw(True)
    End Sub

    Private Sub g_track_Scroll(sender As Object, e As EventArgs) Handles g_track.Scroll
        g_text.Text = g_track.Value.ToString
        frmMain.draw(True)
    End Sub

    Private Sub b_track_Scroll(sender As Object, e As EventArgs) Handles b_track.Scroll
        b_text.Text = b_track.Value.ToString
        frmMain.draw(True)
    End Sub

    Private Sub a_track_Scroll(sender As Object, e As EventArgs) Handles a_track.Scroll
        a_text.Text = a_track.Value.ToString
        frmMain.draw(True)
    End Sub
End Class