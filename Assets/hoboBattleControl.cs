using UnityEngine;
using System.Collections;

public class hoboBattleControl : MonoBehaviour {
	private int counter;
	private GameObject hobotext0;
	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (counter == 30) {
			hobotext0 = Instantiate (Resources.Load ("Prefab/hoboText/hobotext0"), new Vector3 (1.0f, 4.5f, -3.0f), Quaternion.identity) as GameObject;
		}






		counter++;
	}
}
