using UnityEngine;
using System.Collections;

public class Ball03 : MonoBehaviour
{

	public AnimationCurve animCurve;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		// AnimationCurve
		float outputY = animCurve.Evaluate (Time.time) + 1;
		this.transform.position = new Vector3 (
			this.transform.position.x + Time.deltaTime,
			outputY,
			this.transform.position.z
		);
	}
}
