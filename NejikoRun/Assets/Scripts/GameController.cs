using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public NejikoController nejiko;
	public Text scoreLabel;
	public LifePanel lifePanel;

	// Update is called once per frame
	void Update () {
		int score = CalScore();
		scoreLabel.text = "Score: " + score + " m";

		lifePanel.UpdateLife(nejiko.Life());
	}

	int CalScore(){
		return (int)nejiko.transform.position.z;
	}
}
