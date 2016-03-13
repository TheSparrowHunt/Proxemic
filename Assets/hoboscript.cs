using UnityEngine;
using System.Collections;

public class hoboscript : MonoBehaviour {
	public GameObject myNoInteract = null;
	GameObject StateController;

	// Use this for initialization
	void Start () {
		StateController = GameObject.Find ("StateController");
	}
	
	// Update is called once per frame
	void Update () {
		if (StateController.GetComponent<StateController> ().gameState == "Battle") {
			Destroy (gameObject);
		}


	}

	void OnDestroy(){
		PlayerPrefs.SetInt("HoboInteracted", 1);
		myNoInteract = Instantiate (Resources.Load ("Prefab/hobo 1"), transform.position, transform.rotation) as GameObject; 
	}
}
