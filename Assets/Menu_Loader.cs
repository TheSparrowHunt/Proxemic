using UnityEngine;
using System.Collections;

public class Menu_Loader : MonoBehaviour {
	public int testvalue;

	// Use this for initialization
	void Start () {
		
		//values that will be calculated for ending
		PlayerPrefs.SetInt("InteractionCounter", 0);
		PlayerPrefs.SetInt("FailedCounter", 0);
		PlayerPrefs.SetInt("SuccessfulCounter", 0);
		PlayerPrefs.SetInt("FriendlyCounter", 0);
		PlayerPrefs.SetInt("HostileCounter", 0);
		PlayerPrefs.SetInt("NeutralCounter", 0);
		PlayerPrefs.SetInt("Mood", 0);


		//values that will be used for navigation and time changes
		PlayerPrefs.SetString("PreviousRoom", "");
		PlayerPrefs.SetInt("HoboInteracted", 0);
		PlayerPrefs.SetInt("MetalInteracted", 0);
		PlayerPrefs.SetInt ("IDInteracted", 0);



		if (!PlayerPrefs.HasKey("Ending0")){
			PlayerPrefs.SetInt("Ending0", 0);
		}
		if (!PlayerPrefs.HasKey("Ending1")){
			PlayerPrefs.SetInt("Ending1", 0);
		}
		if (!PlayerPrefs.HasKey("Ending2")){
			PlayerPrefs.SetInt("Ending2", 0);
		}
		if (!PlayerPrefs.HasKey("Ending3")){
			PlayerPrefs.SetInt("Ending3", 0);
		}
		if (!PlayerPrefs.HasKey("Ending4")){
			PlayerPrefs.SetInt("Ending4", 0);
		}
		if (!PlayerPrefs.HasKey("Ending5")){
			PlayerPrefs.SetInt("Ending5", 0);
		}
		if (!PlayerPrefs.HasKey("Ending6")){
			PlayerPrefs.SetInt("Ending6", 0);
		}
		if (!PlayerPrefs.HasKey("Ending7")){
			PlayerPrefs.SetInt("Ending7", 0);
		}
		if (!PlayerPrefs.HasKey("Ending8")){
			PlayerPrefs.SetInt("Ending8", 0);
		}

		//DEBUG
		//PlayerPrefs.SetInt("Ending0", 0);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
