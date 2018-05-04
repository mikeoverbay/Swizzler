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
Imports System.Runtime.InteropServices


Module modOpenGL
    Public fullscreen As Boolean = False
    Public vBox As New l_
    Public sBox As New l_
    Public Structure l_
        Public location As Point
        Public Width As Single
        Public Height As Single
    End Structure
    Public pb3_hDC As System.IntPtr
    Public pb3_hRC As System.IntPtr
    Public pb1_hDC As System.IntPtr
    Public pb1_hRC As System.IntPtr

    'Public Sub ViewOrtho()
    '    Gl.glMatrixMode(Gl.GL_PROJECTION) ';					// Select Projection
    '    Gl.glLoadIdentity() ';						// Reset The Matrix
    '    Gl.glOrtho(0, frmMain.pb1.Width, -frmMain.pb1.Height, 0, -10.0, 3000.0) ';				// Select Ortho Mode
    '    Gl.glMatrixMode(Gl.GL_MODELVIEW)    ';					// Select Modelview Matrix
    '    'Gl.glDisable(Gl.GL_DEPTH_TEST)
    '    'Gl.glDepthMask(Gl.GL_FALSE)
    '    Gl.glLoadIdentity() ';						// Reset The Matrix
    'End Sub
    'Public Sub ViewPerspective()                                        '// Set Up A Perspective View

    '    Gl.glMatrixMode(Gl.GL_PROJECTION) ';					// Select Projection
    '    Gl.glLoadIdentity() ';	
    '    Glu.gluPerspective(45.0F, CSng((frmMain.pb1.Width) / (frmMain.pb1.Height)), 0.02F, 900.0F)

    '    Gl.glEnable(Gl.GL_DEPTH_TEST)
    '    Gl.glDepthMask(Gl.GL_TRUE)
    '    Gl.glDepthRange(0.0, 1.0)
    '    Gl.glMatrixMode(Gl.GL_MODELVIEW)    ';					// Select Modelview
    '    Gl.glLoadIdentity() ';						// Reset The Matrix
    'End Sub
    Public Sub ViewOrtho2(ByVal width As Integer, ByVal height As Integer)
        Gl.glViewport(0, 0, width, height)

        Gl.glMatrixMode(Gl.GL_PROJECTION) ';					// Select Projection
        Gl.glLoadIdentity() ';						// Reset The Matrix
        Gl.glOrtho(0, width, -height, 0.0, 50.0, -100.0)

        Gl.glMatrixMode(Gl.GL_MODELVIEW)    ';					// Select Modelview Matrix
        Gl.glLoadIdentity() ';						// Reset The Matrix
    End Sub
    Public Sub ViewPerspective2()                                       '// Set Up A Perspective View

        Gl.glMatrixMode(Gl.GL_PROJECTION) ';					// Select Projection
        Gl.glLoadIdentity() ';	
        Glu.gluPerspective(45.0F, CSng((vBox.Width) / (vBox.Height)), 0.02F, 900.0F)

        Gl.glEnable(Gl.GL_DEPTH_TEST)
        Gl.glDepthMask(Gl.GL_TRUE)
        Gl.glDepthRange(0.0, 1.0)
        Gl.glMatrixMode(Gl.GL_MODELVIEW)    ';					// Select Modelview
        Gl.glLoadIdentity() ';						// Reset The Matrix

    End Sub

    Public Sub ResizeGL()
        Wgl.wglMakeCurrent(pb3_hDC, pb3_hRC)
        If fullscreen Then
            frmMain.pb3.Width = frmMain.ClientSize.Width
            frmMain.pb3.Height = frmMain.ClientSize.Height
            frmMain.pb3.Location = New Point(0, 0)

        End If
        Gl.glViewport(0, 0, frmMain.pb3.Width, frmMain.pb3.Height)
        Gl.glMatrixMode(Gl.GL_PROJECTION) ' Select The Projection Matrix
        Gl.glLoadIdentity() ' Reset The Projection Matrix

        ' Calculate The Aspect Ratio Of The Window
        Glu.gluPerspective(50.0F, CSng((frmMain.pb3.Width) / (frmMain.pb3.Height)), 0.02F, 300.0F)

        Gl.glMatrixMode(Gl.GL_MODELVIEW)    ' Select The Modelview Matrix
        Gl.glLoadIdentity() ' Reset The Modelview Matrix



    End Sub
    Public Sub EnableOpenGL()
        Dim pfd As Gdi.PIXELFORMATDESCRIPTOR
        Dim PixelFormat As Integer

        'ZeroMemory(pfd, Len(pfd))
        pfd.nSize = Len(pfd)
        pfd.nVersion = 1
        pfd.dwFlags = Gdi.PFD_DRAW_TO_WINDOW Or Gdi.PFD_SUPPORT_OPENGL Or Gdi.PFD_DOUBLEBUFFER Or Gdi.PFD_GENERIC_ACCELERATED
        pfd.iPixelType = Gdi.PFD_TYPE_RGBA
        pfd.cColorBits = 32
        pfd.cDepthBits = 32
        pfd.cAlphaBits = 8
        pfd.cStencilBits = 32
        pfd.iLayerType = Gdi.PFD_MAIN_PLANE
        '- pb1 setup ----------------------------------------------
        pb3_hDC = User.GetDC(frmMain.pb3.Handle)
        PixelFormat = Gdi.ChoosePixelFormat(pb3_hDC, pfd)
        pb1_hDC = User.GetDC(frmMain.pb1.Handle)
        PixelFormat = Gdi.ChoosePixelFormat(pb1_hDC, pfd)

        If PixelFormat = 0 Then
            MessageBox.Show("Unable to retrieve pixel format")
            End
        End If

        '1
        If Not (Gdi.SetPixelFormat(pb1_hDC, PixelFormat, pfd)) Then
            MessageBox.Show("Unable to set pixel format")
            End
        End If
        pb1_hRC = Wgl.wglCreateContext(pb1_hDC)

        '3
        If Not (Gdi.SetPixelFormat(pb3_hDC, PixelFormat, pfd)) Then
            MessageBox.Show("Unable to set pixel format")
            End
        End If
        pb3_hRC = Wgl.wglCreateContext(pb3_hDC)
        If pb3_hRC.ToInt32 = 0 Then
            MessageBox.Show("Unable to get rendering context")
            End
        End If
        If Not (Wgl.wglMakeCurrent(pb3_hDC, pb3_hRC)) Then
            MessageBox.Show("Unable to make rendering context current")
            End
        End If
  
        'Glut.glutInit()
        'Glut.glutInitDisplayMode(GLUT_RGBA Or GLUT_DOUBLE)

        ' -------------------------------------------------------------------
        Wgl.wglShareLists(pb3_hRC, pb1_hRC)
        'Wgl.wglShareLists(pb1_hRC, pb3_hRC)
        'Wgl.wglShareLists(pb1_hRC, pb4_hRC)
        'Wgl.wglMakeCurrent(pb1_hDC, pb1_hRC)
        Glut.glutInit()
        Glut.glutInitDisplayMode(GLUT_RGBA Or GLUT_DOUBLE)
        Gl.ReloadFunctions()
        build_shaders()

        'Gl.glEnable(Gl.GL_BLEND)
    End Sub
    Public Sub gl_set_lights()
        Gl.glClearColor(0.0F, 0.0F, 0.0F, 1.0F)
        'lighting

        'Debug.WriteLine("GL Error A:" + Gl.glGetError().ToString)
        'Gl.glEnable(Gl.GL_SMOOTH)
        'Gl.glShadeModel(Gl.GL_SMOOTH)
        'Debug.WriteLine("GL Error B:" + Gl.glGetError().ToString)

        Gl.glEnable(Gl.GL_COLOR_MATERIAL)
        Gl.glEnable(Gl.GL_LIGHT0)
        Gl.glEnable(Gl.GL_LIGHTING)
        Dim specReflection() As Single = {0.6F, 0.6F, 0.6F, 1.0F}
        Dim specular() As Single = {0.5F, 0.5F, 0.5F, 1.0F}
        Dim emission() As Single = {0.0F, 0.0F, 0.0F, 1.0F}
        Dim ambient() As Single = {0.5F, 0.5F, 0.5F, 1.0F}
        Dim global_ambient() As Single = {0.4F, 0.4F, 0.4F, 1.0F}
        Dim diffuseLight() As Single = {0.4, 0.4, 0.4, 1.0F}

        Dim mcolor() As Single = {0.8F, 0.8F, 0.8F, 1.0F}
        'Gl.glEnable(Gl.GL_SMOOTH)
        Gl.glShadeModel(Gl.GL_SMOOTH)

        Gl.glEnable(Gl.GL_LIGHT0)
        Gl.glEnable(Gl.GL_LIGHTING)

        'light 0
        Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, global_ambient)

        Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, specular)

        Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_EMISSION, emission)

        Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, diffuseLight)

        Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, ambient)

        Dim position() As Single = {100.0F, 100.0F, 100.0F, 1.0F}

        Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, position)

        Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL)

        Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, mcolor)
        Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, specReflection)
        Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, diffuseLight)
        Gl.glColorMaterial(Gl.GL_FRONT, Gl.GL_SPECULAR Or Gl.GL_AMBIENT_AND_DIFFUSE)


        Gl.glMateriali(Gl.GL_FRONT, Gl.GL_SHININESS, 60)
        Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST)
        Gl.glEnable(Gl.GL_COLOR_MATERIAL)

        'Gl.glFrontFace(Gl.GL_CCW)
        Gl.glClearDepth(1.0F)
        Gl.glEnable(Gl.GL_DEPTH_TEST)
        'Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_LOCAL_VIEWER, 1.0F)
        Gl.glEnable(Gl.GL_NORMALIZE)
        'Gl.glDisable(Gl.GL_NORMALIZE)


    End Sub

End Module
