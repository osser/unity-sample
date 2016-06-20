using UnityEngine;
using System.Collections;

public class Cube07 : MonoBehaviour
{
	public Camera mainCamera;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseEnter ()
	{
		this.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
	}

	void OnMouseOver ()
	{
		this.transform.Rotate (new Vector3 (0, 1, 0), Space.World);
	}

	void OnMouseExit ()
	{
		this.transform.localScale = new Vector3 (1f, 1f, 1f);
	}

	void OnMouseDrag ()
	{
		Ray ray = mainCamera.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit;

		if (Physics.Raycast (ray, out rayHit, 1000f, 0)) {
			if (rayHit.collider.name == "Cube07"){
				this.transform.position = new Vector3(
					rayHit.point.x,
					rayHit.point.y,
					rayHit.point.z
				);

				Debug.DrawLine(ray.origin, rayHit.point, Color.red);
			}
		}
	}
}
