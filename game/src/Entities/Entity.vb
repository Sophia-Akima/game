imports game.Engine.Components

namespace Engine.Entities
    public class Entity
        
        public Components as new List(Of Components.Component)()
        
        public sub New()
            Me.Id = Guid.NewGuid()
        End sub
        public property Id as Guid
        
        public function shortId() as String
            return Me.Id.ToString().Substring(0, 4)
        End function
        
        public function getComponent(of T as Component)() as T
            Return Components.OfType(Of T)().FirstOrDefault()
        End function
        
        public function getComponents(of T as Component)() As IEnumerable(Of T)
            return Components.OfType(Of T)()
        End function
        
        public function hasTypes(ParamArray types as Type()) as Boolean
            return types.All(Function(t) Components.Any(function(c) c.GetType() = t))
        End function
        
    End class
End Namespace