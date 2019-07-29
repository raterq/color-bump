using UnityEngine;

public interface ITransformReplacer
{
	void ReplacePosition(float x, float y, float z);

	void ReplaceScale(float x, float y, float z);

	void Rotate(Vector3 axis, float angle);
}
