using UnityEngine;

public class DestroyerBehaviour : MonoBehaviour, IDestroyer
{
	public void DestroyObject()
	{
		Destroy(gameObject);
	}
}
