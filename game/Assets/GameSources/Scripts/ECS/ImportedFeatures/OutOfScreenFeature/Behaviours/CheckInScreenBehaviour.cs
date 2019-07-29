using System;
using UnityEngine;


public class CheckInScreenBehaviour : MonoBehaviour, ICheckInScreen
{
	public bool InScreen { get; private set; }

	private Vector2 _boundsSize;

	private Vector2 _screenBorders;

	private void Awake()
	{
		var mainCamera = Camera.main;
		if (mainCamera == null)
			throw new ApplicationException("Dont have main camera on scene");

		_boundsSize = BoundsTool.instance.GetBoundsAll(transform).size;
		var height = mainCamera.orthographicSize;
		var width = height * mainCamera.aspect;
		_screenBorders = new Vector2(width, height);
	}

	private void Update() => InScreen = IsVisible();

	private bool IsVisible()
	{
		if (Mathf.Abs(transform.position.x) > _screenBorders.x + _boundsSize.x/2)
			return false;

		if(Mathf.Abs(transform.position.y) > _screenBorders.y + _boundsSize.y / 2)
			return false;

		return true;
	}
}
