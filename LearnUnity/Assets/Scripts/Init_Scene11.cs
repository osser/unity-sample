using UnityEngine;
using System.Collections;

public class Init_Scene11 : MonoBehaviour {

	string message = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		var input = Input.mousePosition;
		var input = Input.GetMouseButton(0);
//		var input = Input.GetMouseButtonDown(0);
//		var input = Input.GetMouseButtonUp(0);
//		var input = Input.GetAxis("Horizontal");
//		var input = Input.GetButton("Jump");
		message = input.ToString();
	}

	void OnGUI(){
		GUILayout.TextArea("Inputデモ・输入演示");
		GUILayout.TextArea(message);
	}
}
