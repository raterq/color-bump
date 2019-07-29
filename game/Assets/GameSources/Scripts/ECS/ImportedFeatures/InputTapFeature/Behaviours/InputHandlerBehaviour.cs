using UnityEngine;
using UnityEngine.EventSystems;

public class InputTapHandlerBehaviour : MonoBehaviour, IInputTapHandler, IPointerDownHandler, IPointerUpHandler
{
	public bool Tapped { get; private set; }

	public void OnPointerDown(PointerEventData eventData)
	{
		Tapped = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		Tapped = false;
	}
}
