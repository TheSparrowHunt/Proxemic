using UnityEngine;
using System.Collections;

public class hoboBattleControl : MonoBehaviour {
	private int counter;

	private GameObject hobotext0;
	private bool hobotext0generated;


	private float timer;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer >= 0.5f) {
			if (!hobotext0generated) {
				hobotext0 = Instantiate (Resources.Load ("Prefab/hoboText/hobotext0"), new Vector3 (1.0f, 4.5f, -3.0f), Quaternion.identity) as GameObject;
				hobotext0generated = true;
			}
		}






		counter++;
		timer += Time.deltaTime;
	}
}
