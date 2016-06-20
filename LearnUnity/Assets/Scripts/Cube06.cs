using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]
public class Cube06 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		func1 ();
	}

	void func1 ()
	{
		Ray ray = new Ray (this.transform.position, Vector3.down);
		RaycastHit rayHit;
		if (Physics.Raycast (ray, out rayHit, 2.0f)) {
			this.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
			Debug.DrawRay (transform.position, Vector3.down * 2, Color.red);
		}
	}

}
