using UnityEngine;
using System.Collections;

public class CommunicationScript : MonoBehaviour {

	//Vector3 position;
	GameObject player;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.Find ("player(Clone)");


		transform.position = player.transform.position;

		/*
		if (GameObject.Find("player") != null)
		{
			player = GameObject.Find ("player");


			transform.position = player.transform.position;
			//transform.position = new Vector3 (player.GetComponent<Transform> ().position);
		}*/
	
	}
}
