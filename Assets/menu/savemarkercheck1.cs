using UnityEngine;
using System.Collections;

public class savemarkercheck1 : MonoBehaviour {
	//the ending to test for
	public string ending = "Ending0";
	public int counter = 0;
	public bool haschecked = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (counter >= 1) {
			if (!haschecked) {
				Check ();
				haschecked = true;
			}
		} else {
			counter++;
		}

	}

	void Check(){
		if (PlayerPrefs.HasKey (ending)) {
			if (PlayerPrefs.GetInt (ending) == 1) {
				//sets the alpha
				GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
			} else {
				GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0.2f);
			}
		} else {
			GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0.0f);
		}
	}
}
	
