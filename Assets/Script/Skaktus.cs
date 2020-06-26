using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skaktus : MonoBehaviour {
	public float Geraknya;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * Geraknya * Time.deltaTime;
	}
}
