using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {
	//public GameObject;
	public float speed;
	//public Vector3 thingPos;



	// Use this for initialization
	void Start () {

		//thingPos = transform.position;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate(speed, 0, 0);
		//float xPos = gameObject.transform.position.x + speed;
		//thingPos = new Vector3 (xPos, thingPos.y, thingPos.z);
		//gameObject.transform.position = thingPos;
	}
}
