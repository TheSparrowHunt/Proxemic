using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bootToMenu : MonoBehaviour {
	private float timer;

	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer >= 15.0f) {
			SceneManager.LoadScene ("Title");

		}
		timer += Time.deltaTime;
	}
}
