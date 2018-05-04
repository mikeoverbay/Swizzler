Imports System.Text
Imports System.IO
Imports Tao.OpenGl
Imports Tao.Platform.Windows

Module GL_ShaderLoader
    Public color_pgm As Integer
    Public swizzler_pgm As Integer
    Public maskgen_pgm As Integer
    Public combiner_pgm As Integer
    Public mg_color As Integer
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
    Public r_mask, b_mask, g_mask, a_mask, convert_rgb_NM, sw_alpha_value, sw_use_alpha_fill, sw_multiply As Integer
    Public sw_flip_y, sw_flip_x As Integer
    Public sw_mask_location As Integer
    Public sw_mask_function As Integer
    Public sw_use_mask As Integer
    Public sw_mask_channels As Integer
    Public sw_mask_mix As Integer
    Public view_normal_mode_ As Integer
    Public sw_blend_alpha As Integer

    Public comb_texture1, comb_texture2, comb_texture3, comb_texture4 As Integer
    Public comb_M_1, comb_M_2, comb_M_3, comb_M_4 As Integer
    Public comb_r_level, comb_g_level, comb_b_level, comb_a_level As Integer

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

        Dim vs1() As String = {New StreamReader(ap + "maskGen_vertex.glsl").ReadToEnd}
        Dim fs1() As String = {New StreamReader(ap + "maskGen_fragment.glsl").ReadToEnd}
        maskgen_pgm = build_shader(vs1, fs1, maskgen_pgm, "maskgen_pgm")

        Dim vs11() As String = {New StreamReader(ap + "combiner_vertex.glsl").ReadToEnd}
        Dim fs11() As String = {New StreamReader(ap + "combiner_fragment.glsl").ReadToEnd}
        combiner_pgm = build_shader(vs11, fs11, combiner_pgm, "combiner_pgm")

        Gl.glFinish() '<-- Make sure all shaders are done compiling. Not sure this is a real issue.

        '/////////////////////
        ' setup uniforms
        '////////////////////
        c_address = Gl.glGetUniformLocation(color_pgm, "colorMap")
        mask = Gl.glGetUniformLocation(color_pgm, "mask")
        '==========================================================================================

        mg_color = Gl.glGetUniformLocation(maskgen_pgm, "colorMap")
        '==========================================================================================

        color_in = Gl.glGetUniformLocation(swizzler_pgm, "colorMap_in")
        color_out = Gl.glGetUniformLocation(swizzler_pgm, "colorMap_out")
        r_mask = Gl.glGetUniformLocation(swizzler_pgm, "r_mask")
        g_mask = Gl.glGetUniformLocation(swizzler_pgm, "g_mask")
        b_mask = Gl.glGetUniformLocation(swizzler_pgm, "b_mask")
        a_mask = Gl.glGetUniformLocation(swizzler_pgm, "a_mask")
        convert_rgb_NM = Gl.glGetUniformLocation(swizzler_pgm, "convert_RGB_NM")
        sw_flip_x = Gl.glGetUniformLocation(swizzler_pgm, "flip_x")
        sw_flip_y = Gl.glGetUniformLocation(swizzler_pgm, "flip_y")
        sw_alpha_value = Gl.glGetUniformLocation(swizzler_pgm, "alpha_value")
        sw_use_alpha_fill = Gl.glGetUniformLocation(swizzler_pgm, "use_alpha_fill")
        sw_multiply = Gl.glGetUniformLocation(swizzler_pgm, "alpha_multiply")
        sw_mask_location = Gl.glGetUniformLocation(swizzler_pgm, "mask_texture")
        sw_mask_function = Gl.glGetUniformLocation(swizzler_pgm, "mask_function")
        sw_use_mask = Gl.glGetUniformLocation(swizzler_pgm, "use_mask")
        sw_mask_channels = Gl.glGetUniformLocation(swizzler_pgm, "mask_texture_channels")
        sw_mask_mix = Gl.glGetUniformLocation(swizzler_pgm, "mask_mix")
        sw_blend_alpha = Gl.glGetUniformLocation(swizzler_pgm, "use_alpha_blend")
        '==========================================================================================

        comb_texture1 = Gl.glGetUniformLocation(combiner_pgm, "texture_1")
        comb_texture2 = Gl.glGetUniformLocation(combiner_pgm, "texture_2")
        comb_texture3 = Gl.glGetUniformLocation(combiner_pgm, "texture_3")
        comb_texture4 = Gl.glGetUniformLocation(combiner_pgm, "texture_4")
        comb_M_1 = Gl.glGetUniformLocation(combiner_pgm, "r_mask")
        comb_M_2 = Gl.glGetUniformLocation(combiner_pgm, "g_mask")
        comb_M_3 = Gl.glGetUniformLocation(combiner_pgm, "b_mask")
        comb_M_4 = Gl.glGetUniformLocation(combiner_pgm, "a_mask")
        comb_r_level = Gl.glGetUniformLocation(combiner_pgm, "r_level")
        comb_g_level = Gl.glGetUniformLocation(combiner_pgm, "g_level")
        comb_b_level = Gl.glGetUniformLocation(combiner_pgm, "b_level")
        comb_a_level = Gl.glGetUniformLocation(combiner_pgm, "a_level")


    End Sub
    Public Function build_shader(vs() As String, fs() As String, shader As Integer, name As String) As Integer
        Dim vertexObject, fragmentObject, status_code As Integer
        Dim sb As New StringBuilder
        Dim len As Integer = 0
        sb.Length = 2025

        '-----------------------------------------------------
        vertexObject = Gl.glCreateShader(Gl.GL_VERTEX_SHADER)

        ' Compile vertex shader
        Gl.glShaderSource(vertexObject, 1, vs, vs(0).Length)
        Gl.glCompileShader(vertexObject)
        Gl.glGetShaderiv(vertexObject, Gl.GL_COMPILE_STATUS, status_code)

        If status_code = 0 Then
            Gl.glGetShaderInfoLog(vertexObject, 1024, len, sb)
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
            Gl.glGetShaderInfoLog(fragmentObject, 1024, len, sb)
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
            Gl.glGetShaderInfoLog(shader, 8192, len, sb)
            MsgBox(name + "  did not Link!", MsgBoxStyle.Exclamation)

        End If
        Gl.glDeleteShader(fragmentObject)
        Gl.glDeleteShader(vertexObject)
        Return shader
    End Function
End Module
