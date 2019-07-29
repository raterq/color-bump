//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MoveToPositionComponent moveToPosition { get { return (MoveToPositionComponent)GetComponent(GameComponentsLookup.MoveToPosition); } }
    public bool hasMoveToPosition { get { return HasComponent(GameComponentsLookup.MoveToPosition); } }

    public void AddMoveToPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.MoveToPosition;
        var component = (MoveToPositionComponent)CreateComponent(index, typeof(MoveToPositionComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMoveToPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.MoveToPosition;
        var component = (MoveToPositionComponent)CreateComponent(index, typeof(MoveToPositionComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMoveToPosition() {
        RemoveComponent(GameComponentsLookup.MoveToPosition);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMoveToPosition;

    public static Entitas.IMatcher<GameEntity> MoveToPosition {
        get {
            if (_matcherMoveToPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoveToPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMoveToPosition = matcher;
            }

            return _matcherMoveToPosition;
        }
    }
}
