using UnityEngine;
using System.Collections;

public class arrowright : MonoBehaviour {
	
	public float scalar;
	public float scalarchange;
	Vector3 menu0;
	Vector3 menu1;
	Vector3 menu2;
	GameObject menucontrol;


	// Use this for initialization
	void Start () {


		transform.position = new Vector3 (menu0.x - 2, menu0.y, 0);
		scalar = -1.0f;
		scalarchange = -1.0f;
	}

	// Update is called once per frame
	void Update () {
		//the changing of the size
		if (transform.localScale.y <= -0.2f || transform.localScale.y >= 0.2f) {
			scalarchange = -scalarchange;
		}
		scalar = scalarchange * Time.deltaTime;
		transform.localScale += new Vector3 (0, scalar, 0);

		//DEBUG
		//print(menuscript.menuposition);

		//checking the menu position
		switch (menuscript.menuposition) {
		case 0:
			menu0 = GameObject.Find ("menustart").transform.position;
			transform.position = new Vector3 (1.75f, menu0.y, 0);
			break;
		case 1:
			menu1 = GameObject.Find ("menuoptions").transform.position;
			transform.position = new Vector3 (2.25f, menu1.y, 0);
			break;
		case 2:
			menu2 = GameObject.Find ("menuexit").transform.position;
			transform.position = new Vector3 (1.5f, menu2.y, 0);
			break;
		default:
			//do nothing
			break;
		}

	}
}
