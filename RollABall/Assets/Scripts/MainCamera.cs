using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour
{

	public GameObject Ball;

	private Vector3 offset;

	// Use this for initialization
	void Start ()
	{
		offset = this.gameObject.transform.position - Ball.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position = Ball.transform.position + offset;
	}
}
