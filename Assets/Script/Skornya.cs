using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skornya : MonoBehaviour {

	public float detik = 0, detik2 = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		detik = detik + 1;
		if(detik >= 10){
			detik2 = detik2 + 1;
			gameObject.GetComponent<Text>().text = "Score :" +detik2.ToString();
			detik = 0;
		}
	}
}
