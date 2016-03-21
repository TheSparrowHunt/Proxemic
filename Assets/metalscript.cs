using UnityEngine;
using System.Collections;

public class metalscript : MonoBehaviour {

	public GameObject myNoInteract = null;
	GameObject StateController;

	// Use this for initialization
	void Start () {
		StateController = GameObject.Find ("StateController");

	}

	// Update is called once per frame
	void Update () {
		if (StateController.GetComponent<StateController> ().gameState == "Battle") {
			PlayerPrefs.SetInt ("MetalInteracted", 1);
			myNoInteract = Instantiate (Resources.Load ("Prefab/metal 1"), transform.position, transform.rotation) as GameObject;
			Destroy (gameObject);
		}


	}
}
