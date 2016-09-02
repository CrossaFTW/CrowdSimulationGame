using UnityEngine;
using System.Collections;

public class ChaseKey : MonoBehaviour {
	public float deathDistance = 0.5f;
	public float distanceAway;
	public Transform thisObject;
	public Transform Mimic;
	public GameObject musuh;
	public Transform target;
	private NavMeshAgent navComponent;
	
	public float minTarX = -10;
	public float maxTarX = 10;
	public float minTarZ = -10;
	public float maxTarZ = 10;
	public float tarX;
	public float tarZ;
	
	public float dampX;
	public float dampZ;
	public float timeSwitch = 100;
	
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
	
	void CreateTarPoint(){
		
		tarX = Random.Range (minTarX, maxTarX);
		tarZ = Random.Range (minTarZ, maxTarZ);
	}
	
	void Start(){
		CreateTarPoint ();
		
		target = GameObject.FindGameObjectWithTag("Player").transform;
		navComponent = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	void OnTriggerExit (Collider col){
		if (col.gameObject.tag == "Player") {
			target = null;
		}
	}
	
	
	void Update(){		
		var distanceAway = 20f;
		
		float dist = Vector3.Distance(target.position, transform.position);	
		if (dist < distanceAway) {
			navComponent.SetDestination (Mimic.position);
			//navComponent.SetDestination (transform.position + target.position);
			//navComponent.SetDestination (target.position);
		} else {
			if(timeSwitch <= 0){
				timeSwitch = 100;
				CreateTarPoint();
			}else{
				float positionX;
				float positionZ;
				positionX = GameObject.FindGameObjectWithTag("Test").transform.position.x;
				positionZ = GameObject.FindGameObjectWithTag("Test").transform.position.z;
				navComponent.destination = new Vector3(positionX+tarX, 0, positionZ+tarZ);
				timeSwitch -= 1;
			}
		}
		if (dist <= deathDistance) {
			//NGASIH PERTANYAAN
			if (a == true) {
				int random = Random.Range(1,11);
				if(random == 1){
					Canvas.Instantiate (soal1);
				}else if(random == 2){
					Canvas.Instantiate(soal2);
				}else if(random == 3){
					Canvas.Instantiate(soal3);
				}else if(random == 4){
					Canvas.Instantiate(soal4);
				}else if(random == 5){
					Canvas.Instantiate(soal5);
				}else if(random == 6){
					Canvas.Instantiate(soal6);
				}else if(random == 7){
					Canvas.Instantiate(soal7);
				}else if(random == 8){
					Canvas.Instantiate(soal8);
				}else if(random == 9){
					Canvas.Instantiate(soal9);
				}else if(random == 10){
					Canvas.Instantiate(soal10);
				}
				
				a = false;
				Time.timeScale = 0;
				DestroyImmediate (musuh, true);
			}
			
			
		}
	}
}
