﻿//using UnityEngine;
//using System.Collections;
//
//public class NoEndingText : MonoBehaviour {
//	private float timer;
//
//	private GameObject text0;
//	private bool madeText0 = false;
//
//	private GameObject text1;
//	private bool madeText1 = false;
//
//	// Use this for initialization
//	void Start () {
//		timer = 0.0f;
//	}
//
//
//	// Update is called once per frame
//	void Update () {
//
//		if (timer >= 1.0f) {
//			if (!madeText0) {
//
//				text0 = Instantiate (Resources.Load ("Prefab/endings/noending/Text/noendText0")	)				 
//					//					,otherPosition, Quaternion.identity) 
//					as GameObject;
//
//				madeText0 = true;
//			}
//		}
//		if (timer >= 3.0f) {
//			if (!madeText1){
//				text1 = Instantiate (Resources.Load ("Prefab/endings/noending/Text/noendText1")	)				 
//					//					,otherPosition, Quaternion.identity) 
//					as GameObject;
//				madeText1 = true;
//			}
//		}
//		timer += Time.deltaTime;
//	}
//
//
//}