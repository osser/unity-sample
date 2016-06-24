using UnityEngine;
using System.Collections;

public class ScrollObject : MonoBehaviour
{
	
	public float speed = 1.0f;
	public float startPosition;
	public float endPosition;

	void Start ()
	{
	}

	void ScrollEnd ()
	{
		transform.Translate (-1 * (endPosition - startPosition), 0, 0);

		SendMessage ("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
	}

	void Update ()
	{
		transform.Translate (-1 * speed * Time.deltaTime, 0, 0);

		if (transform.position.x <= endPosition)
			ScrollEnd ();
	
	}
}
