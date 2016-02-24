using UnityEngine;
using System.Collections;

public class ptitlemove : MonoBehaviour {
	public float Yloc 			= 0.0f;
	public float counter		= 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Yloc =  0.5f * Mathf.Cos(counter * Mathf.Deg2Rad);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, Yloc);
		counter++;
	}
}
