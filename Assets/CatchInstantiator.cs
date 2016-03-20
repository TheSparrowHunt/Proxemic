using UnityEngine;
using System.Collections;

public class CatchInstantiator : MonoBehaviour {
	private GameObject Captcha;


	// Use this for initialization
	void Start () {
		Captcha = Instantiate (Resources.Load ("Prefab/Catch/Captcha"), new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject);
	}
}
