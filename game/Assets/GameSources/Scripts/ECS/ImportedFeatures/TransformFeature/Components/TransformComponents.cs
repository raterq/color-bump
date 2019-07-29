using Entitas;
using UnityEngine;

public class PositionComponent : IComponent
{
    public Vector3 value;
}
public class ScaleComponent : IComponent
{
    public float x;
    public float y;
    public float z;
}
public class MoveToPositionComponent : IComponent
{
    public Vector3 Value;
}
public class RotateComponent : IComponent
{
    public Vector3 axis;
    public float angle;
}
public class TimeComponent : IComponent{public float value;}
public class LerpMoveComponent : IComponent { }
public class TowardsMoveComponent : IComponent { }
public class AmplitudeComponent : IComponent { public float value;}
public class DirectionComponent : IComponent {public int value;}
public class SpeedComponent : IComponent { public float value;}
public class MovableComponent : IComponent { }
public class TransformReplacerComponent : IComponent { public ITransformReplacer value; }
public class SinusoidalAxis : IComponent { public Vector3 Value; }
public class SinusoidalMove : IComponent
{
    public float speed;
}

public class TowardMoveSpeed : IComponent
{
    public float Value;
}

public class DirectionMoveSpeed : IComponent
{
    public float Value;
}

public class DirectionMoveComponent : IComponent {}
public class DirectionAxisComponent : IComponent { public Vector3 Value; }