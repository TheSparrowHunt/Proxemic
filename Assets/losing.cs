using UnityEngine;
using System.Collections;

public class losing : MonoBehaviour {

	public bool lost;

	void Start () {
		lost = false;
	}

	//OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
	void OnTriggerEnter2D(Collider2D other)
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag ("Sorry")) {
			//gameObject.SetActive (false);
			lost = true;
		}
	}
}
