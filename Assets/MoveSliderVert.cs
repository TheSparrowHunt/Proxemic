using UnityEngine;
using System.Collections;

public class MoveSliderVert : MonoBehaviour {


	public float speed = 5;
	public string axis = "Vertical";
	public Vector3 sliderPos = new Vector3(-8.0f, 0.0f, -3.0f);
	public bool lose;


	private GameObject controller;


	// Use this for initialization
	void Start () {
		lose = false;
	}

	// Update is called once per frame
	void FixedUpdate () {
		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * speed);
		sliderPos = new Vector3 (-8.0f, Mathf.Clamp (yPos, -3.5f, 3.5f), -3.0f);
		gameObject.transform.position = sliderPos;
	}

	void OnTriggerEnter2D (Collider2D other) {


		controller = GameObject.Find ("metalBattleControl(Clone)");
		if (controller != null) {
			controller.GetComponent<metalBattleControl>().status = false;
		}
		lose = true;


//		print (lose);
	}
}
