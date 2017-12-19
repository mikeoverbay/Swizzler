﻿Imports System.Text
Imports System.IO
Imports Tao.OpenGl
Imports Tao.Platform.Windows

Module GL_ShaderLoader
    Public color_pgm As Integer
    Public swizzler_pgm As Integer

    Public alpha As UInteger = 0
    Public c_address1, n_address1, l_address1 As Integer
    Public anm_n_address1, anm_l_address1, anm_cam_pos2 As Integer

    Public c_address, n_address, l_address, alphag, is_tank, mask, xform1, xform2, xform3 As Integer
    Public c_address2, n_address2, l0_address2, l1_address2, alphag2, cam_pos, is_tank1, is_tank2 As Integer
    Public alphaRef, alphaTest As Integer
    Public multitexture, metal_textured, show_uv2, c2_address2, cam_pos2, detail_tile_, metalMap, has_uv2_ As Integer
    Public _shadow, show_normals As Integer
    Public show_shadows As Integer
    Public aLight_matrix, aLight_matrixBump As Integer
    Public s_textureV As Integer
    Public s_textureH As Integer
    Public shadowMap, color_in, color_out As Integer
    Public r_mask, b_mask, g_mask, a_mask, preserve_, convert_rgb_NM, sw_alpha_value, sw_use_alpha_fill, sw_multiply As Integer
    Public sw_mask_location As Integer
    Public sw_mask_function As Integer
    Public sw_use_mask As Integer
    Public sw_mask_channels As Integer
    Public sw_mask_mix As Integer
    Public view_normal_mode_ As Integer
    Public sw_blend_alpha As Integer

    Public Sub build_shaders()
        Dim buf = Gl.glGetString(Gl.GL_EXTENSIONS).Split(" ")
        Dim ap As String = Application.StartupPath + "\shaders\"
        'bump_map shader
        Dim vs() As String = {New StreamReader(ap + "color_vertex.glsl").ReadToEnd}
        Dim fs() As String = {New StreamReader(ap + "color_fragment.glsl").ReadToEnd}
        color_pgm = build_shader(vs, fs, color_pgm, "color_pgm")
        '--------------------------------------------------------

        Dim vs9() As String = {New StreamReader(ap + "swizzler_vertex.glsl").ReadToEnd}
        Dim fs9() As String = {New StreamReader(ap + "swizzler_fragment.glsl").ReadToEnd}
        swizzler_pgm = build_shader(vs9, fs9, swizzler_pgm, "swizzler_pgm")

        Gl.glFinish() '<-- Make sure all shaders are done compiling. Not sure this is a real issue.

        '/////////////////////
        ' setup uniforms
        '////////////////////
        c_address = Gl.glGetUniformLocation(color_pgm, "colorMap")
        mask = Gl.glGetUniformLocation(color_pgm, "mask")


        color_in = Gl.glGetUniformLocation(swizzler_pgm, "colorMap_in")
        color_out = Gl.glGetUniformLocation(swizzler_pgm, "colorMap_out")
        r_mask = Gl.glGetUniformLocation(swizzler_pgm, "r_mask")
        g_mask = Gl.glGetUniformLocation(swizzler_pgm, "g_mask")
        b_mask = Gl.glGetUniformLocation(swizzler_pgm, "b_mask")
        a_mask = Gl.glGetUniformLocation(swizzler_pgm, "a_mask")
        preserve_ = Gl.glGetUniformLocation(swizzler_pgm, "preserve")
        convert_rgb_NM = Gl.glGetUniformLocation(swizzler_pgm, "convert_RGB_NM")
        sw_alpha_value = Gl.glGetUniformLocation(swizzler_pgm, "alpha_value")
        sw_use_alpha_fill = Gl.glGetUniformLocation(swizzler_pgm, "use_alpha_fill")
        sw_multiply = Gl.glGetUniformLocation(swizzler_pgm, "alpha_multiply")
        sw_mask_location = Gl.glGetUniformLocation(swizzler_pgm, "mask_texture")
        sw_mask_function = Gl.glGetUniformLocation(swizzler_pgm, "mask_function")
        sw_use_mask = Gl.glGetUniformLocation(swizzler_pgm, "use_mask")
        sw_mask_channels = Gl.glGetUniformLocation(swizzler_pgm, "mask_texture_channels")
        sw_mask_mix = Gl.glGetUniformLocation(swizzler_pgm, "mask_mix")
        sw_blend_alpha = Gl.glGetUniformLocation(swizzler_pgm, "use_alpha_blend")
    End Sub
    Public Function build_shader(vs() As String, fs() As String, shader As Integer, name As String) As Integer
        Dim vertexObject, fragmentObject, status_code As Integer
        Dim sb As New StringBuilder
        Dim len As Integer
        sb.Length = 1025

        '-----------------------------------------------------
        vertexObject = Gl.glCreateShader(Gl.GL_VERTEX_SHADER)

        ' Compile vertex shader
        Gl.glShaderSource(vertexObject, 1, vs, vs(0).Length)
        Gl.glCompileShader(vertexObject)
        Gl.glGetShaderiv(vertexObject, Gl.GL_COMPILE_STATUS, status_code)

        If status_code = 0 Then
            Gl.glGetInfoLogARB(fragmentObject, 1024, len, sb)
            MsgBox(name + " vertex didn't compile!" + vbCrLf + sb.ToString.Replace(vbLf, vbCrLf), MsgBoxStyle.Critical)
            Gl.glDeleteShader(vertexObject)
            Return -1
        End If

        fragmentObject = Gl.glCreateShader(Gl.GL_FRAGMENT_SHADER)

        ' Compile vertex shader
        Gl.glShaderSource(fragmentObject, 1, fs, fs(0).Length)
        Gl.glCompileShader(fragmentObject)
        Gl.glGetShaderiv(fragmentObject, Gl.GL_COMPILE_STATUS, status_code)
        If status_code = 0 Then
            Gl.glGetInfoLogARB(fragmentObject, 1024, len, sb)
            MsgBox(name + " Fragment didn't compile!" + vbCrLf + sb.ToString.Replace(vbLf, vbCrLf), MsgBoxStyle.Critical)
            Gl.glDeleteShader(fragmentObject)
            Return -1
        End If
        If Gl.glIsProgram(shader) Then
            Gl.glDeleteShader(shader)
        End If
        shader = Gl.glCreateProgram()
        Gl.glAttachShader(shader, fragmentObject)
        Gl.glAttachShader(shader, vertexObject)

        Gl.glLinkProgram(shader)
        Gl.glGetShaderiv(fragmentObject, Gl.GL_LINK_STATUS, status_code)

        If status_code = 0 Then
            Gl.glGetShaderInfoLog(shader, len, 8192, sb)
            MsgBox(name + "  did not Link!", MsgBoxStyle.Exclamation)

        End If
        Gl.glDeleteShader(fragmentObject)
        Gl.glDeleteShader(vertexObject)
        Return shader
    End Function
End Module