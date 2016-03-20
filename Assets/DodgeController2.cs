using UnityEngine;
using System.Collections;

public class DodgeController2 : MonoBehaviour {

	public GameObject[] ThingsR;
	public GameObject[] ThingsL;
	public float timeLeft;

	public float maxHeight;

	// Use this for initialization
	void Start () {

		maxHeight = 5.0f;
		StartCoroutine (Spawn ());
		StartCoroutine (Spawn2());
	}

	void FixedUpdate () {
		timeLeft -= Time.deltaTime;

	}

	IEnumerator Spawn() {
		yield return new WaitForSeconds (2.0f);

		while(timeLeft > 0.0f) {
			GameObject ThingR = ThingsR [Random.Range (0, ThingsR.Length)];

			Instantiate (ThingR, (new Vector3 (
				10,
				Random.Range (-maxHeight, maxHeight),
				0
			)), Quaternion.identity);

			yield return new WaitForSeconds (Random.Range (1.5f, 2.0f));
		}
	}

	IEnumerator Spawn2() {
		yield return new WaitForSeconds (2.0f);

		while(timeLeft > 0.0f) {
			GameObject ThingL = ThingsL [Random.Range (0, ThingsL.Length)];

			Instantiate (ThingL, (new Vector3 (
				-10.0f,
				Random.Range (-maxHeight, maxHeight),
				0
			)), Quaternion.identity);

			yield return new WaitForSeconds (Random.Range (1.5f, 2.0f));
		}
	}
}