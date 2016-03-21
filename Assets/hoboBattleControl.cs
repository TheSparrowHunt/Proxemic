using UnityEngine;
using System.Collections;

public class hoboBattleControl : MonoBehaviour {
//	private int counter;

	private GameObject hobotext0;
	private bool hobotext0generated = false;

	private GameObject hobogame0;
	private bool hobogame0generated = false;

	private GameObject[] deleteList;
	private bool hoboGameDeleted = false;

	private GameObject statusChecker;
	//private bool statusChecked = false;

	//catch/dont catch the Sorry
	public bool status = true;

	private bool responseMade = false;
	private bool responseMade2 = false;

	private GameObject hobotext1;
	private bool hobotext1generated = false;

	//the whole battle scene
	private GameObject[] battleList;
	private bool destroyBattleList = false;

	private GameObject loseText1;




	private float timer;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
//		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//DEBUG
		//print (status);
		if (timer >= 0.5f) {
			if (!hobotext0generated) {
				hobotext0 = Instantiate (Resources.Load ("Prefab/hoboText/hobotext0"), new Vector3 (1.0f, 4.5f, -3.0f), Quaternion.identity) as GameObject;
				hobotext0generated = true;
			}
		}

		if (timer >= 1.5f) {
			if (!hobogame0generated) {
				hobogame0 = Instantiate (Resources.Load ("Prefab/hoboboxes/Hoboboxesinstantiater"), new Vector3 (1.0f, 4.5f, -3.0f), Quaternion.identity) as GameObject;
				hobogame0generated = true;
			}
		}

		/*
		if (timer >= 7.9f) {
			if (!statusChecked) {
				statusChecker = GameObject.Find ("loserbum(Clone)");
				if (statusChecker != null) {
					status = statusChecker.GetComponent<Bottomcollectorscript>.Lost;
				}

			}
		}*/


		if (timer >= 8.0f) {
			if (!hoboGameDeleted) {
				deleteList = GameObject.FindGameObjectsWithTag ("HoboGame");
				GameObject sorry = GameObject.FindGameObjectWithTag ("Sorry");

				for (int i = 0; i < deleteList.Length; i++) {
					if (deleteList [i] != null) {
						Destroy (deleteList [i]);
					}
				}
				Destroy (sorry);

				hoboGameDeleted = true;
			}

		}


		if (timer >= 8.5f) {
			//DEBUG
			//print (status);
			if (!responseMade) {
				if (status) {
					hobotext1 = Instantiate (Resources.Load ("Prefab/hoboText/hobotextwin"), new Vector3 (-6.0f, 4.5f, -3.0f), Quaternion.identity) as GameObject;
				} else {
					hobotext1 = Instantiate (Resources.Load ("Prefab/hoboText/hobotextlose0"), new Vector3 (-6.0f, 4.5f, -3.0f), Quaternion.identity) as GameObject;
				}


				responseMade = true;
			}
		}

		if (timer >= 9.5f) {
			//DEBUG
			//print (status);
			if (!responseMade2) {
				Destroy (hobotext0);


				if (status) {
					//nothing
				} else {
					loseText1 = Instantiate (Resources.Load ("Prefab/hoboText/hobotextlose1"), new Vector3 (1.0f, 4.5f, -3.0f), Quaternion.identity) as GameObject;
				}


				responseMade2 = true;
			}
		}


		if (timer >= 12.0f) {
			if (!destroyBattleList) {
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
				destroyBattleList = true;
			}
		}






//		counter++;
		timer += Time.deltaTime;
	}
}
