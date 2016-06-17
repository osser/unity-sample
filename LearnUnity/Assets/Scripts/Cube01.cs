using UnityEngine;
using System.Collections;

public class Cube01 : MonoBehaviour
{

	private Vector3 initPosition;

	public enum CubeMoveEnum
	{
		None,
		Left,
		Right,
		Up,
		Down,
		Forward,
		Backward}
	;

	public CubeMoveEnum CubeMoveType = CubeMoveEnum.None;

	// Use this for initialization
	void Start ()
	{
		initPosition = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		func1 ();
	}

	void func1 ()
	{
//		var cubePosition = this.gameObject.transform.position;
		switch (CubeMoveType) {

		case CubeMoveEnum.Left:
			this.gameObject.transform.Translate (Vector3.left * Time.deltaTime, Space.World);
			break;

		case CubeMoveEnum.Right:
			this.gameObject.transform.Translate (Vector3.right * Time.deltaTime, Space.World);
			break;

		case CubeMoveEnum.Up:
			this.gameObject.transform.Translate (Vector3.up / 10, Space.World);
			break;
		case CubeMoveEnum.Down:
			this.gameObject.transform.Translate (Vector3.down * Time.deltaTime, Space.World);
			break;

		case CubeMoveEnum.Forward:
			this.gameObject.transform.Translate (Vector3.forward * Time.deltaTime, Space.World);
			break;
		case CubeMoveEnum.Backward:
			this.gameObject.transform.Translate (Vector3.back * Time.deltaTime, Space.World);
			break;

		case CubeMoveEnum.None:
		default:
			this.gameObject.transform.position = initPosition;
			break;
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		Debug.Log ("Cube01.OnCollisionEnter:" + collision.gameObject.name);
	}

}
