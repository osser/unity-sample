﻿using UnityEngine;
using System.Collections;

public class AzarashiController : MonoBehaviour
{

	Rigidbody2D rb2d;
	Animator animator;
	float angle;
	bool isDead;

	public float maxHeight;
	public float flapVelocity;
	public float relativeVelocityX;
	public GameObject sprite;

	public bool IsDead ()
	{
		return isDead;
	}

	void Awake ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		animator = sprite.GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1") && transform.position.y < maxHeight) {
			Flap ();
		}

		ApplyAngle ();

		animator.SetBool ("flap", angle >= 0.0f);
	}

	void Flap ()
	{
		if (isDead)
			return;

		rb2d.velocity = new Vector2 (0.0f, flapVelocity);
	}

	void ApplyAngle ()
	{
		float targetAngle = 0;

		if (isDead)
			targetAngle = -90.0f;
		else
			targetAngle = Mathf.Atan2 (rb2d.velocity.y, relativeVelocityX) * Mathf.Rad2Deg;

		angle = Mathf.Lerp (angle, targetAngle, Time.deltaTime * 10.0f);

		sprite.transform.localRotation = Quaternion.Euler (0.0f, 0.0f, angle);
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (isDead)
			return;

		isDead = true;
	}
}
