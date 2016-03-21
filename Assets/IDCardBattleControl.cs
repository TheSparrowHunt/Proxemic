using UnityEngine;
using System.Collections;

public class IDCardBattleControl : MonoBehaviour {

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

				text0 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDText0"), otherPosition, Quaternion.identity) as GameObject;

				madeText0 = true;
			}
		}

		if (timer >= 1.5f) {
			if (!madeText1) {
				
				text1 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDText1"), playerPosition, Quaternion.identity) as GameObject;

				madeText1 = true;
			}
		}

		if (timer >= 3.0f) {
			if (!madeText2) {
				Destroy (text0);
				text2 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDText2"), otherPosition, Quaternion.identity) as GameObject;

				madeText2 = true;
			}
		}



		if (timer >= 5.0f) {
			if (!madeText3) {
				Destroy (text2);
				text3 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDText3"), otherPosition, Quaternion.identity) as GameObject;

				madeText3 = true;
			}
		}

		if (timer >= 5.0f) {
			if (!madeGame) {
				//Destroy (text2);
				game = Instantiate (Resources.Load ("Prefab/Catch/CatchInstantiator"), new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;

				madeGame = true;
			}
		}



		if (timer >= 21.0f) {
			if (!madeText4) {
				Destroy (text1);
				if (status) {
					//winning text
					text4 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextWin0"), playerPosition, Quaternion.identity) as GameObject;
				} else {
					//losing text
					text4 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextLose0"), playerPosition, Quaternion.identity) as GameObject;
				}

				madeText4 = true;
			}
		}

		if (status) {
			if (timer >= 24.0f) {
				if (!madeText5) {
					Destroy (text3);
					text5 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextWin1"), otherPosition, Quaternion.identity) as GameObject;
					madeText5 = true;
				}
			}

			if (timer >= 30.0f) {
				clear ();
			}
		} else {
			if (timer >= 24.0f) {
				if (!madeText5) {
					Destroy (text4);
					text5 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextLose1"), playerPosition, Quaternion.identity) as GameObject;
					madeText5 = true;
				}
			}

			if (timer >= 26.0f) {
				if (!madeText6) {
					Destroy (text3);
					text6 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextLose2"), otherPosition, Quaternion.identity) as GameObject;
					madeText6 = true;
				}
			}

			if (timer >= 28.0f) {
				if (!madeText7) {
					Destroy (text5);
					text7 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextLose3"), playerPosition, Quaternion.identity) as GameObject;
					madeText7 = true;
				}
			}

			if (timer >= 30.0f) {
				if (!madeText8) {
					Destroy (text6);
					text8 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextLose4"), otherPosition, Quaternion.identity) as GameObject;
					madeText8 = true;
				}
			}

			if (timer >= 32.0f) {
				if (!madeText9) {
					Destroy (text8);
					text9 = Instantiate (Resources.Load ("Prefab/IDCard/IDCardText/IDTextLose5"), otherPosition, Quaternion.identity) as GameObject;
					madeText9 = true;
				}
			}

			if (timer >= 36.0f) {
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
			//DEBUG
			print(PlayerPrefs.GetInt ("SuccessfulCounter"));
		} else {

		}

		Destroy (gameObject);


	}
}
