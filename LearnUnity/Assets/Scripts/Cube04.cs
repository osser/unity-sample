using UnityEngine;
using System.Collections;

public class Cube04 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Mathf.Lerp(min,max,step);
		float x = Mathf.Lerp(0, 4, Time.time);
//		Debug.Log("x:" + x);
		this.transform.position = new Vector3 (
			x,
			transform.position.y,
			transform.position.z
		);
	}
}
