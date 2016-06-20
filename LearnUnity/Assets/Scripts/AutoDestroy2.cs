using UnityEngine;
using System.Collections;

public class AutoDestroy2 : MonoBehaviour {

	public float DestroySecond = 13;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, DestroySecond);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
