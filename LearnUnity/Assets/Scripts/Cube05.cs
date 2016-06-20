using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Cube05 : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
//		var floatX = Input.GetAxis ("Horizontal") * 2;
//		var floatZ = Input.GetAxis ("Vertical") * 2;
		var floatX = Input.GetAxisRaw ("Horizontal") * 2;
		var floatZ = Input.GetAxisRaw ("Vertical") * 2;

		this.transform.position = new Vector3 (floatX, transform.position.y, floatZ);
	}

	void OnMouseDown ()
	{
		Debug.Log ("Cube05.OnMouseDown");

		this.transform.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 10, ForceMode.Impulse);
	}

	void OnMouseEnter ()
	{
		Debug.Log ("Cube05.OnMouseEnter");

	}

	void OnMouseExit ()
	{
		Debug.Log ("Cube05.OnMouseExit");

	}

	void OnMouseDrag ()
	{
		Debug.Log ("Cube05.OnMouseDrag");

	}

	void OnMouseUp ()
	{
		Debug.Log ("Cube05.OnMouseUp");

	}

	void OnMouseOver ()
	{
		Debug.Log ("Cube05.OnMouseOver");

	}
}
