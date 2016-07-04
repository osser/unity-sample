using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class txtTItle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("txtTItle.Start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnPointerEnter (PointerEventData eventData)
	{
		Debug.Log("txtTItle.OnPointerEnter");
	}
}
