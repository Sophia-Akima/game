Imports System.Numerics
Imports Raylib_cs
Imports game.Engine.Components
Imports game.Engine.Systems
Imports game.Engine.Entities

namespace Engine
    Class GameEngine
        
        Dim SpriteSheet
        Dim CropRect
        Dim DestRect
        Dim CropRectX = 0
        Dim CropRectWidth = 8
        
        Public Sub New
            
        End Sub
        
        Public Sub Run
            RayLib.InitWindow(800, 600, "Hello world")
            Raylib.SetTargetFPS(60)
            
             SpriteSheet = RayLib.LoadTexture("src/assets/alphanumeric.png")
             CropRect = new Rectangle(CropRectX,0,CropRectWidth,8)
             DestRect = new Rectangle(50, 50, 64, 64)
            
            while not CBool(Raylib.WindowShouldClose())
                GameLoop()
            End While
            Raylib.CloseWindow()
        End Sub
        
        
        Public Sub GameLoop
            Raylib.BeginDrawing()
            Raylib.ClearBackground(color.DARKGRAY)
            Raylib.DrawText(RayLib.GetFPS(), 10, 10, 20, color.WHITE)
            Raylib.DrawTexturePro(SpriteSheet, CropRect, DestRect, New Vector2(0, 0), 0, new Color(255,255,255,255))
            
            if Raylib.IsKeyReleased(KeyboardKey.KEY_D) Then
                CropRectX += 8
                CropRect = new Rectangle(CropRectX, 0, CropRectWidth, 8)
                Console.WriteLine(CropRectX)
            End If
            
            if Raylib.IsKeyReleased(KeyboardKey.KEY_A) Then
                If Not ((CropRectX - 8) <= -1) then CropRectX -= 8
                CropRect = new Rectangle(CropRectX, 0, CropRectWidth, 8)
                Console.WriteLine(CropRectX)
            End If
            
            Raylib.EndDrawing()
        End Sub
        
    End Class
End Namespace
