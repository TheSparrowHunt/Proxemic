using UnityEngine;
using System.Collections;

public class whichEnd : MonoBehaviour {

	public int WhatEnding = PlayerPrefs.SuccessfulCounter;

	void Start () {

		if (WhatEnding == 0) {

			SceneManager.LoadScene ("Ending_0");

		}

		if (WhatEnding == 1) {
			
			SceneManager.LoadScene ("Ending_1");
		}

		if (WhatEnding == 2) {

			SceneManager.LoadScene ("Ending_1");

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
