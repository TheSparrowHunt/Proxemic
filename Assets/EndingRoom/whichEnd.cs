using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class whichEnd : MonoBehaviour {

	public int WhatEnding;

	void Start () {
		//grabs the suceesfulcounter from PlayerPrefs file
		WhatEnding = PlayerPrefs.GetInt("SuccessfulCounter");

		if (WhatEnding == 0) {

			SceneManager.LoadScene ("Ending_0");

		}

		if (WhatEnding == 1) {
			
			SceneManager.LoadScene ("Ending_1");
		}

		if (WhatEnding == 2) {

			SceneManager.LoadScene ("Ending_2");

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
