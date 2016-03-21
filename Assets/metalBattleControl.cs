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

	private GameObject text8;
	private bool madeText8 = false;

	private GameObject text9;
	private bool madeText9 = false;

	private GameObject text10;
	private bool madeText10 = false;

	public bool status = true;


	private GameObject[] battleList;



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
				
				text2 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText2"), playerPosition, Quaternion.identity) as GameObject;

				madeText2 = true;
			}
		}

		if (timer >= 4.0f) {
			if (!madeGame) {

				game = Instantiate (Resources.Load ("Prefab/Dodgems/DodgeInstantiator"), playerPosition, Quaternion.identity) as GameObject;

				madeGame = true;
			}
		}

		if (timer >= 9.0f) {
			if (!madeText3) {
				Destroy (text1);
				text3 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText3"), otherPosition, Quaternion.identity) as GameObject;

				madeText3 = true;
			}
		}

		if (timer >= 11.0f) {
			if (!madeText4) {
				Destroy (text3);
				text4 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText4"), otherPosition, Quaternion.identity) as GameObject;

				madeText4 = true;
			}
		}

		if (timer >= 13.0f) {
			if (!madeText5) {
				Destroy (text2);
				text5 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText5"), playerPosition, Quaternion.identity) as GameObject;

				madeText5 = true;
			}
		}

		if (timer >= 14.0f) {
			if (!madeText6) {
				Destroy (text4);
				text6 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalText6"), otherPosition, Quaternion.identity) as GameObject;

				madeText6 = true;
			}
		}

		if (timer >= 16.0f) {
			if (!madeText7) {
				Destroy (text5);
				if (status) {
					//winning text
					text7 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalTextWin0"), playerPosition, Quaternion.identity) as GameObject;
				} else {
					//losing text
					text7 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalTextLose0 1"), playerPosition, Quaternion.identity) as GameObject;
				}

				madeText7 = true;
			}
		}

		if (status) {
			if (timer >= 17.0f) {
				if (!madeText8) {
					Destroy (text7);
					text8 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalTextWin1"), playerPosition, Quaternion.identity) as GameObject;
					madeText8 = true;
				}
			}

			if (timer >= 21.0f) {
				clear ();
			}
		} else {
			if (timer >= 17.0f) {
				if (!madeText8) {
					Destroy (text6);
					text8 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalTextLose1"), otherPosition, Quaternion.identity) as GameObject;
					madeText8 = true;
				}
			}

			if (timer >= 18.0f) {
				if (!madeText9) {
					Destroy (text8);
					text8 = Instantiate (Resources.Load ("Prefab/metal/metalText/metalTextLose2"), otherPosition, Quaternion.identity) as GameObject;
					madeText9 = true;
				}
			}

			if (timer >= 22.0f) {
				clear ();
			}
		}


		//increments timer based on real time
		timer += Time.deltaTime;
	}

	void clear(){
		battleList = GameObject.FindGameObjectsWithTag ("HoboConvo");
		for (int i = 0; i < battleList.Length; i++) {
			//DEBUG
			//print (i);
			if (battleList [i] != null) {
				Destroy (battleList [i]);
			}
		}
		GameObject StateController = GameObject.Find ("StateController");
		StateController.GetComponent<StateController>().gameState = "OverWorld";
		//setting the successfulcounter
		if (status) {
			int successfulCounter = PlayerPrefs.GetInt ("SuccessfulCounter") + 1;
			PlayerPrefs.SetInt("SuccessfulCounter", successfulCounter);
			print(PlayerPrefs.GetInt ("SuccessfulCounter"));
		} else {

		}

		Destroy (gameObject);


	}
}
