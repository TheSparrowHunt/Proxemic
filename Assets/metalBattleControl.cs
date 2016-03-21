using UnityEngine;
using System.Collections;

public class metalBattleControl : MonoBehaviour {

	private float timer;

	private Vector3 otherPosition = new Vector3 (1.0f, 4.5f, -3.0f);
	private Vector3 playerPosition = new Vector3 (-6.0f, 4.5f, -3.0f);



	private GameObject text0;
	private bool madeText0 = false;

	private GameObject text1;
	private bool madeText1 = false;

	private GameObject text2;
	private bool madeText2 = false;

	private GameObject game;
	private bool madeGame = false;



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

	public bool status = true;






	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer >= 0.5f) {
			if (!madeText0) {

				text0 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText0"), otherPosition, Quaternion.identity) as GameObject;

				madeText0 = true;
			}
		}

		if (timer >= 1.5f) {
			if (!madeText1) {
				Destroy (text0);
				text1 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText1"), otherPosition, Quaternion.identity) as GameObject;

				madeText1 = true;
			}
		}

		if (timer >= 3.0f) {
			if (!madeText2) {
				
				text1 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText2"), playerPosition, Quaternion.identity) as GameObject;

				madeText2 = true;
			}
		}

		if (timer >= 4.0f) {
			if (!madeGame) {

				game = Instantiate (Resources.Load ("Prefab/Dodgems/DodgeInstantiator"), playerPosition, Quaternion.identity) as GameObject;

				madeGame = true;
			}
		}


		//increments timer based on real time
		timer += Time.deltaTime;
	}
}
