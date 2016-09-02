using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Chase4 : MonoBehaviour {
	public float deathDistance = 0.5f;
	public float distanceAway;
	public Transform thisObject;
	public GameObject musuh;
	public Transform target;
	private NavMeshAgent navComponent;
	
	public Canvas soal1;
	public Canvas soal2;
	public Canvas soal3;
	public Canvas soal4;
	public Canvas soal5;
	public Canvas soal6;
	public Canvas soal7;
	public Canvas soal8;
	public Canvas soal9;
	public Canvas soal10;
	public bool a = true;
	
	void Start(){
		target = GameObject.FindGameObjectWithTag("Player").transform;
		navComponent = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	void Update(){		
		var distanceAway = 20f;
		
		float dist = Vector3.Distance(target.position, transform.position);	
		if (dist < distanceAway) {
			navComponent.SetDestination (target.position);
		} else {
			this.thisObject = null;
		}
		if (dist <= deathDistance) {
			//NGASIH PERTANYAAN
			if (a == true) {
				int random = Random.Range(1,11);
				if (random == 1) {
					Canvas.Instantiate (soal1);
				} else if (random == 2) {
					Canvas.Instantiate (soal2);
				} else if (random == 3) {
					Canvas.Instantiate (soal3);
				} else if (random == 4) {
					Canvas.Instantiate (soal4);
				} else if (random == 5) {
					Canvas.Instantiate (soal5);
				} else if (random == 6) {
					Canvas.Instantiate (soal6);
				} else if (random == 7) {
					Canvas.Instantiate (soal7);
				} else if (random == 8) {
					Canvas.Instantiate (soal8);
				} else if (random == 9) {
					Canvas.Instantiate (soal9);
				} else if (random == 10) {
					Canvas.Instantiate (soal10);
				}
			
			a = false;
				Time.timeScale = 0;
				Destroy(musuh);
			}
			
			
		}
	}
	
}


