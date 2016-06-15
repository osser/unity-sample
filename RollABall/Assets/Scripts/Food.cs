using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.Rotate (Vector3.up, Space.World);
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Food.OnTriggerEnter:" + other.name);
	}

	void OnTriggerStay (Collider other)
	{
	}

	void OnTriggerExit (Collider other)
	{
		//Destroy(other.gameObject);
	}
}
