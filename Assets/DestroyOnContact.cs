using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {
	public int counter;
	public bool lose;
	private GameObject controller;

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
			controller = GameObject.Find ("IDBattleControl(Clone)");
			if (controller != null) {
				controller.GetComponent<IDCardBattleControl>().status = false;
			}

			lose = true;
//			print (counter);
//			print (lose);
		}
	}
}

