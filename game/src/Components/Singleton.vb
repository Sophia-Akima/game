Namespace Engine.Components
    
    public enum GameState
        Menu
        Game
        ExitGame
    End Enum
    
    public class Singleton
        Inherits Component
        
        public State as GameState = GameState.Menu
        public UserOptions as new UserOptions
    End class
    
    public class UserOptions
        Public Property SoundVolume as Single = 1.0F
    End class
End Namespace