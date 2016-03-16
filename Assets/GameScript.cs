using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameScript : MonoBehaviour {
	public float timeLeft;
	public Text timerText;
	public Text nice;
	public Text shit;
	public GameObject loserbum;
	//public gameScript losing;

	void Start () {
		UpdateText ();
		//GameObject loserbum = GameObject.Find("loserbum");
	}

	// Update is called once per frame
	void FixedUpdate () {

		timeLeft -= Time.deltaTime;
		//loserbum = GetComponent<losing>();

		losing losingScript = loserbum.GetComponent<losing>();
		if (losingScript.lost == true) {
			shit.text = "Shit!";
			timerText.text = ""; 
			nice.text = "";
		}

		else if (timeLeft < 0) {
			timeLeft = 0;
		}

		else {
			if (timeLeft == 0) {
				timerText.text = "";
				nice.text = "Nice!";
			} else {
				UpdateText ();
			}
		}
	}

	void UpdateText () {
		timerText.text = "" + Mathf.RoundToInt (timeLeft);
	}
}