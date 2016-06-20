using UnityEngine;
using System.Collections;

public class Init_Scene18 : MonoBehaviour
{

	public GameObject gameObj;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{
		Debug.Log ("Init_Scene18.OnMouseDown");

		StartCoroutine (GenerateKomaCube ());
		//StopCoroutine(GenerateKomaCube());

		Debug.Log ("dsfasdfas");
	}

	IEnumerator GenerateKomaCube ()
	{
		// 2秒休憩/等待2秒
		yield return new WaitForSeconds (2);

		for (int i = -5; i <= 5; i++) {
			for (int j = -5; j <= 5; j++) {
				GameObject obj = Instantiate (gameObj, new Vector3 (i * 2, 0.5f, j * 2), Quaternion.identity) as GameObject;
				obj.tag = "komaCube";
				yield return null;
			}
		}
	}

	void OnGUI ()
	{
		GUILayout.TextArea ("StartCoroutine演示");
	}
}
