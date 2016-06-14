using UnityEngine;
using System.Collections;

public class Init_Scene02 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		GameObject newCube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		newCube.transform.position = new Vector3 (0, 2f, 4);
		newCube.transform.localScale = new Vector3 (4, 4, 4);
		newCube.GetComponent<MeshRenderer> ().material.color = Color.green;
		newCube.AddComponent<Rigidbody> ();
		newCube.AddComponent<AutoDestroy> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
