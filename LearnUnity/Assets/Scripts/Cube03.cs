using UnityEngine;
using System.Collections;

public class Cube03 : MonoBehaviour
{
	public enum CubeMoveEnum
	{
		X,
		Y,
		Z}
	;

	public CubeMoveEnum CubeMoveType = CubeMoveEnum.X;

	public Space CubeMoveSpace = Space.Self;

	Vector3 localX;
	Vector3 localY;
	Vector3 localZ;

	// Use this for initialization
	void Start ()
	{
		localX = Vector3.left;
		localY = Vector3.up;
		localZ = Vector3.forward;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void FixedUpdate ()
	{

		switch (CubeMoveType) {
		case CubeMoveEnum.X:
			moveLocalX ();
			break;
		case CubeMoveEnum.Y:
			moveLocalY ();
			break;
		case CubeMoveEnum.Z:
			moveLocalZ ();
			break;
		}


	}

	void moveLocalX ()
	{
		if (this.gameObject.transform.localPosition.x <= 2.0f) {
			localX = Vector3.right;
		}
		if (this.gameObject.transform.localPosition.x >= 4.0f) {
			localX = Vector3.left;
		}
		this.gameObject.transform.Translate (localX * Time.deltaTime, CubeMoveSpace);
	}

	void moveLocalY ()
	{
		if (this.gameObject.transform.localPosition.y <= 2.0f) {
			localY = Vector3.up;
		}
		if (this.gameObject.transform.localPosition.y >= 4.0f) {
			localY = Vector3.down;
		}
		Debug.Log (this.gameObject.transform.localPosition.y + ", " + localY + ", " + this.gameObject.transform.localPosition);
		this.gameObject.transform.Translate (localY * Time.deltaTime, CubeMoveSpace);
	}

	void moveLocalZ ()
	{
		if (this.gameObject.transform.localPosition.z <= -1.0f) {
			localZ = Vector3.forward;
		}
		if (this.gameObject.transform.localPosition.z >= 1.0f) {
			localZ = Vector3.back;
		}
		this.gameObject.transform.Translate (localZ * Time.deltaTime, CubeMoveSpace);
	}
}
