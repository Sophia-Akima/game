Imports System.Numerics
Imports Raylib_cs

Namespace Engine.Components
    Public Class Render
        Inherits Component
        
        public Texture as Texture2D
        public Rectangle as Rectangle
        public IsAnimated as Boolean
        public Direction as Single = 0F
        
        public sub New(ByVal texture as Texture2D)
            Texture = texture
            rectangle = New Rectangle(0, 0, texture.width, texture.height)
        End sub

        public sub New(byval path as String)
            Texture = Raylib.LoadTexture(path)
            Rectangle = New Rectangle(0, 0, Texture.width, Texture.height)
        End sub
        
        public sub New 
            
        End sub
        
        public sub UpdateRect()
            Rectangle = New Rectangle(0, 0, Texture.width, Texture.height)
        End sub
        
        public function GetCenter() as Vector2
            Return new Vector2(Rectangle.width / 2, Rectangle.height / 2)
        End function
        
    End Class
End Namespace