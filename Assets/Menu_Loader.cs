using UnityEngine;
using System.Collections;

public class Menu_Loader : MonoBehaviour {
	public int testvalue;

	// Use this for initialization
	void Start () {
		testvalue = 0;
		PlayerPrefs.SetInt("InteractionCounter", 0);
		PlayerPrefs.SetInt("FailedCounter", 0);
		PlayerPrefs.SetInt("SuccessfulCounter", 0);
		PlayerPrefs.SetInt("FriendlyCounter", 0);
		PlayerPrefs.SetInt("HostileCounter", 0);
		PlayerPrefs.SetInt("NeutralCounter", 0);
		PlayerPrefs.SetInt("Mood", 0);

		if (PlayerPrefs.HasKey(
	}
	
	// Update is called once per frame
	void Update () {
	}
}
