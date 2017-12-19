Imports System.IO
Imports System.String
Imports System.Text
Imports FastColoredTextBoxNS
Imports System.Linq
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions
Imports System.Drawing.Drawing2D
Imports Tao.OpenGl
Public Class frmEditFrag
	Dim f_app_path As String = ""
	Dim v_app_path As String = ""
	Dim end_f As String = "_fragment.glsl"
	Dim end_v As String = "_vertex.glsl"
	Dim shader_index As Integer
	Dim ct As New Control
	Dim f_height As Integer
	Dim f_new_height As Integer
	Dim lang As String = "CSharp (custom highlighter)"
	Dim TealStyle As TextStyle = New TextStyle(Brushes.LightBlue, Nothing, FontStyle.Regular)
	Dim BoldStyle As TextStyle = New TextStyle(Nothing, Nothing, FontStyle.Bold Or FontStyle.Underline)
	Dim GrayStyle As TextStyle = New TextStyle(Brushes.Gray, Nothing, FontStyle.Regular)
	Dim PowderBlueStyle As TextStyle = New TextStyle(Brushes.PowderBlue, Nothing, FontStyle.Regular)
	Dim GreenStyle As TextStyle = New TextStyle(Brushes.Green, Nothing, FontStyle.Italic)
	Dim BrownStyle As TextStyle = New TextStyle(Brushes.Brown, Nothing, FontStyle.Italic)
	Dim MaroonStyle As TextStyle = New TextStyle(Brushes.Maroon, Nothing, FontStyle.Regular)
	Dim GLSLstyle As TextStyle = New TextStyle(Brushes.LightGreen, Nothing, FontStyle.Regular)

	Dim SameWordsStyle As MarkerStyle = New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.Gray)))

	Private Sub frmEditFrag_Load(sender As Object, e As EventArgs) Handles Me.Load
		f_app_path = Application.StartupPath + "\shaders\"
		v_app_path = Application.StartupPath + "\shaders\"
		vert_tb.AcceptsTab = True
		frag_tb.AcceptsTab = True
		CB1.Items.Add("color")
        CB1.Items.Add("swizzler")

		'CB1.Items.Add("shadow_test")
		recompile_bt.Enabled = False
		Me.Text = "Shader Editor:"
		ct = vert_tb
	End Sub


	Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged
		Dim shader As String = CB1.Items(CB1.SelectedIndex)
		Me.Text = "Shader Editor: " + shader
		f_app_path = Application.StartupPath + "\shaders\" + shader + end_f
		v_app_path = Application.StartupPath + "\shaders\" + shader + end_v
		vert_tb.Text = File.ReadAllText(v_app_path)
		frag_tb.Text = File.ReadAllText(f_app_path)
		shader_index = CB1.SelectedIndex
		recompile_bt.Enabled = True
		TabControl1.SelectedIndex = 1
		ct = frag_tb
		reset_focus()
	End Sub
	Private Sub reset_focus()
		ct.Focus()
	End Sub
	Private Sub recompile_bt_Click(sender As Object, e As EventArgs) Handles recompile_bt.Click
		Dim len As Integer = 0
		Dim SB As New StringBuilder
		recompile_bt.Enabled = False
		File.WriteAllText(v_app_path, vert_tb.Text)
		File.WriteAllText(f_app_path, frag_tb.Text)

		Dim buf = Gl.glGetString(Gl.GL_EXTENSIONS).Split(" ")
		Dim ap As String = Application.StartupPath

		Dim info As New StringBuilder
		Dim info_l As Integer = 1
        Dim vs3() As String = {File.ReadAllText(v_app_path)}
        Dim fs3() As String = {File.ReadAllText(f_app_path)}
        Select Case shader_index
            Case 0
                Gl.glDeleteShader(color_pgm)
                color_pgm = build_shader(vs3, fs3, color_pgm, "color_pgm")
            Case 1
                swizzler_pgm = build_shader(vs3, fs3, swizzler_pgm, "swizzler_pgm")
        End Select
		Gl.glFinish()

        frmMain.draw(True)
		recompile_bt.Enabled = True
		reset_focus()

	End Sub


	Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
		Dim tab = TabControl1.SelectedIndex
		Select Case tab
			Case 0
				vert_tb.Focus()
			Case 1
				frag_tb.Focus()
		End Select

	End Sub

	Private Sub vert_tb_GotFocus(sender As Object, e As EventArgs) Handles vert_tb.GotFocus
		ct = vert_tb

	End Sub



	Private Sub vert_tb_TextChanged(sender As Object, e As TextChangedEventArgs) Handles vert_tb.TextChanged
		CSharpSyntaxHighlight(vert_tb, e) 'custom highlighting
	End Sub

	Private Sub frag_tb_GotFocus(sender As Object, e As EventArgs) Handles frag_tb.GotFocus
		ct = frag_tb
	End Sub


	Private Sub frag_tb_TextChanged(sender As Object, e As TextChangedEventArgs) Handles frag_tb.TextChanged
		CSharpSyntaxHighlight(frag_tb, e) 'custom highlighting
    End Sub

	Private Sub CSharpSyntaxHighlight(ByRef sender As FastColoredTextBox, e As TextChangedEventArgs)
		e.ChangedRange.SetFoldingMarkers("", "")
		sender.LeftBracket = "("c
		sender.RightBracket = ")"c
		sender.LeftBracket2 = ControlChars.NullChar
		sender.RightBracket2 = ControlChars.NullChar
		'clear style of changed range
		e.ChangedRange.ClearStyle(TealStyle, BoldStyle, GrayStyle, PowderBlueStyle, GreenStyle, BrownStyle)

		'string highlighting
		e.ChangedRange.SetStyle(BrownStyle, """""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'")
		'comment highlighting
		e.ChangedRange.SetStyle(GreenStyle, "//.*$", RegexOptions.Multiline)
		e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline)
		e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline Or RegexOptions.RightToLeft)
		'number highlighting
		e.ChangedRange.SetStyle(PowderBlueStyle, "\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b")
		'attribute highlighting
		e.ChangedRange.SetStyle(GrayStyle, "^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline)
		'class name highlighting
		e.ChangedRange.SetStyle(BoldStyle, "\b(class|struct|enum|interface)\s+(?<range>\w+?)\b")
		'keyword highlighting
		e.ChangedRange.SetStyle(TealStyle, "\b(mat3|mat4|vec2|vec3|vec4|abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b")
		'GLSL keyword highlighting
		e.ChangedRange.SetStyle(GLSLstyle, "\b(uniform|varying|attribute|gl_Vertex|gl_NormalMatrix|gl_ModelViewMatrix|" _
										+ "gl_ModelViewProjectionMatrix|gl_Position|ftransform|mix|max|min|dfdx|dfdy|gl_FragColor|" _
										+ "gl_MultiTexCoord0|gl_MultiTexCoord1|gl_MultiTexCoord2|gl_MultiTexCoord3|gl_MultiTexCoord4|" _
										+ "reflact|fract|smoothstep|step|normalize|dot|cross|gl_Normal|pow|gl_LightSource|" _
										+ "gl_FrontMaterial|clamp|reflect|gl_Fog|gl_FragCoord|discard\b)")

		'clear folding markers
		e.ChangedRange.ClearFoldingMarkers()

		'set folding markers
		e.ChangedRange.SetFoldingMarkers("{", "}")
		'allow to collapse brackets block
		e.ChangedRange.SetFoldingMarkers("#region\b", "#endregion\b")
		'allow to collapse #region blocks
		e.ChangedRange.SetFoldingMarkers("/\*", "\*/")
		'allow to collapse comment block


	End Sub

	Private Sub CB1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB1.SelectionChangeCommitted
		TabControl1.SelectedTab = TabPage1
		Application.DoEvents()
		reset_focus()

	End Sub

	Private Sub cm_cut_Click(sender As Object, e As EventArgs) Handles cm_cut.Click
		vert_tb.Copy()
	End Sub

	Private Sub cm_copy_Click(sender As Object, e As EventArgs) Handles cm_copy.Click
		vert_tb.Copy()
	End Sub

	Private Sub cm_paste_Click(sender As Object, e As EventArgs) Handles cm_paste.Click
		vert_tb.Paste()
	End Sub

	Private Sub cm_delete_Click(sender As Object, e As EventArgs) Handles cm_delete.Click
		vert_tb.ClearSelected()
	End Sub

	Private Sub cm_undo_Click(sender As Object, e As EventArgs) Handles cm_undo.Click
		vert_tb.Undo()
	End Sub

	Private Sub cm_redo_Click(sender As Object, e As EventArgs) Handles cm_redo.Click
		vert_tb.Redo()
	End Sub

	Private Sub cm2_cut_Click(sender As Object, e As EventArgs) Handles cm2_cut.Click
		frag_tb.Cut()
	End Sub

	Private Sub cm2_copy_Click(sender As Object, e As EventArgs) Handles cm2_copy.Click
		frag_tb.Copy()
	End Sub

	Private Sub cm2_paste_Click(sender As Object, e As EventArgs) Handles cm2_paste.Click
		frag_tb.Paste()
	End Sub

	Private Sub cm2_delete_Click(sender As Object, e As EventArgs) Handles cm2_delete.Click
		frag_tb.ClearSelected()
	End Sub

	Private Sub cm2_undo_Click(sender As Object, e As EventArgs) Handles cm2_undo.Click
		frag_tb.Undo()
	End Sub

	Private Sub Redo_Click(sender As Object, e As EventArgs) Handles Redo.Click
		frag_tb.Redo()
	End Sub


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim s As String = ""
		Dim tab = TabControl1.SelectedIndex
		If tab = 0 Then
			If vert_tb.SelectedText.Length > 0 Then
				s = vert_tb.SelectedText
			End If
		Else
			If frag_tb.SelectedText.Length > 0 Then
				s = frag_tb.SelectedText.ToString
			End If
		End If
		If s.Length = 0 Then Return
		'www.opengl.org%2Fsdk%2Fdocs%2Fman%2Fhtml%2Fclamp.xhtml
		Dim s2 As String = "https://www.google.com/?gws_rd=ssl#q=" + s

		System.Diagnostics.Process.Start(s2)
		reset_focus()

	End Sub

	Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles Button1.Leave
		'reset_focus()
	End Sub
End Class