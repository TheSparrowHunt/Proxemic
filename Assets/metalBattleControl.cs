using UnityEngine;
using System.Collections;

public class metalBattleControl : MonoBehaviour {

	private float timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		//increments timer based on real time
		timer += Time.deltaTime;
	}
}
