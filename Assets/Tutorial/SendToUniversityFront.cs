using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SendToUniversityFront : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		print ("colided");
		if (other.gameObject.tag == "Player") {
			print ("collider2D");
			SceneManager.LoadScene ("UniversityFront", LoadSceneMode.Single);
		}
	}
}
