using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformReplacer : MonoBehaviour, ITransformReplacer
{
	public void ReplacePosition(float x, float y, float z)
	{
		transform.position = new Vector3(x,y,z);
	}

	public void ReplaceScale(float x, float y, float z)
	{
		transform.localScale = new Vector3(x, y, z);
	}

	public void Rotate(Vector3 axis,float angle)
	{
		transform.Rotate(axis,angle);
	}
}
