using UnityEngine;
using System.Collections;

public class losing : MonoBehaviour {
	public bool lost;


	// Use this for initialization
	void Start () {
		lost = false;
	}

	//OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
	void OnTriggerEnter2D(Collider2D other) 
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag("Sorry"))
		{
			lost = true;
//			gameObject.SetActive (false);
		}
	}
}
