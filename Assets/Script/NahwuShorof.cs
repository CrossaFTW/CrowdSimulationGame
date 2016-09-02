using UnityEngine;
using UnityEngine;
using System.Collections;



public class NahwuShorof : MonoBehaviour {
	public Canvas test;
	public float deathDistance = 0;
	public Transform thisObject;
	public Transform target;
	public bool a = true;
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
				Canvas.Instantiate(test);
				a = false;
			}
		}
	}
}
