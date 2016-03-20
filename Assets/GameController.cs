using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject[] stuffs;
	public float timeLeft;

	public float maxWidth;

	// Use this for initialization
	void Start () {

		maxWidth = 7.0f;
		StartCoroutine (Spawn());
	}

	void FixedUpdate () {
		timeLeft -= Time.deltaTime;
	}

	IEnumerator Spawn() {
		yield return new WaitForSeconds (2.0f);

		while(timeLeft > 0.0f) {
			GameObject stuff = stuffs [Random.Range (0, stuffs.Length)];

			Instantiate (stuff, (new Vector3 (
				Random.Range (-maxWidth, maxWidth),
				6,
				0
			)), Quaternion.identity);
			yield return new WaitForSeconds (Random.Range (1.0f, 2.0f));
		}
}
}