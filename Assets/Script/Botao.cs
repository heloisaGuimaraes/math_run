using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Botao : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	public float pressing;
	// Use this for initialization
	public void OnPointerDown(PointerEventData eventData){
		pressing = 1;

	}
	public void OnPointerUp(PointerEventData eventData){
		pressing = 0;
	}
}
