using UnityEngine;
using System.Collections;

public class DodgeInstantiator : MonoBehaviour {
	private GameObject Dodgems;


	// Use this for initialization
	void Start () {
		Dodgems = Instantiate (Resources.Load ("Prefab/Dodgems/Dodgems"), new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
	}

	// Update is called once per frame
	void Update () {
		Destroy (gameObject);
	}
}
