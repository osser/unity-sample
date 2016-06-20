using UnityEngine;
using System.Collections;

public class MainCameraRay : MonoBehaviour
{

	public float RayLength = 1000f;


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = this.GetComponent<Camera> ().ScreenPointToRay (Input.mousePosition);
		Debug.Log(ray);
		RaycastHit rayHit;

		if (Physics.Raycast (ray, out rayHit, RayLength)) {
			Debug.Log (rayHit.collider.name);
		}
	}
}
