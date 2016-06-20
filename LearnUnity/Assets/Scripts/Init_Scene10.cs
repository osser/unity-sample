using UnityEngine;
using System.Collections;
using System;

public class Init_Scene10 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		DateTime objDateTime = new DateTime (DateTime.Now.Ticks);

		Debug.Log (objDateTime.ToString ("F"));
		Debug.Log (objDateTime.ToString ("gyyyy年MM月dd日(dddd)"));
		Debug.Log (objDateTime.ToString ("tthh時mm分ss秒fffミリ秒"));

		Example ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void FixedUpdate ()
	{
//		Debug.Log (DateTime.Now.ToString ("tthh時mm分ss秒fffミリ秒"));
	}

	void ApplyDamage (float damage)
	{
		print (damage);
	}

	void Example ()
	{
		BroadcastMessage ("ApplyDamage", 5.0F);
	}
}
