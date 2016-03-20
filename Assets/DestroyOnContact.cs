using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {
	public int counter;
	public bool lose;

	void Start() {
		counter = 0;
		bool lose = false;
	}

	void OnTriggerEnter2D (Collider2D other) {
		counter++;
		Destroy (other.gameObject);
	}


	void Update() {
		if (counter >= 4) {
			lose = true;
//			print (counter);
//			print (lose);
		}
	}
}

