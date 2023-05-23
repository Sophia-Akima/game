Imports Raylib_cs
Imports game.Engine.Components
Imports game.Engine.Systems
Imports game.Engine.Entities

namespace Engine
    Class GameEngine
        
        Public Sub New
            
        End Sub
        
        Public Sub Run
            RayLib.InitWindow(800, 600, "Hello world")
            Raylib.SetTargetFPS(60)
        
            while not CBool(Raylib.WindowShouldClose())
                GameLoop()
            End While
            Raylib.CloseWindow()
        End Sub
        
        Public Sub GameLoop
            Raylib.BeginDrawing()
            Raylib.ClearBackground(color.DARKGRAY)
            Raylib.DrawText(RayLib.GetFPS(), 10, 10, 20, color.WHITE)
            Raylib.EndDrawing()
        End Sub
        
    End Class
End Namespace
