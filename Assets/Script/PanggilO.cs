using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanggilO : MonoBehaviour {

	public GameObject[] Ojek;
	public float maxtime = 1;
	private float time = 0;
	private int RandomObstacle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(time > maxtime){
			RandomObstacle = Random.Range(0, 3);
			if(RandomObstacle == 0){
				gameObject.transform.position = new Vector3(7.28f, -3.104f, 0);
			}
			else if(RandomObstacle == 1){
				gameObject.transform.position = new Vector3(7.28f, -3.21f, 0);
			}
			else if(RandomObstacle == 2){
				gameObject.transform.position = new Vector3(7.23f, -3.176f, 0);
			}
			GameObject Ojekbaru =Instantiate(Ojek[RandomObstacle]);
			Ojekbaru.transform.position = transform.position + new Vector3(0, 0, 0);
			Destroy(Ojekbaru, 5);
			maxtime = Random.Range(1f, 4f);
			time = 0;
		}
		time += Time.deltaTime;
	}
}
