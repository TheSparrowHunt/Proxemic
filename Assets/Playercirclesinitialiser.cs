using UnityEngine;
using System.Collections;

public class Playercirclesinitialiser : MonoBehaviour {
	GameObject commsCircle = null;
	GameObject personalCircle = null;

	// Use this for initialization
	void Start () {
		commsCircle = Instantiate (Resources.Load ("Prefab/CommsCircle"), gameObject.transform.position, Quaternion.identity) as GameObject;
		personalCircle = Instantiate (Resources.Load ("Prefab/PersonalCircle"), gameObject.transform.position, Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
