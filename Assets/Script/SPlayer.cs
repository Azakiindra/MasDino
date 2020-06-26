using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SPlayer : MonoBehaviour {

	public float velocity = 1;
	public bool Tanah;
	private Rigidbody2D rb;
	Animator anim;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Tanah == true){
			anim.SetBool("LariLoncat", false);
		}
		else if(Tanah == false){
			anim.SetBool("LariLoncat", true);
		}
		if(Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			if(Tanah == true){
				rb.velocity = Vector2.up * velocity;
			}
		}
	}
	public void OnCollisionStay2D(Collision2D other) {
		Tanah = true;
	}
	public void OnCollisionExit2D(Collision2D other) {
		Tanah = false;
	}
	public void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.name == "kaktus1(Clone)"|| other.gameObject.name == "kaktus2(Clone)"|| other.gameObject.name == "kaktus3(Clone)"){
		SceneManager.LoadScene(0);
		}
	}
}