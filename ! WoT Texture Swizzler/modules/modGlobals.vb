Module modGlobals
    Public R_ As Integer = 1
    Public G_ As Integer = 2
    Public B_ As Integer = 4
    Public A_ As Integer = 8
    Public C_R_ As Integer = 1
    Public C_G_ As Integer = 2
    Public C_B_ As Integer = 4
    Public C_A_ As Integer = 8
    Public M_R_ As Integer = 1
    Public M_G_ As Integer = 2
    Public M_B_ As Integer = 4
    Public M_A_ As Integer = 8

    Public Temp_Storage As String
    Public temp_image As Integer = -1
    Public temp_image2 As Integer = -1

    Public Zoom_Factor As Single

    Public old_h, old_w As Integer
    Public sImageWidth As Integer
    Public sImageHeight As Integer
    Public old_sImageWidth As Integer
    Public old_sImageHeight As Integer
    Public rect_location As New Point
    Public rect_size As New Point
    Public old_rect_location As New Point
    Public old_rect_size As New Point
    Public old_sbox As New l_
    Public _Started As Boolean = False
    '--------------------------------------------
    'combiner variables
    Public combiner_rec_size As New Point
    Public combiner_image_size As New Point(0, 0)
    Public open_size As New Point(0, 0)
    Public r_size, g_size, b_size, a_size As New Point

    Public cb_image_r, cb_image_g, cb_image_b, cb_image_a As Integer
    Public source_filename As String = ""

    Public current_texture_id(9) As Integer

    Public sphere_model As Integer
    Public sphere_texture As Integer
    Public Structure vector
        Public X, Y, Z As Double
    End Structure
End Module
