using UnityEngine;
using System.Collections;

public class makeBattleID : MonoBehaviour {

	GameObject backg = null;
	GameObject otherConverser = null;
	GameObject protConverser = null;
	GameObject controller = null; 

	// Use this for initialization
	void Start () {
		GameObject StateController = GameObject.Find ("StateController");
		StateController.GetComponent<StateController>().gameState = "Battle";
		backg = Instantiate (Resources.Load ("Prefab/BattleBackg"), new Vector3(0.0f,0.0f,-1.0f), Quaternion.identity) as GameObject;
		otherConverser = Instantiate (Resources.Load ("Prefab/IDCard/IDPersonanim_0 1"), new Vector3(7.0f,0.0f,-2.0f), Quaternion.identity) as GameObject;
		protConverser = Instantiate (Resources.Load ("Prefab/protdrawn_0"), new Vector3(-7.0f,0.0f,-2.0f), Quaternion.identity) as GameObject;
		//battle controller below
		controller = Instantiate (Resources.Load ("Prefab/IDCard/IDBattleControl"), new Vector3 (-7.0f, 0.0f, -2.0f), Quaternion.identity) as GameObject;

		Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {

	}
}
