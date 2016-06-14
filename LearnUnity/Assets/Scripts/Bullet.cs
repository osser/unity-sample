using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{


		// Click Left Mouse 
		if (Input.GetMouseButtonDown (0)) {
			// 目標
			Vector3 targetPos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10));
			// 方向
			Vector3 targetDir = targetPos - Camera.main.transform.position;

			this.gameObject.GetComponent<Rigidbody> ().AddForce (targetDir * 10, ForceMode.Impulse);
		}
	}
}
