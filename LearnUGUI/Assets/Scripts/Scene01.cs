using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Scene01 : MonoBehaviour {

	public Text txtTitle;
	public Button btnClose;	

	// Use this for initialization
	void Start () {
		txtTitle.text = "my test";
		btnClose.GetComponentInChildren<Text>().text = "閉じる";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void txtTitle_click(){
		Debug.Log("txtTitle_click");
	}
}
