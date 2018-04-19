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


Public Class frmMain
#Region "variables"
    Private Zoom_Factor As Single
    Private mouse_pos As New Point
    Private rect_location As New Point
    Private rect_size As New Point
    Private mouse_down As Boolean = False
    Private mouse_delta As New Point

    Public image_type As String
    Public checkerboard_id As Integer
    Public attachstatus(5) As Integer
    Public color_mask As vect4
    Public alpha_percent
    Public use_alpha_blend As Integer
    Public Structure vect4
        Public x As Single
        Public y As Single
        Public z As Single
        Public w As Single
    End Structure

    Protected dds_format As Integer
    Structure v4_
        Public r As Single
        Public g As Single
        Public b As Single
        Public a As Single
    End Structure
    Public R_ As Integer = 1
    Public G_ As Integer = 2
    Public B_ As Integer = 4
    Public A_ As Integer = 8

    Public source_filename As String = "No File"
    Public mask_filename As String = "No File"
    Public destination_filename As String = "No File"
    Public temp_image As Integer = -1
    Public temp_image2 As Integer = -1
    Public sImageWidth As Integer
    Public sImageHeight As Integer
    Private _zoom_ As Single = 1.0
    Public old_h, old_w As Integer

    Public form_loaded As Boolean = False

    Public _Started As Boolean = False
    Public _printing As Boolean = False

    Public current_texture_swizz As Integer = -1
#End Region



    Private Sub frmSwizzler_Load(sender As Object, e As EventArgs) Handles Me.Load
        EnableOpenGL()

        Il.ilInit()
        Ilu.iluInit()
        Ilut.ilutInit()
        Ilut.ilutRenderer(Ilut.ILUT_OPENGL)
        'make_device()
        Me.Visible = True
        Me.Show()
        pb1.Visible = False
        pb1.SendToBack()
        assign_event_handlers()

        checkerboard_id = load_DDS(Application.StartupPath + "\textures\checkerboard.dds")

        color_mask.x = 1.0
        color_mask.y = 1.0
        color_mask.z = 1.0
        color_mask.w = 1.0


        R_ = 1
        G_ = 2
        B_ = 4
        A_ = 8
        _zoom_ = 1.0

        'change backcolor of a few things
        reset_btn.BackColor = Color.Silver
        quater_cb.BackColor = Color.Silver
        scale_up_btn.BackColor = Color.Silver
        scale_down_btn.BackColor = Color.Silver
        ComboBox1.BackColor = Color.Silver
        mask_tb.BackColor = Color.Silver

        'start alert timer
        Timer1.Start()
        Me.Text = "RGBA Channel Swizzler  Version:" + Application.ProductVersion
        mask_tb.Text = "No Mask file"
        Application.DoEvents()


        _Started = True
        ComboBox1.SelectedIndex = 10
    End Sub

    Private Sub frmSwizzler_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Normal
        If temp_image > -1 Then
            Gl.glDeleteTextures(1, temp_image)
        End If
        If temp_image2 > -1 Then
            Gl.glDeleteTextures(1, temp_image2)
        End If
        Me.WindowState = FormWindowState.Normal
        'device.Dispose()
        Wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero)
        Wgl.wglDeleteContext(pb1_hRC)
        Wgl.wglDeleteContext(pb3_hRC)

    End Sub

    Private Sub frmSwizzler_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Not _Started Then Return
        pb3.Width = Me.ClientSize.Width - Panel1.Width
        pb3.Height = Me.ClientSize.Height - (Me.MenuStrip.Height + Me.top_panel.Height)
        pb3.Location = New Point(Panel1.Width, Me.MenuStrip.Height + Me.top_panel.Height)
        sBox.location = New Point((pb3.Width - sBox.Width) / 2, (pb3.Height - sBox.Height) / 2)
        draw(True)

    End Sub

    Private Sub frmSwizzler_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        form_loaded = True
    End Sub

    Private Sub frmSwizzler_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Not _Started Then Return
        pb3.Width = Me.ClientSize.Width - Panel1.Width
        pb3.Height = Me.ClientSize.Height - (Me.MenuStrip.Height + Me.top_panel.Height)
        pb3.Location = New Point(Panel1.Width, Me.MenuStrip.Height + Me.top_panel.Height)
        sBox.location = New Point((pb3.Width - sBox.Width) / 2, (pb3.Height - sBox.Height) / 2)
        'draw(True)

    End Sub


    Public Function load_DDS(ByVal path As String) As Integer
        Dim tex As Integer = Il.ilGenImage
        Il.ilBindImage(tex)
        Il.ilLoad(Il.IL_DDS, path)
        Dim e As Integer = Il.ilGetError
        If e <> 0 Then
            Il.ilDeleteImage(tex)
            Return -1
        End If

        Dim x = Il.ilGetInteger(Il.IL_IMAGE_WIDTH)
        Dim y = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT)
        Gl.glEnable(Gl.GL_TEXTURE_2D)
        Dim tID As Integer
        Gl.glGenTextures(1, tID)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, tID)

        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR_MIPMAP_LINEAR)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT)

        Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Il.ilGetInteger(Il.IL_IMAGE_BPP), Il.ilGetInteger(Il.IL_IMAGE_WIDTH), _
        Il.ilGetInteger(Il.IL_IMAGE_HEIGHT), 0, Il.ilGetInteger(Il.IL_IMAGE_FORMAT), Gl.GL_UNSIGNED_BYTE, _
        Il.ilGetData()) '  Texture specification 
        Gl.glGenerateMipmapEXT(Gl.GL_TEXTURE_2D)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        'Il.ilBindImage(0)
        Il.ilDeleteImage(tex)
        Return tID
    End Function

    Private Sub assign_event_handlers()
        '--------------------------------------
        AddHandler r_r.Click, AddressOf r_assign
        AddHandler r_g.Click, AddressOf r_assign
        AddHandler r_b.Click, AddressOf r_assign
        AddHandler r_a.Click, AddressOf r_assign
        '--------------------------------------
        AddHandler g_r.Click, AddressOf g_assign
        AddHandler g_g.Click, AddressOf g_assign
        AddHandler g_b.Click, AddressOf g_assign
        AddHandler g_a.Click, AddressOf g_assign
        '--------------------------------------
        AddHandler b_r.Click, AddressOf b_assign
        AddHandler b_g.Click, AddressOf b_assign
        AddHandler b_b.Click, AddressOf b_assign
        AddHandler b_a.Click, AddressOf b_assign
        '--------------------------------------
        AddHandler a_r.Click, AddressOf a_assign
        AddHandler a_g.Click, AddressOf a_assign
        AddHandler a_b.Click, AddressOf a_assign
        AddHandler a_a.Click, AddressOf a_assign

    End Sub

    Private Sub r_assign(sender As Object, e As EventArgs)
        If Not _Started Then Return
        R_ = R_ And CInt(sender.tag)
        R_ = R_ Or CInt(sender.tag)
        'render_to_temp_image()
        draw(True)
    End Sub
    Private Sub g_assign(sender As Object, e As EventArgs)
        If Not _Started Then Return
        G_ = G_ And CInt(sender.tag)
        G_ = G_ Or CInt(sender.tag)
        'render_to_temp_image()
        draw(True)
    End Sub
    Private Sub b_assign(sender As Object, e As EventArgs)
        If Not _Started Then Return
        B_ = B_ And CInt(sender.tag)
        B_ = B_ Or CInt(sender.tag)
        'render_to_temp_image()
        draw(True)
    End Sub
    Private Sub a_assign(sender As Object, e As EventArgs)
        If Not _Started Then Return
        A_ = A_ And CInt(sender.tag)
        A_ = A_ Or CInt(sender.tag)
        'render_to_temp_image()
        draw(True)
    End Sub


    '#################################################################################### draw

    Public Sub draw(ByVal resize As Boolean)
        If Not _Started Then Return
        If _printing Then Return
        'if we are printing, we cant change this context
        render_to_temp_image()
        If resize Then
            If Not (Wgl.wglMakeCurrent(pb3_hDC, pb3_hRC)) Then
                MessageBox.Show("Unable to make rendering context current")
                Return
            End If
            Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, 0)
            Gl.glDrawBuffer(Gl.GL_BACK)
        End If
        Gl.glTexEnvi(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE)
        If resize And Not _printing Then
            ViewOrtho2(pb3.Width, pb3.Height)

        End If

        Gl.glActiveTexture(Gl.GL_TEXTURE0)
        Gl.glClearColor(0.0F, 0.0F, 0.0F, 1.0F)
        Gl.glClear(Gl.GL_COLOR_BUFFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT)

        Gl.glDisable(Gl.GL_LIGHTING)

        Gl.glEnable(Gl.GL_DEPTH_TEST)
        If alpha_blend_cb.Checked Then
            Gl.glEnable(Gl.GL_BLEND)
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA)
        Else
            Gl.glDisable(Gl.GL_BLEND)
        End If
        '----------------------------------------------
        'draw checkboard background
        Gl.glPushMatrix()
        Gl.glTranslatef(0.0, 0.0, 0.5)
        Gl.glEnable(Gl.GL_TEXTURE_2D)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, checkerboard_id)
        'Gl.glBindTexture(Gl.GL_TEXTURE_2D, checkboard_id)
        Gl.glBegin(Gl.GL_QUADS)
        Dim v As Point = pb3.Size
        'Dim o = 
        Dim w As Single = pb3.Width / 320.0 ' size of the checker board
        Dim h As Single = pb3.Height / 320.0 ' size of the checker board
        'h = h / w
        Gl.glTexCoord2f(0.0, 0.0)
        Gl.glVertex3f(0.0, 0.0, -0.15)
        Gl.glTexCoord2f(0.0, h)
        Gl.glVertex3f(0.0, -v.Y, -0.15)
        Gl.glTexCoord2f(w, h)
        Gl.glVertex3f(v.X, -v.Y, -0.15)
        Gl.glTexCoord2f(w, 0.0)
        Gl.glVertex3f(v.X, 0.0, -0.15)
        Gl.glEnd()
        Gl.glPopMatrix()
        '----------------------------------------
        Gl.glEnable(Gl.GL_TEXTURE_2D)
        Gl.glUseProgram(color_pgm)
        Gl.glUniform4f(mask, color_mask.x, color_mask.y, color_mask.z, color_mask.w)
        Gl.glUniform1i(c_address, 0)
        If source_rb.Checked Then
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, current_texture_swizz)
        End If
        If show_mask_rb.Checked Then
            Gl.glUseProgram(0)
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, mask_texture)
        End If
        If output_rb.Checked Then
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, temp_image)

        End If
        'If GenMask_cb.Checked Then
        '    Gl.glEnable(Gl.GL_BLEND)
        '    Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA)
        '    Gl.glBindTexture(Gl.GL_TEXTURE_2D, temp_image)
        'End If
        'Gl.glBindTexture(Gl.GL_TEXTURE_2D, ModShadowMapping.depthTexture2)
        Gl.glPushMatrix()
        Gl.glTranslatef(0.0, 0.0F, -0.1F)
        Gl.glRotatef(0.0, 0.0, 0.0, 0.0)
        Gl.glScalef(1.0, 1.0, 1.0)
        Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL)

        'Gl.glEnable(Gl.GL_BLEND)

        Gl.glDisable(Gl.GL_LIGHTING)
        'Gl.glEnable(Gl.GL_BLEND)
        Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA)
        Gl.glColor4f(0.5, 0.5, 0.5, 0.0)
        Dim u4() As Single = {0.0, 1.0}
        Dim u3() As Single = {1.0, 1.0}
        Dim u2() As Single = {1.0, 0.0}
        Dim u1() As Single = {0.0, 0.0}

        Dim p1, p2, p3, p4 As Point
        Dim L, S As New Point
        L = rect_location
        S = rect_size
        L.Y *= -1
        S.Y *= -1

        p1 = L
        p2 = L
        p2.X += rect_size.X
        p3 = L + S
        p4 = L
        p4.Y += S.Y
        'draw and flip bufffers so the user can see the image
        Gl.glBegin(Gl.GL_QUADS)
        '---
        Gl.glTexCoord2fv(u1)
        Gl.glVertex2f(p1.X, p1.Y)
        Gl.glTexCoord2fv(u2)
        Gl.glVertex2f(p2.X, p2.Y)
        Gl.glTexCoord2fv(u3)
        Gl.glVertex2f(p3.X, p3.Y)
        Gl.glTexCoord2fv(u4)
        Gl.glVertex2f(p4.X, p4.Y)
        '--
        Gl.glEnd()

        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        Gl.glUseProgram(0)
        Gl.glEnable(Gl.GL_DEPTH_TEST)
        Gl.glDisable(Gl.GL_BLEND)
        Gl.glDisable(Gl.GL_TEXTURE_2D)


        Gl.glPopMatrix()
        Gl.glDisable(Gl.GL_DEPTH_TEST)



        Gl.glDisable(Gl.GL_TEXTURE_2D)
        draw_connections()
        If resize Then
            Gdi.SwapBuffers(pb3_hDC)
        End If
        'Application.DoEvents()
    End Sub
    Private Sub draw_connections()

        Gl.glDisable(Gl.GL_DEPTH_TEST)

        Gl.glColor4f(0.3, 0.3, 0.3, 0.7)
        Gl.glEnable(Gl.GL_BLEND)
        Gl.glBegin(Gl.GL_QUADS)

        Gl.glVertex3f(0.0, 110.0, 0.0)
        Gl.glVertex3f(0.0, 0.0, 0.0)
        Gl.glVertex3f(120.0, 0.0, 0.0)
        Gl.glVertex3f(120.0, 110.0, 0.0)
        Gl.glEnd()
        Gl.glDisable(Gl.GL_BLEND)
        Dim Ys() As Single = {0.0, 80.0, 60.0, 0, 40, 0, 0, 0, 20.0}
        Dim Ys2() As Single = {0.0, 84.0, 64.0, 0, 44, 0, 0, 0, 24.0}
        Dim strA() As String = {"", "R", "G", "", "B", "", "", "", "A"}
        Dim t_col_o As Single = 5
        Dim ls_col As Single = 20
        Dim t_col_d As Single = 100
        Dim le_col As Single = 95
        Dim h = -pb3.Height
        glutPrint(t_col_o, h + Ys(1), "R", 1.0, 0.0, 0.0, 1.0)
        glutPrint(t_col_o, h + Ys(2), "G", 0.0, 1.0, 0.0, 1.0)
        glutPrint(t_col_o, h + Ys(4), "B", 0.0, 0.0, 1.0, 1.0)
        glutPrint(t_col_o, h + Ys(8), "A", 1.0, 1.0, 1.0, 1.0)

        glutPrint(t_col_d, h + Ys(1), "R", 1.0, 0.0, 0.0, 1.0)
        glutPrint(t_col_d, h + Ys(2), "G", 0.0, 1.0, 0.0, 1.0)
        glutPrint(t_col_d, h + Ys(4), "B", 0.0, 0.0, 1.0, 1.0)
        glutPrint(t_col_d, h + Ys(8), "A", 1.0, 1.0, 1.0, 1.0)
        Gl.glLineWidth(2)
        Gl.glBegin(Gl.GL_LINES)
        If R_ > 0 Then
            Gl.glColor3f(1.0, 0.0, 0.0)
            Gl.glVertex3f(ls_col, h + Ys2(1), 0.0)
            Gl.glVertex3f(le_col, h + Ys2(R_), 0.0)
        End If
        If G_ > 0 Then
            Gl.glColor3f(0.0, 1.0, 0.0)
            Gl.glVertex3f(ls_col, h + Ys2(2), 0.0)
            Gl.glVertex3f(le_col, h + Ys2(G_), 0.0)
        End If
        If B_ > 0 Then
            Gl.glColor3f(0.0, 0.0, 1.0)
            Gl.glVertex3f(ls_col, h + Ys2(4), 0.0)
            Gl.glVertex3f(le_col, h + Ys2(B_), 0.0)
        End If
        If A_ > 0 Then
            Gl.glColor3f(1.0, 1.0, 1.0)
            Gl.glVertex3f(ls_col, h + Ys2(8), 0.0)
            Gl.glVertex3f(le_col, h + Ys2(A_), 0.0)
        End If

        Gl.glEnd()

        If source_rb.Checked Then
            glutPrint(t_col_o, -15, "Source Image", 1.0, 1.0, 0.0, 1.0)
        End If
        If output_rb.Checked Then
            glutPrint(t_col_o, -15, "Output Image", 1.0, 1.0, 0.0, 1.0)
        End If
        If show_mask_rb.Checked Then
            glutPrint(t_col_o, -15, "Mask Image", 1.0, 1.0, 0.0, 1.0)
        End If

        Return

    End Sub

    Public Sub glutPrint(ByVal x As Single, ByVal y As Single, _
ByVal text As String, ByVal r As Single, ByVal g As Single, ByVal b As Single, ByVal a As Single)
        If text IsNot Nothing Then
            If text.Length = 0 Then Exit Sub
            Gl.glColor4f(r, g, b, a)
            Gl.glRasterPos2f(x, y)
            For Each I In text
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_8_BY_13, Asc(I))
            Next
        End If
    End Sub

    Public Sub draw_prep()
        If Not _STARTED Then Return
        'if we are printing, we cant change this context
        Gl.glClearColor(0.0F, 0.0F, 0.0, 0.0F)
        Gl.glClear(Gl.GL_COLOR_BUFFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT)

        Gl.glDisable(Gl.GL_LIGHTING)
        Gl.glDisable(Gl.GL_BLEND)
        Gl.glDisable(Gl.GL_DEPTH_TEST)
        '----------------------------------------------
        Gl.glUseProgram(color_pgm)
        Gl.glUniform4f(mask, 1.0, 1.0, 1.0, 1.0)
        Gl.glUniform1i(c_address, 0)
        Gl.glPushMatrix()
        Gl.glTranslatef(0.0, 0.0, 0.5)
        Gl.glActiveTexture(Gl.GL_TEXTURE0)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, temp_image)

        Gl.glBegin(Gl.GL_QUADS)
        Gl.glTexCoord2f(0.0, 1.0)
        Gl.glVertex3f(0.0, sImageHeight, -0.15)
        Gl.glTexCoord2f(0.0, 0.0)
        Gl.glVertex3f(0.0, 0.0, -0.15)
        Gl.glTexCoord2f(1.0, 0.0)
        Gl.glVertex3f(sImageWidth, 0.0, -0.15)
        Gl.glTexCoord2f(1.0, 1.0)
        Gl.glVertex3f(sImageWidth, sImageHeight, -0.15)
        Gl.glEnd()
        Gl.glPopMatrix()
        '----------------------------------------
        Gl.glUseProgram(0)

        Gl.glPopMatrix()
        Gl.glDisable(Gl.GL_TEXTURE_2D)

        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        Gl.glEnable(Gl.GL_DEPTH_TEST)
        Gl.glDisable(Gl.GL_TEXTURE_2D)

        Application.DoEvents()
    End Sub


    Private Sub m_help_Click(sender As Object, e As EventArgs) Handles m_help.Click
        If Not _STARTED Then Return
        Dim s As String = Application.StartupPath
        System.Diagnostics.Process.Start(s + "\HTML files\help.html")
    End Sub

    Private Sub m_open_Click(sender As Object, e As EventArgs) Handles m_open.Click
        MenuStrip.Enabled = False
        OpenFileDialog1.Title = "Load Image"
        OpenFileDialog1.Filter = "DDS (DXT5) (*.dds)|*.dds|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp|JPG (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog = Forms.DialogResult.OK Then
            source_filename = OpenFileDialog1.FileName
            Me.Text = "RGBA Channel Swizzler - File: " + source_filename
            Gl.glDeleteTextures(1, current_texture_swizz)
            Gl.glFinish()
            current_texture_swizz = -1
            current_texture_swizz = load_image(source_filename, True)
            If current_texture_swizz = -1 Then
                MsgBox("Could not open " + vbCrLf + source_filename, MsgBoxStyle.Exclamation, "File IO Error...")
                current_texture_swizz = -1
                source_filename = "No File"
                Me.Text = "No file"
                draw(True)
            End If
            If temp_image > 0 Then
                Gl.glDeleteTextures(1, temp_image)
                Gl.glFinish()
            End If
            If temp_image2 > 0 Then
                Gl.glDeleteTextures(1, temp_image2)
                Gl.glFinish()
            End If
            create_temp_image()
            create_temp2()
        End If
        MenuStrip.Enabled = True
        pb3.Width = Me.ClientSize.Width - Panel1.Width
        pb3.Height = Me.ClientSize.Height - (Me.MenuStrip.Height + Me.top_panel.Height)
        pb3.Location = New Point(Panel1.Width, Me.MenuStrip.Height + Me.top_panel.Height)
        sBox.location = New Point((pb3.Width - sBox.Width) / 2, (pb3.Height - sBox.Height) / 2)
        rect_location = sBox.location
        If convert_rgb_NM_cb.Checked Then
            'render_to_temp_image()
        End If
        draw(True)
    End Sub
    Dim mask_texture As Integer = -1
    Private Sub m_mask_Click(sender As Object, e As EventArgs) Handles m_mask.Click
        If current_texture_swizz = -1 Then
            MsgBox("You need to load a image to apply the mask to", MsgBoxStyle.Exclamation, "Opps")
            Return
        End If
        MenuStrip.Enabled = False
        OpenFileDialog1.Title = "Load Mask Image"
        If OpenFileDialog1.ShowDialog = Forms.DialogResult.OK Then
            mask_filename = OpenFileDialog1.FileName
            mask_tb.Text = Path.GetFileName(mask_filename)
            Gl.glDeleteTextures(1, mask_texture)
            Gl.glFinish()
            mask_texture = -1
            mask_texture = load_image(mask_filename, False)
            If mask_texture = -1 Then
                MsgBox("Could not open " + vbCrLf + source_filename, MsgBoxStyle.Exclamation, "File IO Error...")
                mask_texture = -1
                mask_filename = "No Mask File"
                mask_tb.Text = "No Mask file"
                draw(True)
            End If

        End If
        MenuStrip.Enabled = True

        draw(True)
    End Sub

    Dim depthTexture2 As Integer
    Dim depthID2 As Integer
    Dim fboID2 As Integer = -1
    Dim fboID As Integer

    Public Sub create_rgba_FBO(ByVal width As Integer, ByVal height As Integer)
        If fboID2 > 0 Then
            Gl.glDeleteFramebuffersEXT(1, fboID2)
            Gl.glDeleteRenderbuffersEXT(1, depthID2)
            Gl.glFinish()
        End If
        Gl.glGenFramebuffersEXT(1, fboID2)
        Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, fboID2)
        Dim er = Gl.glGetError
        ' create a depth buffer
        Gl.glGenRenderbuffersEXT(1, depthID2)
        er = Gl.glGetError
        Gl.glBindRenderbufferEXT(Gl.GL_RENDERBUFFER_EXT, depthID2)
        Gl.glRenderbufferStorageEXT(Gl.GL_RENDERBUFFER_EXT, Gl.GL_DEPTH_COMPONENT24, width, height)
        er = Gl.glGetError
        If depthTexture2 > 0 Then
            Gl.glDeleteTextures(1, depthTexture2)
            Gl.glFinish()
        End If
        Gl.glGenTextures(1, depthTexture2)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, depthTexture2)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST)
        Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT)
        Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT)

        Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, CInt(width), CInt(height), 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, Nothing)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)

        Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, depthTexture2, 0)
        Gl.glFramebufferRenderbufferEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_DEPTH_ATTACHMENT_EXT, Gl.GL_RENDERBUFFER_EXT, depthID2)

        er = Gl.glGetError
        'check status
        Dim fbostatus = Gl.glCheckFramebufferStatusEXT(Gl.GL_FRAMEBUFFER_EXT)
        If fbostatus <> Gl.GL_FRAMEBUFFER_COMPLETE_EXT Then
            MsgBox("I failed to create the shadow FBO 2!", MsgBoxStyle.Exclamation, "Opengl Issue...")
        End If
        ' switch back to window-system-provided framebuffer
        Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, 0)

    End Sub
    Public Sub attache_RGBA_FBO(textureID)
        Gl.glActiveTexture(Gl.GL_TEXTURE0)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, fboID2)
        Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, 0, 0)
        Dim e = Gl.glGetError
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, textureID)
        Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, textureID, 0)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        e = Gl.glGetError
        Gl.glGetFramebufferAttachmentParameterivEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT, attachstatus)
        e = Gl.glGetError
        If e <> 0 Then
            Dim s = Glu.gluErrorString(1280)
            MsgBox("Error switching render texture! " + s, MsgBoxStyle.Exclamation, "OpenGL Issue")
        End If
        Gl.glFinish()
    End Sub
    Public Sub attache_texture(textureID)
        Gl.glActiveTexture(Gl.GL_TEXTURE0)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, fboID2)
        Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, 0, 0)
        Dim e = Gl.glGetError
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, textureID)
        Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, textureID, 0)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        e = Gl.glGetError
        Gl.glGetFramebufferAttachmentParameterivEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT, attachstatus)
        e = Gl.glGetError
        If e <> 0 Then
            Dim s = Glu.gluErrorString(1280)
            MsgBox("Error switching render texture! " + s, MsgBoxStyle.Exclamation, "OpenGL Issue")
        End If
        Gl.glFinish()
    End Sub

    Public drawbuffer0() = {Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_NONE}
    Public drawbuffer1() = {Gl.GL_NONE, Gl.GL_COLOR_ATTACHMENT1_EXT}

    Private Sub render_to_temp_image()
        If current_texture_swizz = -1 Or _
        temp_image = -1 Or temp_image2 = -1 Then
            Return
        End If
      
        create_rgba_FBO(sImageWidth, sImageHeight) 'delete, create and resize fbo

        Gl.glBindFramebufferEXT(Gl.GL_RENDERBUFFER_EXT, fboID2)
        If Not (Wgl.wglMakeCurrent(pb1_hDC, pb1_hRC)) Then
            MessageBox.Show("Unable to make rendering context current")
            Return
        End If
        _printing = True
        attache_RGBA_FBO(temp_image)
        Gl.glDrawBuffers(2, drawbuffer0(0))
        ViewOrtho2(sImageWidth, -sImageHeight)
        Dim e = Gl.glGetError

        Gl.glClearColor(0.0, 0.0, 0.0, 1.0)
        Gl.glClear(Gl.GL_COLOR_BUFFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT)
        Gl.glDisable(Gl.GL_BLEND)
        Gl.glDisable(Gl.GL_LIGHTING)
        Gl.glEnable(Gl.GL_TEXTURE_2D)
        If Not GenMask_cb.Checked Then
            ' use swizzler
            Gl.glUseProgram(swizzler_pgm)

            Gl.glUniform1i(color_in, 0)
            Gl.glUniform1i(color_out, 1)
            Gl.glUniform1i(sw_mask_location, 2)
            Gl.glUniform1i(r_mask, R_)
            Gl.glUniform1i(g_mask, G_)
            Gl.glUniform1i(b_mask, B_)
            Gl.glUniform1i(a_mask, A_)
            Gl.glUniform1i(sw_mask_function, mask_function)
            Gl.glUniform1f(sw_mask_mix, CSng(TrackBar1.Value / 100.0!))
            Gl.glUniform1i(sw_blend_alpha, use_alpha_blend)
            If convert_rgb_NM_cb.Checked Then
                Gl.glUniform1i(convert_rgb_NM, 1)
            Else
                Gl.glUniform1i(convert_rgb_NM, 0)
            End If

            If mask_cb.Checked Then
                Gl.glUniform1i(sw_use_mask, 1)
                Gl.glUniform1i(sw_mask_channels, mask_value)

            Else
                Gl.glUniform1i(sw_use_mask, 0)
            End If
            If fill_alpha_cb.Checked Then
                Gl.glUniform1i(sw_use_alpha_fill, 1)
                Gl.glUniform1f(sw_alpha_value, alpha_percent)

            Else
                Gl.glUniform1i(sw_use_alpha_fill, 0)
            End If
            If multiply_cb.Checked Then
                Gl.glUniform1i(sw_multiply, 1)
            Else
                Gl.glUniform1i(sw_multiply, 0)
            End If

            e = Gl.glGetError
            Gl.glActiveTexture(Gl.GL_TEXTURE0)
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, current_texture_swizz)
            Gl.glActiveTexture(Gl.GL_TEXTURE0 + 1)
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, temp_image2)
            Gl.glActiveTexture(Gl.GL_TEXTURE0 + 2)
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, mask_texture)

        Else
            ' use maskgen_pgm pgm
            Gl.glUseProgram(maskgen_pgm)
            Gl.glUniform1i(mg_color, 0)
            Gl.glActiveTexture(Gl.GL_TEXTURE0)
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, current_texture_swizz)
        End If

        Gl.glColor4f(0.5, 0.5, 0.5, 0.0)
        Gl.glBegin(Gl.GL_QUADS)
        Gl.glTexCoord2f(0.0, 0.0)
        Gl.glVertex3f(0.0, sImageHeight, -0.1)

        Gl.glTexCoord2f(0.0, 1.0)
        Gl.glVertex3f(0.0, 0.0, -0.1)

        Gl.glTexCoord2f(1.0, 1.0)
        Gl.glVertex3f(sImageWidth, 0.0, -0.1)

        Gl.glTexCoord2f(1.0, 0.0)
        Gl.glVertex3f(sImageWidth, sImageHeight, -0.1)

        Gl.glEnd()
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        Gl.glActiveTexture(Gl.GL_TEXTURE0)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)

        Gl.glUseProgram(0)
        attache_texture(0)
        Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, 0)
        Gl.glDrawBuffer(Gl.GL_BACK)
        _printing = False
        'draw(True)
    End Sub

    Public Sub scale_up_btn_Click(sender As Object, e As EventArgs) Handles scale_up_btn.Click
        If _printing Then Return
        If _printing Then Return
        mouse_pos.X = pb3.Width / 2.0
        mouse_pos.Y = pb3.Height / 2.0
        img_scale_up()
    End Sub

    Public Sub scale_down_btn_Click(sender As Object, e As EventArgs) Handles scale_down_btn.Click
        If _printing Then Return
        mouse_pos.X = pb3.Width / 2.0
        mouse_pos.Y = pb3.Height / 2.0
        img_scale_down()
    End Sub

    Private Sub red_group_DoubleClick(sender As Object, e As EventArgs) Handles red_group.DoubleClick
        reset_radios(sender)
        R_ = 0
        'render_to_temp_image()
        draw(True)
    End Sub

    Private Sub green_group_DoubleClick(sender As Object, e As EventArgs) Handles green_group.DoubleClick
        reset_radios(sender)
        G_ = 0
        'render_to_temp_image()
        draw(True)
    End Sub
    Private Sub blue_group_DoubleClick(sender As Object, e As EventArgs) Handles blue_group.DoubleClick
        reset_radios(sender)
        B_ = 0
        'render_to_temp_image()
        draw(True)

    End Sub
    Private Sub alpha_group_DoubleClick(sender As Object, e As EventArgs) Handles alpha_group.DoubleClick
        reset_radios(sender)
        A_ = 0
        'render_to_temp_image()
        draw(True)
    End Sub
    Private Sub reset_radios(ByVal sender As Object)
        For Each cb As Object In sender.controls
            If TypeOf cb Is RadioButton Then
                Dim tcb = cb
                cb.checked = False
            End If
        Next
    End Sub

    Private Sub m_top_most_Click(sender As Object, e As EventArgs) Handles m_top_most.Click
        If Me.TopMost Then
            Me.TopMost = False
            m_top_most.ForeColor = Color.Black
        Else
            Me.TopMost = True
            m_top_most.ForeColor = Color.Red
        End If

    End Sub

    Private Sub frmSwizzler_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        draw(True)
    End Sub

    Public Sub create_temp2()
        temp_image2 = temp_image
        Gl.glGenTextures(1, temp_image)
        create_temp_image()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If Not _Started Then Return
        'render_to_temp_image()
        draw(True)
    End Sub

    Public Sub create_temp_image()
        _printing = True
        If Not (Wgl.wglMakeCurrent(pb1_hDC, pb1_hRC)) Then
            MessageBox.Show("Unable to make rendering context current")
            Return
        End If
        Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, 0)
        Gl.glDrawBuffer(Gl.GL_BACK)
        Gl.glTexEnvi(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE)

        Dim e = Gl.glGetError
        Dim s = pb3.Size
        Dim old_s = pb3.Size
        Dim ac = pb3.Anchor
        pb3.Anchor = AnchorStyles.None
        s.Width = sImageWidth
        s.Height = sImageHeight
        pb1.Size = s
        pb1.Width = s.Width
        pb1.Height = s.Height
        sBox.Width = s.Width
        sBox.Height = s.Height

        pb3.Size = s
        pb3.Width = s.Width
        pb3.Height = s.Height
        sBox.location = New Point((pb3.Width - sBox.Width) / 2, (pb3.Height - sBox.Height) / 2)

        Application.DoEvents()

        'PB3.Anchor = AnchorStyles.None
        'PB3.Width = sImageWidth
        'PB3.Height = sImageHeight
        ViewOrtho2(sImageWidth, sImageHeight)
        '==================================================================
        Gl.glClearColor(0.0, 0.0, 0.0, 1.0)
        Gl.glClear(Gl.GL_COLOR_BUFFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT)

        Gl.glDisable(Gl.GL_BLEND)
        Gl.glDisable(Gl.GL_LIGHTING)
        Gl.glEnable(Gl.GL_TEXTURE_2D)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, current_texture_swizz)

        Gl.glColor4f(0.5, 0.5, 0.5, 0.0)
        Gl.glBegin(Gl.GL_QUADS)
        Gl.glTexCoord2f(0.0, -1.0)
        Gl.glVertex3f(0.0, sImageHeight, -0.1)
        Gl.glTexCoord2f(0.0, 0.0)
        Gl.glVertex3f(0.0, 0.0, -0.1)
        Gl.glTexCoord2f(1.0, 0.0)
        Gl.glVertex3f(sImageWidth, 0.0, -0.1)
        Gl.glTexCoord2f(1.0, -1.0)
        Gl.glVertex3f(sImageWidth, sImageHeight, -0.1)

        Gl.glEnd()
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        Dim Id As Integer = Il.ilGenImage
        Il.ilBindImage(Id)
        Il.ilTexImage(sImageWidth, sImageHeight, 0, 4, Il.IL_RGBA, Il.IL_UNSIGNED_BYTE, Nothing)

        Gl.glReadPixels(0, 0, sImageWidth, sImageHeight, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, Il.ilGetData())
        Il.ilConvertImage(Il.IL_RGBA, Il.IL_UNSIGNED_BYTE)

        Gl.glFinish()
        'pb3.Anchor = ac
        'pb3.Width = old_w
        'pb3.Height = old_h
        Me.Label2.Text = "Width:  " + sImageWidth.ToString + vbCrLf
        Me.Label2.Text += "Height: " + sImageHeight.ToString

        Ilu.iluFlipImage()
        If temp_image > -1 Then
            Gl.glDeleteTextures(1, temp_image)
            Gl.glFinish()
        End If
        Dim er = Gl.glGetError
        Gl.glGenTextures(1, temp_image)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, temp_image)
        er = Gl.glGetError

        'success = Il.ilConvertImage(Il.IL_RGBA, Il.IL_UNSIGNED_BYTE)	' Convert every colour component into unsigned bytes
        'If your image contains alpha channel you can replace IL_RGB with IL_RGBA */
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST)
        er = Gl.glGetError

        Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Il.ilGetInteger(Il.IL_IMAGE_BPP), Il.ilGetInteger(Il.IL_IMAGE_WIDTH), _
        Il.ilGetInteger(Il.IL_IMAGE_HEIGHT), 0, Il.ilGetInteger(Il.IL_IMAGE_FORMAT), Gl.GL_UNSIGNED_BYTE, _
        Il.ilGetData()) '  Texture specification 
        Dim il_er = Il.ilGetError
        If il_er <> 0 Then
            Debug.Write("error creating temp_image" + vbCrLf)
        End If


        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        er = Gl.glGetError
        If er > 0 Then
            Debug.Write("Texture load GL error: " = er.ToString + vbCrLf)
        End If
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        ' Il.ilBindImage(0)

        Il.ilDeleteImage(Id)
        _printing = False
    End Sub

    Public Sub save_file()
        If current_texture_swizz = -1 Then Return
        MenuStrip.Enabled = False
        Dim temp_name = Path.GetFileNameWithoutExtension(source_filename)
        If frmSaveOptions.dx5_rb.Checked Then
            Dim ss As String = ""
            ' need to set format
            SaveFileDialog1.Title = "Save DDS"
            If frmSaveOptions.BC1.Checked Then
                ss = "BC1 DX1"
                Il.ilSetInteger(Il.IL_DXTC_FORMAT, Il.IL_DXT1)
            End If
            If frmSaveOptions.BC2.Checked Then
                ss = "BC3 DX5"
                Il.ilSetInteger(Il.IL_DXTC_FORMAT, Il.IL_DXT5)
            End If
            SaveFileDialog1.Filter = "DDS (" + ss + ") (*.dds)|*.dds"
            temp_name += ".dds"
        End If
        If frmSaveOptions.jpg_rb.Checked Then
            SaveFileDialog1.Title = "Save JPG"
            SaveFileDialog1.Filter = "JPG(*.jpg)|*.jpg"
            temp_name += ".jpg"

        End If
        If frmSaveOptions.bitmap_rb.Checked Then
            SaveFileDialog1.Title = "Save Bitmap"
            SaveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp"
            temp_name += ".bmp"
        End If
        If frmSaveOptions.png_rb.Checked Then
            SaveFileDialog1.Title = "Save PNG"
            SaveFileDialog1.Filter = "PNG (*.png)|*.png"
            temp_name += ".png"
        End If
        SaveFileDialog1.FileName = temp_name
        If SaveFileDialog1.ShowDialog = Forms.DialogResult.OK Then
            If File.Exists(SaveFileDialog1.FileName) Then
                File.Delete(SaveFileDialog1.FileName)
            End If
            Dim fn = SaveFileDialog1.FileName
            Dim texid = prepare_image_for_save()
            If texid = -1 Then
                MsgBox("Could not set render context to save image", MsgBoxStyle.Exclamation, "OpenGL Error")
                Return
            End If
            Dim er = Il.ilGetError
            Il.ilBindImage(texid)
            er = Il.ilGetError

            er = Il.ilGetError
            Dim status As Boolean
            'Il.ilSetInteger(Il.IL_DXTC_DATA_FORMAT, Il.IL_DXT_NO_COMP)
            er = Il.ilGetError
            If frmSaveOptions.BC1.Checked Or frmSaveOptions.BC2.Checked Then
                If frmSaveOptions.mipmaps_cb.Checked Then
                    Ilu.iluBuildMipmaps()
                End If
                status = Il.ilSave(Il.IL_DDS, fn)
            End If
            If frmSaveOptions.jpg_rb.Checked Then
                status = Il.ilSave(Il.IL_TGA, fn)
            End If
            If frmSaveOptions.bitmap_rb.Checked Then
                status = Il.ilSave(Il.IL_BMP, fn)
            End If
            If frmSaveOptions.png_rb.Checked Then
                status = Il.ilSave(Il.IL_PNG, fn)
            End If
            If Not status Then
                MsgBox("Failed to save File!", MsgBoxStyle.Exclamation, "File Save Error")
            End If
            Il.ilDeleteImage(texid)
            Il.ilBindImage(0)
        End If
        MenuStrip.Enabled = True

    End Sub

    Public Function load_image(ByVal filename As String, ByVal get_size As Boolean) As Integer
        Dim id = Il.ilGenImage
        Il.ilBindImage(id)
        'may as well set these here...
        Il.ilEnable(Il.IL_FILE_OVERWRITE)
        Il.ilSetInteger(Il.IL_JPG_QUALITY, 99)
        Il.ilSetInteger(Il.IL_DXTC_FORMAT, Il.IL_DXT5)

        Dim ext = Path.GetExtension(filename)
        Select Case ext.ToLower
            Case ".bmp"
                Il.ilLoad(Il.IL_BMP, filename)
            Case ".jpg"
                Il.ilLoad(Il.IL_JPG, filename)
            Case ".dds"
                Il.ilLoad(Il.IL_DDS, filename)
            Case ".png"
                Il.ilLoad(Il.IL_PNG, filename)

        End Select
        dds_format = Il.ilGetInteger(Il.IL_DXTC_DATA_FORMAT)
        Dim e = Il.ilGetError
        If e <> 0 Then
            Return -1
        End If
        If get_size Then

            sBox.Width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH)
            sBox.Height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT)
            _zoom_ = 1
            sImageHeight = sBox.Height
            sImageWidth = sBox.Width
            rect_size.X = sImageWidth
            rect_size.Y = sImageHeight
            old_w = sImageWidth
            old_h = sImageHeight
            zoom.Text = "Zoom:" + vbCrLf + "100%"
            Zoom_Factor = 1.0
        End If
        Il.ilConvertImage(Il.IL_RGBA, Il.IL_UNSIGNED_BYTE)
        Dim er = Gl.glGetError
        Dim texID As Integer
        Gl.glGenTextures(1, texID)
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, texID)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST)

        Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Il.ilGetInteger(Il.IL_IMAGE_BPP), Il.ilGetInteger(Il.IL_IMAGE_WIDTH), _
        Il.ilGetInteger(Il.IL_IMAGE_HEIGHT), 0, Il.ilGetInteger(Il.IL_IMAGE_FORMAT), Gl.GL_UNSIGNED_BYTE, _
        Il.ilGetData()) '  Texture specification 

        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        ' Il.ilBindImage(0)

        Il.ilDeleteImage(id)
        er = Gl.glGetError
        Return texID
    End Function

    Public Function prepare_image_for_save() As Integer
        If Not (Wgl.wglMakeCurrent(pb1_hDC, pb1_hRC)) Then
            MessageBox.Show("Unable to make rendering context current")
            Return -1
        End If
        _printing = True
        Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, 0)
        Gl.glDrawBuffer(Gl.GL_BACK)


        Dim e = Gl.glGetError
        Dim old_size = pb3.Size
        '  Dim s = pb3.Size
        pb3.Anchor = AnchorStyles.None
        ' s.Width = sImageWidth
        '  s.Height = sImageHeight
        ' pb3.Size = s
        pb3.Width = sImageWidth
        pb3.Height = sImageHeight
        Application.DoEvents()
        ViewOrtho2(sImageWidth, -sImageHeight)

        'Gl.glBindFramebufferEXT(Gl.GL_FRAMEBUFFER_EXT, fboID2)

        draw_prep()
        Gl.glFinish()
        Dim Id As Integer = Il.ilGenImage
        Il.ilBindImage(Id)
        Il.ilTexImage(sImageWidth, sImageHeight, 0, 4, Il.IL_RGBA, Il.IL_UNSIGNED_BYTE, Nothing)

        Gl.glReadPixels(0, 0, sImageWidth, sImageHeight, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, Il.ilGetData())
        If quater_cb.Checked Then
            Ilu.iluScale(sImageWidth * 0.5, sImageHeight * 0.5, Il.ilGetInteger(Il.IL_IMAGE_DEPTH))
        End If
        'below is for testing that the render is correct.
        'Gl.glBindTexture(Gl.GL_TEXTURE_2D, temp_image)
        'Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST)
        'Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST)

        'Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Il.ilGetInteger(Il.IL_IMAGE_BPP), Il.ilGetInteger(Il.IL_IMAGE_WIDTH), _
        'Il.ilGetInteger(Il.IL_IMAGE_HEIGHT), 0, Il.ilGetInteger(Il.IL_IMAGE_FORMAT), Gl.GL_UNSIGNED_BYTE, _
        'Il.ilGetData())

        'Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)

        Gl.glFinish()
        'pb3.Anchor = ac
        pb3.Size = old_size
        sImageWidth = old_size.Width
        sImageHeight = old_size.Height
        Application.DoEvents()
        Gl.glFramebufferTexture2DEXT(Gl.GL_FRAMEBUFFER_EXT, Gl.GL_COLOR_ATTACHMENT0_EXT, Gl.GL_TEXTURE_2D, 0, 0)

        Il.ilBindImage(0)
        _printing = False
        Return Id
    End Function

#Region "Buttons"

    Private Sub source_rb_CheckedChanged(sender As Object, e As EventArgs) Handles source_rb.CheckedChanged
        draw(True)
    End Sub

    Private Sub output_rb_CheckedChanged(sender As Object, e As EventArgs) Handles output_rb.CheckedChanged
        draw(True)
    End Sub

    Private Sub alpha_blend_cb_CheckedChanged(sender As Object, e As EventArgs) Handles alpha_blend_cb.CheckedChanged
        draw(True)
    End Sub


    Private Sub convert_rgb_NM_cb_CheckedChanged_1(sender As Object, e As EventArgs) Handles convert_rgb_NM_cb.CheckedChanged
        'render_to_temp_image()
        draw(True)
    End Sub

    Private Sub m_save_Click(sender As Object, e As EventArgs) Handles m_save.Click
        frmSaveOptions.ShowDialog(Me)
    End Sub

    Private Sub m_edit_shaders_Click(sender As Object, e As EventArgs) Handles m_edit_shaders.Click
        frmEditFrag.Show()

    End Sub

    Private Sub b_red_Click(sender As Object, e As EventArgs) Handles b_red.Click
        If color_mask.x = 1.0 Then
            b_red.FlatStyle = FlatStyle.Flat
            color_mask.x = 0.0
        Else
            b_red.FlatStyle = FlatStyle.Standard
            color_mask.x = 1.0
        End If
        draw(True)
    End Sub

    Private Sub b_green_Click(sender As Object, e As EventArgs) Handles b_green.Click
        If color_mask.y = 1.0 Then
            b_green.FlatStyle = FlatStyle.Flat
            color_mask.y = 0.0
        Else
            b_green.FlatStyle = FlatStyle.Standard
            color_mask.y = 1.0
        End If
        draw(True)
    End Sub

    Private Sub b_blue_Click(sender As Object, e As EventArgs) Handles b_blue.Click
        If color_mask.z = 1.0 Then
            b_blue.FlatStyle = FlatStyle.Flat
            color_mask.z = 0.0
        Else
            b_blue.FlatStyle = FlatStyle.Standard
            color_mask.z = 1.0
        End If
        draw(True)
    End Sub

    Private Sub b_alpha_Click(sender As Object, e As EventArgs) Handles b_alpha.Click
        If color_mask.w = 1.0 Then
            b_alpha.FlatStyle = FlatStyle.Flat
            color_mask.w = 0.0
        Else
            b_alpha.FlatStyle = FlatStyle.Standard
            color_mask.w = 1.0
        End If
        draw(True)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim v As String = ComboBox1.SelectedItem
        v = v.Replace("%", "")
        alpha_percent = CSng(v) / 100.0!
        draw(True)
    End Sub
#End Region


    Public Sub img_scale_up()
        If Zoom_Factor >= 4.0 Then
            Zoom_Factor = 4.0
            Return 'to big and the t_bmp creation will hammer memory.
        End If
        Dim amt As Single = 0.125
        Zoom_Factor += amt
        Dim z = (Zoom_Factor / 1.0) * 100.0
        zoom.Text = "Zoom:" + vbCrLf + z.ToString("000") + "%"
        Application.DoEvents()
        'this bit of math zooms the texture around the mouses center during the resize.
        'old_w and old_h is the original size of the image in width and height
        'mouse_pos is current mouse position in the window.

        Dim offset As New Point
        Dim old_size_w, old_size_h As Double
        old_size_w = (old_w * (Zoom_Factor - amt))
        old_size_h = (old_h * (Zoom_Factor - amt))

        offset = rect_location - (mouse_pos)

        rect_size.X = Zoom_Factor * old_w
        rect_size.Y = Zoom_Factor * old_h

        Dim delta_x As Double = CDbl(offset.X / old_size_w)
        Dim delta_y As Double = CDbl(offset.Y / old_size_h)

        Dim x_offset = delta_x * (rect_size.X - old_size_w)
        Dim y_offset = delta_y * (rect_size.Y - old_size_h)

        rect_location.X += CInt(x_offset)
        rect_location.Y += CInt(y_offset)

        sBox.location = rect_location
        sBox.Height = rect_size.Y
        sBox.Width = rect_size.X
        draw(True)
    End Sub
    Public Sub img_scale_down()
        If Zoom_Factor <= 0.25 Then
            Zoom_Factor = 0.25
            Return
        End If
        Dim amt As Single = 0.125
        Zoom_Factor -= amt
        Dim z = (Zoom_Factor / 1.0) * 100.0
        zoom.Text = "Zoom:" + vbCrLf + z.ToString("000") + "%"
        Application.DoEvents()

        'this bit of math zooms the texture around the mouses center during the resize.
        'old_w and old_h is the original size of the image in width and height
        'mouse_pos is current mouse position in the window.

        Dim offset As New Point
        Dim old_size_w, old_size_h As Double

        old_size_w = (old_w * (Zoom_Factor - amt))
        old_size_h = (old_h * (Zoom_Factor - amt))

        offset = rect_location - (mouse_pos)

        rect_size.X = Zoom_Factor * old_w
        rect_size.Y = Zoom_Factor * old_h

        Dim delta_x As Double = CDbl(offset.X / (rect_size.X + (rect_size.X - old_size_w)))
        Dim delta_y As Double = CDbl(offset.Y / (rect_size.Y + (rect_size.Y - old_size_h)))

        Dim x_offset = delta_x * (rect_size.X - old_size_w)
        Dim y_offset = delta_y * (rect_size.Y - old_size_h)

        rect_location.X += -CInt(x_offset)
        rect_location.Y += -CInt(y_offset)

        sBox.location = rect_location
        sBox.Height = rect_size.Y
        sBox.Width = rect_size.X

        draw(True)
    End Sub

    Private Sub pb3_MouseDown(sender As Object, e As MouseEventArgs) Handles pb3.MouseDown
        mouse_down = True
        mouse_delta = e.Location
    End Sub

    Private Sub pb3_MouseEnter(sender As Object, e As EventArgs) Handles pb3.MouseEnter
        pb3.Focus()
    End Sub

    Private Sub pb3_MouseMove(sender As Object, e As MouseEventArgs) Handles pb3.MouseMove
        If mouse_down Then
            Dim p As New Point
            p = e.Location - mouse_delta
            rect_location += p
            mouse_delta = e.Location
            sBox.location = rect_location
            sBox.Height = rect_size.Y
            sBox.Width = rect_size.X
            draw(True)
            Return
        End If
        'If pb2.Parent Is frmShowImage.SPC.Panel1 Then
        '    frmShowImage.mouse_pos = e.Location
        '    frmShowImage.draw_(frmShowImage.current_image)
        '    Application.DoEvents()
        'End If

    End Sub

    Private Sub pb3_MouseUp(sender As Object, e As MouseEventArgs) Handles pb3.MouseUp
        mouse_down = False
    End Sub

    Private Sub pb3_MouseWheel(sender As Object, e As MouseEventArgs) Handles pb3.MouseWheel
        mouse_pos = e.Location
        mouse_delta = e.Location

        If e.Delta > 0 Then
            img_scale_up()
        Else
            img_scale_down()
        End If
    End Sub

    Private Sub pb3_Paint(sender As Object, e As PaintEventArgs) Handles pb3.Paint
        draw(True)

    End Sub

    Private Sub fill_alpha_cb_CheckedChanged(sender As Object, e As EventArgs) Handles fill_alpha_cb.CheckedChanged
        draw(True)
    End Sub

    Private Sub multiply_cb_CheckedChanged(sender As Object, e As EventArgs) Handles multiply_cb.CheckedChanged
        draw(True)
    End Sub

    Private mask_function As Integer = 0
    Private Sub add_rb_CheckedChanged(sender As Object, e As EventArgs) Handles add_rb.CheckedChanged
        If add_rb.AutoCheck Then
            mask_function = 0
        End If
        draw(True)
    End Sub
    Private Sub sub_rb_CheckedChanged(sender As Object, e As EventArgs) Handles sub_rb.CheckedChanged
        If sub_rb.AutoCheck Then
            mask_function = 1
        End If
        draw(True)
    End Sub

    Private Sub mask_rb_CheckedChanged(sender As Object, e As EventArgs) Handles mask_rb.CheckedChanged
        If mask_rb.Checked Then
            mask_function = 2
        End If
        draw(True)
    End Sub

    Private Sub mask_invert_rb_CheckedChanged(sender As Object, e As EventArgs) Handles mask_invert_rb.CheckedChanged
        If mask_invert_rb.Checked Then
            mask_function = 3
        End If
        draw(True)
    End Sub

    Private Sub mask_cb_CheckedChanged(sender As Object, e As EventArgs) Handles mask_cb.CheckedChanged
        If mask_texture = -1 Then
            mask_cb.Checked = False
        End If
        draw(True)
    End Sub

    Private Sub m_red_cb_CheckedChanged(sender As Object, e As EventArgs) Handles m_red_cb.CheckedChanged
        If m_red_cb.Checked Then
            m_red_cb.Tag = 1
        Else
            m_red_cb.Tag = 0
        End If
        set_mask_value()
    End Sub

    Private Sub m_green_cb_CheckedChanged(sender As Object, e As EventArgs) Handles m_green_cb.CheckedChanged
        If m_green_cb.Checked Then
            m_green_cb.Tag = 2
        Else
            m_green_cb.Tag = 0
        End If
        set_mask_value()
    End Sub

    Private Sub m_blue_cb_CheckedChanged(sender As Object, e As EventArgs) Handles m_blue_cb.CheckedChanged
        If m_blue_cb.Checked Then
            m_blue_cb.Tag = 4
        Else
            m_blue_cb.Tag = 0
        End If
        set_mask_value()
    End Sub

    Private Sub m_alpha_cb_CheckedChanged(sender As Object, e As EventArgs) Handles m_alpha_cb.CheckedChanged
        If m_alpha_cb.Checked Then
            m_alpha_cb.Tag = 8
        Else
            m_alpha_cb.Tag = 0
        End If
        set_mask_value()
    End Sub
    Private mask_value = 15
    Private Sub set_mask_value()
        mask_value = 0
        mask_value = m_red_cb.Tag
        mask_value += m_green_cb.Tag
        mask_value += m_blue_cb.Tag
        mask_value += m_alpha_cb.Tag
        draw(True)
    End Sub

    Private Sub show_mask_rb_CheckedChanged(sender As Object, e As EventArgs) Handles show_mask_rb.CheckedChanged
        draw(True)
    End Sub

    Private Sub TrackBar1_MouseEnter(sender As Object, e As EventArgs) Handles TrackBar1.MouseEnter
        TrackBar1.Focus()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        draw(True)
    End Sub

    Private Sub mask_alpha_blend_cb_CheckedChanged(sender As Object, e As EventArgs) Handles mask_alpha_blend_cb.CheckedChanged
        If mask_alpha_blend_cb.Checked Then
            use_alpha_blend = 1
        Else
            use_alpha_blend = 0
        End If
        draw(True)
    End Sub

    Private Sub GenMask_cb_CheckedChanged(sender As Object, e As EventArgs) Handles GenMask_cb.CheckedChanged
        alpha_blend_cb.Checked = True
        draw(True)
    End Sub

    Private Sub reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        r_r.Checked = True
        g_g.Checked = True
        b_b.Checked = True
        a_a.Checked = True
        draw(True)
    End Sub

  

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If quater_cb.Checked Then
            If quater_cb.BackColor = Color.Silver Then
                quater_cb.BackColor = Color.Red
            Else
                quater_cb.BackColor = Color.Silver
            End If
        Else
            quater_cb.BackColor = Color.Silver
        End If
        If GenMask_cb.Checked Then
            If GenMask_cb.ForeColor = Color.Black Then
                GenMask_cb.ForeColor = Color.Red
            Else
                GenMask_cb.ForeColor = Color.Black
            End If
        Else
            GenMask_cb.ForeColor = Color.Black
        End If
        If mask_cb.Checked Then
            If mask_cb.ForeColor = Color.Black Then
                mask_cb.ForeColor = Color.Red
            Else
                mask_cb.ForeColor = Color.Black
            End If
        Else
            mask_cb.ForeColor = Color.Black
        End If

    End Sub

    Private Sub quater_cb_CheckedChanged(sender As Object, e As EventArgs) Handles quater_cb.CheckedChanged
        If quater_cb.Checked Then
            'Timer1.Start()
        Else
            'Timer1.Stop()
            quater_cb.BackColor = Color.Silver
        End If
    End Sub
End Class