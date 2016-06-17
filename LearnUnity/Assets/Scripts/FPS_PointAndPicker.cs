using UnityEngine;
using System.Collections;

public class FPS_PointAndPicker : MonoBehaviour
{

	GameObject ball02;


	// Use this for initialization
	void Start ()
	{
		ball02 = GameObject.Find ("Ball02");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			this.GetComponent<AudioSource> ().Play ();
		}

		if (Input.GetKey (KeyCode.Q)) {
			ball02.transform.parent = transform;
			ball02.transform.position = transform.TransformPoint (new Vector3 (0, 0.1f, 2));
			Debug.Log(ball02.transform.position);
			ball02.GetComponent<Rigidbody> ().isKinematic = true;
		}

		if (Input.GetKey (KeyCode.E)) {
			if (ball02.transform.parent == this.transform) {
				ball02.GetComponent<Rigidbody> ().isKinematic = false;
				transform.DetachChildren ();

				Vector3 direct = transform.TransformDirection (new Vector3 (0, 0, 20));
				ball02.GetComponent<Rigidbody> ().AddForce (direct, ForceMode.Impulse);
			}
		}

	}
}
