Namespace Engine.Components
    
    public enum CharacterState
        Idle
        Moving
    End Enum
    
    public class State
        Inherits Component
        public CharacterState as CharacterState = CharacterState.Idle
    End class
End Namespace