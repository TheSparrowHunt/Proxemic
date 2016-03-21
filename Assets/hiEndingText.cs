using UnityEngine;
using System.Collections;


public class hiEndingText : MonoBehaviour {
	private float timer;

	private GameObject text0;
	private bool madeText0 = false;
	private GameObject text1;
	private bool madeText1 = false;
	private GameObject text2;
	private bool madeText2 = false;
	private GameObject text3;
	private bool madeText3 = false;
	private GameObject text4;
	private bool madeText4 = false;
	private GameObject text5;
	private bool madeText5 = false;
	private GameObject text6;
	private bool madeText6 = false;
	private GameObject text7;
	private bool madeText7 = false;


	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}


	// Update is called once per frame
	void Update () {

		if (timer >= 1.0f) {
			if (!madeText0) {

				text0 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText0")) as GameObject;
				madeText0 = true;
			}
		}
		if (timer >= 4.0f) {
			if (!madeText1){
				text1 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText1")) as GameObject;				 

				madeText1 = true;
			}
		}
		if (timer >= 7.5f) {
			if (!madeText2){
				text2 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText2")) as GameObject;				 

				madeText2 = true;
			}
		}
		if (timer >= 9.0f) {
			if (!madeText3){
				text3 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText3")) as GameObject;				 

				madeText3 = true;
			}
		}
		if (timer >= 11.0f) {
			if (!madeText4){
				text4 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText4")) as GameObject;				 

				madeText4 = true;
			}
		}
		if (timer >= 12.5f) {
			if (!madeText5){
				text5 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText5")) as GameObject;				 

				madeText5 = true;
			}
		}
		if (timer >= 15.0f) {
			if (!madeText6){
				text6 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText6")) as GameObject;				 

				madeText6 = true;
			}
		}
		if (timer >= 17.0f) {
			if (!madeText7){
				text7 = Instantiate (Resources.Load ("Prefab/endings/hiending/Text/hiendText7")) as GameObject;				 

				madeText7 = true;
			}
		}


		timer += Time.deltaTime;
	}


}
