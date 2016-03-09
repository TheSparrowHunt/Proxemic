using UnityEngine;
using System.Collections;

public class MakeBattleScript : MonoBehaviour {
	GameObject backg = null;
	GameObject otherConverser = null;

	// Use this for initialization
	void Start () {
		GameObject StateController = GameObject.Find ("StateController");
		StateController.GetComponent<StateController>().gameState = "Battle";
		backg = Instantiate (Resources.Load ("Prefab/BattleBackg"), new Vector3(0.0f,0.0f,-1.0f), Quaternion.identity) as GameObject;
		otherConverser = Instantiate (Resources.Load ("Prefab/hobodrawn_0"), new Vector3(5.0f,0.0f,-2.0f), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
