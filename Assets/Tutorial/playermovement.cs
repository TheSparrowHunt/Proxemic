using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {
	Vector2 direction;
	float xvel;
	float yvel;
	public float speed;

	// Use this for initialization
	void Start () {
		speed = 150.0f;
	}
	
	// Update is called once per frame
	void Update () {
		//reseting values 
		xvel = 0.0f;
		yvel = 0.0f;

		//input checker
		if (Input.GetButton ("up")){
			yvel += speed;
		}
		if(Input.GetButton("down")){
			yvel -= speed;
		}
		if(Input.GetButton("left")){
			xvel -= speed;
		}
		if(Input.GetButton("right")){
			xvel += speed;
		}


		//pythagoras implementation so you travel at the same speed regardless of direction.
		if (xvel != 0.0f && yvel != 0.0f) {
			if (xvel > 0) {
				if (yvel > 0) {
					xvel = Mathf.Sqrt((xvel*xvel) + (yvel*yvel))/2;
					yvel = xvel;
				} else if (yvel < 0) {
					xvel = Mathf.Sqrt((xvel*xvel) + (-yvel*-yvel))/2;
					yvel = -xvel;
				}
			} else if (xvel < 0) {
				if (yvel > 0) {
					xvel = -(Mathf.Sqrt((-xvel*-xvel) + (yvel*yvel))/2);
					yvel = -xvel;
				} else if (yvel < 0) {
					xvel = -(Mathf.Sqrt((-xvel*-xvel) + (-yvel*-yvel))/2);;
					yvel = xvel;
				}
			}
		}

		direction = new Vector2 (xvel  * Time.deltaTime, yvel  * Time.deltaTime);
		GetComponent<Rigidbody2D> ().velocity = direction;
		//DEBUG
		print (xvel);



	}
}
