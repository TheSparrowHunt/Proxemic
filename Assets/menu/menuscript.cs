using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour {
	public static int menuposition = 0;
	public static int menusize = 2;
	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;
		 menuposition = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("up")){
			if (menuscript.menuposition > 0){
				menuscript.menuposition -= 1;
			}
		}

		if (Input.GetButtonDown("down")){
			if(menuscript.menuposition < menusize){
				menuscript.menuposition += 1;
			}
		}

		if (Input.GetButtonDown ("space")) {
			switch (menuposition) {
			case 0:
				//Application.LoadLevel ("Tutorial");
				SceneManager.LoadScene ("Tutorial", LoadSceneMode.Single);
				break;
			case 2:
				Application.Quit ();
				break;
			default:
				//nothing
				break;
			}
		}
	}
}
