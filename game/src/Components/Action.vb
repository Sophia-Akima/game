Namespace Engine.Components
    
    public enum Actions
            Interact
    End Enum
    
    public class Action
        Inherits Component
        
        public sub New(ByVal action as Actions)
            select case action
                case Actions.Interact
                    Console.WriteLine("Interact action")
                case Else
                    Throw New ArgumentException()
            End Select
        End sub
        
    End class
End Namespace