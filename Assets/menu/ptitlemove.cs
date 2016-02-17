using UnityEngine;
using System.Collections;

public class ptitlemove : MonoBehaviour {
	public float Yloc 			= 0.0f;
	public float change 		= 0.1f;
	//public float changeofchange = 0.001f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Yloc > 2 || Yloc < -2) {
			change = -change;
		}

		//change += changeofchange;
		Yloc += change;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, Yloc);
	}
}
