using Entitas;

public class ObstacleComponent : IComponent { }
public class RightObstacleComponent : IComponent { }
public class ObstacleBehaviourComponent : IComponent
{
    public IObstacle value;
}

public class CharacterComponent : IComponent { }