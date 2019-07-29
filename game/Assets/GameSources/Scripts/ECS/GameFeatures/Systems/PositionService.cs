using System.Collections.Generic;
using UnityEngine;

public class PositionService
{
    private const float _upOffset = 2;
    private const float _startZOffset = 2;
    private const float _lineStep = 1.5f;

    private const float _sizeMult = 1.5f;

    public IEnumerable<PositionData> GetObstaclesPositions(float lineLength, float linesCount)
    {
        var result = new List<PositionData>();

        for (var i = 0; i < linesCount; i++)
        {
            var zPos = _startZOffset + _lineStep * i;
            var border = -lineLength / 2;

            do
            {
                var size = GetRandomSize();

                var position = new Vector3(border, _upOffset, zPos);
                var data = new PositionData(position, size);

                result.Add(data);
                border += size.x * _sizeMult;

            } while (border < lineLength / 2);
        }

        return result;
    }

    private static Vector3 GetRandomSize() => 
        new Vector3(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
}