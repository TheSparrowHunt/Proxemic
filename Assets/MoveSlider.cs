using UnityEngine;
using System.Collections;

//[System.Serializable]
//public class Boundary
//{
//	public float xMin, xMax;
//}

public class MoveSlider : MonoBehaviour {

	public float speed = 10;
	public string axis = "Horizontal";
	public Vector3 sliderPos = new Vector3(0.0f, -4.8f, 0.0f);
	//public Boundary boundary;

	//Vector3 sliderPos;

	void FixedUpdate () 
	{
		//float moveHorizontal = Input.GetAxis("Horizontal");

		//float v = Input.GetAxisRaw("Horizontal");
		//GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0)  * speed;

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		//GetComponent<Rigidbody>().velocity = movement * speed;

//		GetComponent<Rigidbody2D>().position = new Vector3 
//			(
//				Mathf.Clamp (GetComponent<Rigidbody2D>().position.x, boundary.xMin, boundary.xMax), 
//				0.0f, 0.0f) 
//				//Mathf.Clamp (GetComponent<Rigidbody2D>().position.z, boundary.zMin, boundary.zMax)
//			;
//		float xPos = gameObject.transform.position.x + (Input.GetAxis("Horizontal") * speed);
//		sliderPos = new Vector3 (Mathf.Clamp (xPos, boundary.xMin, boundary.xMax), -4.8, 0.0);
//		gameObject.transform.position = sliderPos;

		float xPos = gameObject.transform.position.x + (Input.GetAxis("Horizontal") * speed);
		sliderPos = new Vector3 (Mathf.Clamp (xPos, -6.9f, 6.9f), -4.38f, 0.0f);
		gameObject.transform.position = sliderPos;
	}
}
