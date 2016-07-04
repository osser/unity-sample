using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class scrollbar01 : MonoBehaviour
{

	public Text txtTitle;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void scrollbar01_scroll (float value)
	{
		txtTitle.text = value.ToString ();
	}
}
