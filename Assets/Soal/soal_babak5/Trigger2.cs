using UnityEngine;
using UnityEngine;
using System.Collections;



public class Trigger2 : MonoBehaviour {
	public Canvas test;
	public float deathDistance = 0;
	public Transform thisObject;
	public Transform target;
	public bool a = true;
	public AudioSource nahwu;
	
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(target.position, transform.position);
		
		if (dist <= deathDistance){
			//NGASIH PERTANYAAN
			if(a==true){
				Destroy(GameObject.FindGameObjectWithTag("Penghalang3"));
			}
		}
	}
}
