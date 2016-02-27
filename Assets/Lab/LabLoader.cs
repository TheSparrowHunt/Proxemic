using UnityEngine;
using System.Collections;

public class LabLoader : MonoBehaviour {

	public GameObject player = null;
	public Vector3 playerPositionFromLobby = new Vector3 (0.0f, 8.0f, -1.0f);

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetString ("PreviousRoom", "Lab");
		player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromLobby, Quaternion.identity) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
