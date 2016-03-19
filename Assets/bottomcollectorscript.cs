using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bottomcollectorscript : MonoBehaviour {
	public float timeLeft;
//	public Text timerText;
//	public Text nice;
//	public Text shit;
	public bool lost;

	private GameObject controller;

	//public gameScript losing;

	void Start () {
//		UpdateText ();
		lost = false;
	}

	//OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
	void OnTriggerEnter2D(Collider2D other)
	{
		//Check the provided Collider2D parameter other to see if it is tagged "Sorry", if it is...
		if (other.gameObject.CompareTag ("Sorry")) {
			//gameObject.SetActive (false);

			controller = GameObject.Find ("hoboBattleController(Clone)");
			if (controller != null) {
				controller.GetComponent<hoboBattleControl>().status = false;
			}

			lost = true;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		timeLeft -= Time.deltaTime;
		//loserbum = GetComponent<losing>();

		if (timeLeft < 0) {
			timeLeft = 0;
		}




//		if (lost == true && timeLeft > 0) {
//			shit.text = "Shit!";
//			timerText.text = "";
//			nice.text = "";

//		} else {
//			if (timeLeft == 0) {
//				timerText.text = "";
//				nice.text = "Nice!";
//				shit.text = "";
//			} else {
//				UpdateText ();
//			}
//		}
	}


//	void UpdateText () {
//		timerText.text = "" + Mathf.RoundToInt (timeLeft);
//	}
}

