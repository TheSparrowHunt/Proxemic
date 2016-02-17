using UnityEngine;
using System.Collections;

public class startmenuitem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (menuscript.menuposition == 0) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 1.0f);
			print (menuscript.menuposition);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
		}
	
	}
}
