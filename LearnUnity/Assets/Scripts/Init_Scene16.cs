using UnityEngine;
using System.Collections;

public class Init_Scene16 : MonoBehaviour
{

	public GameObject gameObj;

	// Use this for initialization
	void Start ()
	{
		for (int i = -1; i <= 1; i++) {
			for (int j = -1; j <= 1; j++) {
				GameObject obj = Instantiate (gameObj, new Vector3 (i * 2, 0.5f, j * 2), Quaternion.identity) as GameObject;
				obj.tag = "komaCube";
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			foreach (var obj in GameObject.FindGameObjectsWithTag("komaCube")) {
				obj.BroadcastMessage ("hide", false);
			}
		}
	}

	void OnGUI(){
		GUILayout.TextArea("BroadcastMessage演示");
	}
}
