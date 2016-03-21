using UnityEngine;
using System.Collections;

public class DodgeController : MonoBehaviour {

	public GameObject[] Things;
	public float timeLeft;

	public float maxHeight;

	// Use this for initialization
	void Start () {

		maxHeight = 5.0f;
		StartCoroutine (Spawn());
	}

	void FixedUpdate () {
		timeLeft -= Time.deltaTime;

	}

	IEnumerator Spawn() {
		yield return new WaitForSeconds (2.0f);

		while(timeLeft > 0.0f) {
			GameObject Thing = Things [Random.Range (0, Things.Length)];

			Instantiate (Thing, new Vector3 (
				9,
				Random.Range (-maxHeight, maxHeight),
				-3.5f
			), Quaternion.identity);

			yield return new WaitForSeconds (Random.Range (0.5f, 1.0f));
		}
	}
}