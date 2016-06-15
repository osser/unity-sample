using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

	public Text txtScore;
	public GameObject txtResult;

	private int score = 0;

	private Rigidbody ballRigidbody;

	private Vector3 initPosition;

	// Use this for initialization
	void Start ()
	{
		ballRigidbody = this.gameObject.GetComponent<Rigidbody> ();
		initPosition = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		ballRigidbody.AddForce (new Vector3 (moveH, 0, moveV), ForceMode.Impulse);
	}

	void OnBecameInvisible ()
	{
		this.gameObject.transform.position = initPosition;
	}

	void OnCollisionEnter (Collision collision)
	{
//		Debug.Log ("Ball.OnCollisionEnter:" + collision.gameObject.name);
//		if (collision.collider.tag == "Food") {
//			Destroy (collision.gameObject);
//		}
	}

	void OnCollisionStay (Collision collisionInfo)
	{
	}

	void OnCollisionExit (Collision collisionInfo)
	{
	}

	void OnTriggerEnter (Collider other)
	{
		//Debug.Log ("Ball.OnTriggerEnter:" + other.gameObject.name + ", tag:" + other.gameObject.tag);
		if (other.gameObject.tag.CompareTo ("Food") == 0) {
			score++;
			txtScore.text = score.ToString ();
			Destroy (other.gameObject);
		}

		if (score == 8) {
			txtResult.SetActive (true);
		}
		//Destroy(other.gameObject);
	}

	void OnTriggerStay (Collider other)
	{
	}

	void OnTriggerExit (Collider other)
	{
		//Destroy(other.gameObject);
	}
}
