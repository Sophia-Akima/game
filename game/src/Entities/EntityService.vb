Imports game.Engine.Components

Namespace Engine.Entities
    
    ' According to ChatGPT 'module' is the equivalent of
    ' the 'static' keyword in C#
    public Module EntityService
        
        public Function CreatePlayer as Entity
            Dim entity as new Entity
            dim rand as new Random
            
            entity.Components.Add(new Position With { .X = 1000, .Y = 1000, .Speed = 15, .Width = 100, .Height = 100})
            
        End Function
        
        
    End Module
End Namespace