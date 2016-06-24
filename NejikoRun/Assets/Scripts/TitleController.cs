using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{

	public Text highScoreLabel;

	// Use this for initialization
	void Start ()
	{
		highScoreLabel.text = "High Score:" + PlayerPrefs.GetInt("HighScore") + "m";
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void OnStartButtonClicked ()
	{
		//Application.LoadLevel("Main");
		SceneManager.LoadScene ("Main");
	}
}
