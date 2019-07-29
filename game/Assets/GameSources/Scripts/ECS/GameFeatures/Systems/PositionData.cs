using UnityEngine;

public struct PositionData
{
    public Vector3 Position { get; }
    public Vector3 Size { get; }

    public PositionData(Vector3 position, Vector3 size)
    {
        Position = position;
        Size = size;
    }
}