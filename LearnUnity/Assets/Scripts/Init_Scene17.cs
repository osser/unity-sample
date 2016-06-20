using UnityEngine;
using System.Collections;

public class Init_Scene17 : MonoBehaviour
{

	public GameObject preKomaCube;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			//Invoke ("SpawnKomaCube", 2f);
			InvokeRepeating ("SpawnKomaCube", 2f, 1f);
		}

		if (Input.GetKeyDown (KeyCode.Q) && IsInvoking ("SpawnKomaCube")) {
			CancelInvoke ("SpawnKomaCube");
		}
	}

	void SpawnKomaCube ()
	{
		Instantiate (preKomaCube, new Vector3 (0, 5, 0), Quaternion.identity);

	}

	void OnGUI ()
	{
		GUILayout.TextArea ("Invoke/InvokeRepeating");
	}
}
