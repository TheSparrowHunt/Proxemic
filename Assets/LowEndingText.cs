using UnityEngine;
using System.Collections;

public class LowEndingText : MonoBehaviour {
	private float timer;

	private GameObject text0;
	private GameObject text1;
	private GameObject text2;
	private GameObject text3;
	private GameObject text4;
	private GameObject text5;


	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}


	// Update is called once per frame
	void Update () {

		if (timer >= 1.0f) {


				text0 = Instantiate (Resources.Load ("Prefab/endings/noending/Text/noendText0")	)				 
					//					,otherPosition, Quaternion.identity) 
					as GameObject;


		}
		if (timer >= 3.0f) {

				text1 = Instantiate (Resources.Load ("Prefab/endings/noending/Text/noendText1")	)				 
					//					,otherPosition, Quaternion.identity) 
					as GameObject;

		}
		timer += Time.deltaTime;
	}


}
