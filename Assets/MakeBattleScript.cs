using UnityEngine;
using System.Collections;

public class MakeBattleScript : MonoBehaviour {
	GameObject backg = null;

	// Use this for initialization
	void Start () {
		GameObject StateController = GameObject.Find ("StateController");
		StateController.GetComponent<StateController>().gameState = "Battle";
		backg = Instantiate (Resources.Load ("Prefab/BattleBackg"), new Vector3(0.0f,0.0f,-1.0f), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
