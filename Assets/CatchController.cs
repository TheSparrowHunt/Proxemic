using UnityEngine;
using System.Collections;

public class CatchController : MonoBehaviour {

	public float speed = 0.5f;
	public string axis = "Horizontal";
	public Vector3 sliderPos = new Vector3(0.0f, -3.5f, 0.0f);

	void Start () {

	}
	

	void FixedUpdate () {


		float xPos = gameObject.transform.position.x + (Input.GetAxis("Horizontal") * speed);
		sliderPos = new Vector3 (Mathf.Clamp (xPos, -6.9f, 6.9f), -3.5f, -3.0f);
		gameObject.transform.position = sliderPos;
	}
}
