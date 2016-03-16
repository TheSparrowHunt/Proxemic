using UnityEngine;
using System.Collections;

public class hoboboxesloader : MonoBehaviour {
	private GameObject square;
	private GameObject square1;
	private GameObject square2;
	private GameObject square3;
	private GameObject square4;
	private GameObject topwall;
	private GameObject loserbum;
	private GameObject Balance2;
	private GameObject sorry;
	private GameObject gamecontroller;
	// Use this for initialization
	void Start () {
		square = Instantiate (Resources.Load ("Prefab/hoboboxes/square"), new Vector3 (0.42f, -3.53f, -3.0f), Quaternion.identity) as GameObject;
//		square.transform.localScale = Vector3 (0.8532495, 0.3780288,);
		square1 = Instantiate (Resources.Load ("Prefab/hoboboxes/square (1)"), new Vector3 (1.2f, -2.86f, -3.0f), Quaternion.identity) as GameObject;
		square2 = Instantiate (Resources.Load ("Prefab/hoboboxes/square (2)"), new Vector3 (0.04f, -2.17f, -3.0f), Quaternion.identity) as GameObject;
		square3 = Instantiate (Resources.Load ("Prefab/hoboboxes/square (3)"), new Vector3 (-0.73f, -1.32f, -3.0f), Quaternion.identity) as GameObject;
		square4 = Instantiate (Resources.Load ("Prefab/hoboboxes/square (4)"), new Vector3 (0.15f, -0.21f, -3.0f), Quaternion.identity) as GameObject;
		topwall = Instantiate (Resources.Load ("Prefab/hoboboxes/topwall"), new Vector3 (0.0f, 5.0f, -3.0f), Quaternion.identity) as GameObject;
		loserbum = Instantiate (Resources.Load ("Prefab/hoboboxes/loserbum"), new Vector3 (0.0f, -5.9f, -3.0f), Quaternion.identity) as GameObject;
		Balance2 = Instantiate (Resources.Load ("Prefab/hoboboxes/Balance2"), new Vector3 (0.79f, -4.38f, -3.0f), Quaternion.identity) as GameObject;
		sorry = Instantiate (Resources.Load ("Prefab/hoboboxes/sorry"), new Vector3 (-0.11f, 1.0f, -3.0f), Quaternion.identity) as GameObject;
	}

	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject);
	}
}
