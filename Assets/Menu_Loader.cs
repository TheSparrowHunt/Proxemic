using UnityEngine;
using System.Collections;

public class Menu_Loader : MonoBehaviour {
	public int testvalue;

	// Use this for initialization
	void Start () {
		testvalue = 0;
		PlayerPrefs.SetInt("InteractionCounter", 0);

	}
	
	// Update is called once per frame
	void Update () {
	}
}
