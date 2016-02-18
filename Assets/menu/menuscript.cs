using UnityEngine;
using System.Collections;

public class menuscript : MonoBehaviour {
	public static int menuposition = 0;
	// Use this for initialization
	void Start () {
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
			if(menuscript.menuposition < 2){
				menuscript.menuposition += 1;
			}
		}
	}
}
