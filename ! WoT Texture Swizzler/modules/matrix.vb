Imports System.Math
Module matrix
    Public Function transform(ByVal v As vector, ByVal m() As Double) As vector
        Dim vo As vector
        'row
        vo.X = (m(0) * v.X) + (m(4) * v.Y) + (m(8) * v.Z)
        vo.Y = (m(1) * v.X) + (m(5) * v.Y) + (m(9) * v.Z)
        vo.Z = (m(2) * v.X) + (m(6) * v.Y) + (m(10) * v.Z)

        'column
        'vo.x = (m(0) * v.x) + (m(4) * v.y) + (m(8) * v.x)
        'vo.y = (m(1) * v.y) + (m(5) * v.y) + (m(9) * v.y)
        'vo.z = (m(2) * v.z) + (m(6) * v.z) + (m(10) * v.z)


        vo.X += m(12)
        vo.Y += m(13)
        vo.Z += m(14)

        Return vo

    End Function

End Module
