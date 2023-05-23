Imports System.Numerics
Imports Raylib_cs

namespace Engine.Components
    public class Position
        Inherits Component
        
        Public X as Single
        Public Y as Single
        Public Width as Single
        Public Height as Single
        Public Speed as Single = 2.0F
        Public Direction as Single = 0F
        
        Public ReadOnly Property Rectangle As Rectangle
            Get
                Return New Rectangle(X, Y, Width, Height)
            End Get
        End Property
        
        Public ReadOnly Property RectCenter as Rectangle
            Get
                Return New Rectangle(X - Width/2, Y - Height/2, Width, Height)
            End Get
        End Property

        Public ReadOnly Property AsVector as Vector2
            Get
                Return New Vector2(X, Y)
            End Get
        End Property
        
        Public ReadOnly Property GetCenter As Vector2
            Get
                Return New Vector2(X + (Width/2), Y + (Height/2))
            End Get
        End Property
        
        Public ReadOnly Property GetRectCenter As Vector2
            Get
                Return New Vector2(Width/2, Height/2)
            End Get
        End Property    

        
        'Public Function AsVector() as Vector2
        '    Return New Vector2(X, Y)
        'End Function
        
        'Public Function GetCenter() As Vector2
        '    Return New Vector2(X + (Width/2), Y + (Height/2))
        'End Function
        
        'Public Function GetRectCenter() As Vector2
        '    Return New Vector2(Width/2, Height/2)
        'End Function
        
    End class
End Namespace