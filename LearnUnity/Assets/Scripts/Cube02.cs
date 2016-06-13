using UnityEngine;
using System.Collections;

public class Cube02 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter (Collision collision)
	{
		Debug.Log ("Cube02.OnCollisionEnter:" + collision.gameObject.name);
	}

	void OnBecameInvisible ()
	{
		Destroy (this.gameObject);
	}
}
