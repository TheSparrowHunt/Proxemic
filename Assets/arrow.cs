using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {
	public float scalar;
	public float scalarchange;

	// Use this for initialization
	void Start () {
		scalar = -1.0f;
		scalarchange = -1.0f;
	}

	// Update is called once per frame
	void Update () {
		if (transform.localScale.y <= -0.3f || transform.localScale.y >= 0.3f) {
			scalarchange = -scalarchange;
		}
		scalar = scalarchange * Time.deltaTime;
		transform.localScale += new Vector3 (0, scalar, 0);
	}
}
