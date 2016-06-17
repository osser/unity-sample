using UnityEngine;
using System.Collections;

public class NejikoController : MonoBehaviour
{
	CharacterController controller;
	Animator animator;

	Vector3 moveDirection = Vector3.zero;

	public float gravity = 0;
	public float speedZ = 0;
	public float speedJump = 0;

	// Use this for initialization
	void Start ()
	{
		controller = this.GetComponent<CharacterController> ();
		animator = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (controller.isGrounded) {
			if (Input.GetAxis ("Vertical") > 0.0f) {
				moveDirection.z = Input.GetAxis ("Vertical") * speedZ;
			} else {
				moveDirection.z = 0;
			}

			this.transform.Rotate (0, Input.GetAxis ("Horizontal") * 3, 0);

			if (Input.GetButton ("Jump")) {
				moveDirection.y = speedJump;
				animator.SetTrigger ("jump");
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move(globalDirection * Time.deltaTime);

		if (controller.isGrounded) moveDirection.y = 0;

		animator.SetBool("run", moveDirection.z > 0.0f);
	}
}
