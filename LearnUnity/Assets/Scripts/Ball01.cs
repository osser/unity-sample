using UnityEngine;
using System.Collections;

public class Ball01 : MonoBehaviour
{

	private Vector3 initPosition;
	// Use this for initialization
	void Start ()
	{
		initPosition = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.collider.name.CompareTo ("Ground") == 0) {
			this.gameObject.transform.position = initPosition;
		}
	}
}
