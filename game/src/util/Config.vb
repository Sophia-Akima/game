Imports System.Runtime.CompilerServices
Imports game.Engine.Components

namespace Engine
    public module Config
        
        <Extension()>
        public sub LoadConfig(ByVal engine as GameEngine)
            ' this doesnt work and I dont understand why exactly
            ' too tired to fix rn though
            Dim singleton = engine.GetComponent(Of Singleton())
        End sub
        
    End module
End Namespace