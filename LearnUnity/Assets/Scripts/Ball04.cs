using UnityEngine;
using System.Collections;

public class Ball04 : MonoBehaviour
{

	Vector3 target = new Vector3 (4f, 0.5f, 4f);

	Vector3 direction;


	// Use this for initialization
	void Start ()
	{
		direction = target - this.transform.position;

//		Debug.Log (direction);
//		Debug.Log (direction.normalized);

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void FixedUpdate ()
	{
		//Vector3 result = target - this.transform.position;

		float distance = Vector3.Distance (target, this.transform.position);

		if (distance > 0.1)
			this.transform.Translate (direction.normalized * Time.deltaTime, Space.World);
		else
			this.transform.position = target;
	}

	void OnGUI(){
		GUILayout.TextArea("目標へ進む・向着目标前进");
	}
}
