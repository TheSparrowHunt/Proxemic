using UnityEngine;
using System.Collections;

public class IDCardLoader : MonoBehaviour {
	public GameObject player = null;
	public Vector3 playerPositionFromLobby = new Vector3 (0.0f, -4.0f, -1.0f);

	private GameObject IDPerson;

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetString ("PreviousRoom", "IDCard");
		player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromLobby, Quaternion.identity) as GameObject;

		if (PlayerPrefs.GetInt ("IDInteracted") == 0) {
			IDPerson = Instantiate (Resources.Load ("Prefab/IDCard/IDPerson"), new Vector3 (0.0f, 1.72f, -0.5f), Quaternion.identity) as GameObject;
		} else {
			IDPerson = Instantiate (Resources.Load ("Prefab/IDCard/IDPersonNo"), new Vector3 (0.0f, 1.72f, -0.5f), Quaternion.identity) as GameObject;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
