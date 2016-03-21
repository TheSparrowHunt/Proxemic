using UnityEngine;
using System.Collections;

public class IDPscript : MonoBehaviour {
	GameObject myNoInteract;
	GameObject StateController;

	// Use this for initialization
	void Start () {
		StateController = GameObject.Find ("StateController");
	}
	
	// Update is called once per frame
	void Update () {
		if (StateController.GetComponent<StateController> ().gameState == "Battle") {
			PlayerPrefs.SetInt ("IDInteracted", 1);
			myNoInteract = Instantiate (Resources.Load ("Prefab/IDCard/IDPersonNo"), transform.position, transform.rotation) as GameObject;
			Destroy (gameObject);
		}
	}
}
