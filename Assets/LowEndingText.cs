using UnityEngine;
using System.Collections;

public class LowEndingText : MonoBehaviour {
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


	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}


	// Update is called once per frame
	void Update () {

		if (timer >= 1.0f) {
			if (!madeText0) {

				text0 = Instantiate (Resources.Load ("Prefab/endings/Lowending/Text/LowendText0")) as GameObject;
				madeText0 = true;
			}
		}
		if (timer >= 3.0f) {
			if (!madeText1){
				text1 = Instantiate (Resources.Load ("Prefab/endings/Lowending/Text/LowendText1")) as GameObject;				 

				madeText1 = true;
			}
		}
		if (timer >= 3.5f) {
			if (!madeText2){
				text2 = Instantiate (Resources.Load ("Prefab/endings/Lowending/Text/LowendText2")) as GameObject;				 

				madeText2 = true;
			}
		}
		if (timer >= 5.5f) {
			if (!madeText3){
				text3 = Instantiate (Resources.Load ("Prefab/endings/Lowending/Text/LowendText3")) as GameObject;				 

				madeText3 = true;
			}
		}
		if (timer >= 6.5f) {
			if (!madeText4){
				text4 = Instantiate (Resources.Load ("Prefab/endings/Lowending/Text/LowendText4")) as GameObject;				 

				madeText4 = true;
			}
		}
		if (timer >= 8.5f) {
			if (!madeText5){
				text5 = Instantiate (Resources.Load ("Prefab/endings/Lowending/Text/LowendText5")) as GameObject;				 

				madeText5 = true;
			}
		}

		timer += Time.deltaTime;
	}


}
