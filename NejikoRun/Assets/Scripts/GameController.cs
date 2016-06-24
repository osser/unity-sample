using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

	public NejikoController nejiko;
	public Text scoreLabel;
	public LifePanel lifePanel;

	// Update is called once per frame
	void Update ()
	{
		int score = CalScore ();
		scoreLabel.text = "Score: " + score + " m";

		lifePanel.UpdateLife (nejiko.Life ());

		if (nejiko.Life () <= 0) {
			enabled = false;

			if (PlayerPrefs.GetInt ("HighScore") < score) {
				PlayerPrefs.SetInt ("HighScore", score);
			}

			Invoke ("ReturnToTitle", 2);
		}
	}

	int CalScore ()
	{
		return (int)nejiko.transform.position.z;
	}

	void ReturnToTitle ()
	{
		//Application.LoadLevel ("Title");
		SceneManager.LoadScene("Title");
	}
}
