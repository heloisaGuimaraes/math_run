using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class NewButton : MonoBehaviour,  IPointerDownHandler, IPointerUpHandler {
	public float precionar;
	public void OnPointerDown(PointerEventData eventData){
		precionar = -1;

	}
	public void OnPointerUp(PointerEventData eventData){
		precionar = 0;
	}
}
