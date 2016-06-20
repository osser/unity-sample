using UnityEngine;
using System.Collections;

public class Init_Scene15 : MonoBehaviour
{

	public GameObject gameObj;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (gameObj, new Vector3 (
				Random.Range (-10, 10),
				Random.Range (5, 10),
				Random.Range (-10, 10)
			), Quaternion.identity);
		}
	}

	void OnGUI ()
	{
		GUILayout.TextArea ("随机生成物体");
	}
}
