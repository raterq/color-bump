using UnityEngine;

public class GameObjectFactory
{
	public TReturn InstantiateObject<TReturn,TComponent>(string path) where TComponent : Component,TReturn
	{
		return AddComponent<TReturn, TComponent>(Instantiate(path));
	}

	public TComponent AddComponent<TReturn, TComponent>(GameObject obj) where TComponent : Component,TReturn
	{
		return obj.AddComponent<TComponent>();
	}

	public GameObject Instantiate(string path)
	{
		return Object.Instantiate(Resources.Load(path)) as GameObject;
	}
}
