Imports System
Imports Raylib_cs

Module Program
    Sub Main(args As String())
        RayLib.InitWindow(800, 600, "Hello world")
        Raylib.SetTargetFPS(60)
        while not CBool(Raylib.WindowShouldClose())
            Raylib.BeginDrawing()
            Raylib.ClearBackground(color.DARKGRAY)
            Raylib.DrawText(RayLib.GetFPS(), 10, 10, 20, color.WHITE)
            Raylib.EndDrawing()
        End While
        Raylib.CloseWindow()
    End Sub
End Module
