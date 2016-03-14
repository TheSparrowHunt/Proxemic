using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	public float timeLeft;
	public Text timerText;
	public Text nice;

	void Start(){
		UpdateText ();

	}

	
	// Update is called once per frame
	void FixedUpdate () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			timeLeft = 0;
	
		} 
		if (timeLeft == 0) {
			timerText.text = "";
			nice.text = "Nice!";
		}
		else {
			UpdateText ();
		}
	}

	void UpdateText() {
			timerText.text = "" + Mathf.RoundToInt (timeLeft);
		}
}
