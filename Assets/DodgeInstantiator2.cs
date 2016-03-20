using UnityEngine;
using System.Collections;

public class DodgeInstantiator2 : MonoBehaviour {
	private GameObject Dodgems2;


	// Use this for initialization
	void Start () {
		Dodgems2 = Instantiate (Resources.Load ("Prefab/Dodgems2/Dodgems2"), new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
	}

	// Update is called once per frame
	void Update () {
		Destroy (gameObject);
	}
}
