using UnityEngine;
using System.Collections;

public class IDCardLoader : MonoBehaviour {
	public GameObject player = null;
	public Vector3 playerPositionFromLobby = new Vector3 (0.0f, -4.0f, -1.0f);

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetString ("PreviousRoom", "IDCard");
		player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromLobby, Quaternion.identity) as GameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
