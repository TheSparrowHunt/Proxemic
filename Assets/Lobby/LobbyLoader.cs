using UnityEngine;
using System.Collections;

public class LobbyLoader : MonoBehaviour {
	public GameObject player = null;
	public Vector3 playerPositionFromUniversityFront = new Vector3 (0.0f, -4.0f, -1.0f);
	public Vector3 playerPositionFromIDCard = new Vector3 (-8.0f, 0.0f, -1.0f);
	public Vector3 playerPositionFromSocietyShowcase = new Vector3 (8.0f, 0.0f, -1.0f);
	public Vector3 playerPositionFromLab = new Vector3 (0.0f, 3.0f, -1.0f);

	// Use this for initialization
	void Start () {


		//placing the player at the correct position relative to the previous room.
		if (PlayerPrefs.GetString ("PreviousRoom") == "UniversityFront") {
			//instantiates the player
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromUniversityFront, Quaternion.identity) as GameObject;
		} else if (PlayerPrefs.GetString("PreviousRoom") == "IDCard"){
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromIDCard, Quaternion.identity) as GameObject;
		} else if (PlayerPrefs.GetString("PreviousRoom") == "SocietyShowcase"){
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromSocietyShowcase, Quaternion.identity) as GameObject;
		} else if (PlayerPrefs.GetString("PreviousRoom") == "Lab"){
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromLab, Quaternion.identity) as GameObject;
		}



		//sets the string ready for when player goes into next scene
		PlayerPrefs.SetString ("PreviousRoom", "Lobby");
	
	}
	

}
