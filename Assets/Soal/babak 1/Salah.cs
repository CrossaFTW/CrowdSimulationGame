using UnityEngine;
using System.Collections;

public class Salah: MonoBehaviour {
	public GameObject soal1;
	public GameObject soal2;
	public GameObject soal3;
	public GameObject soal4;
	public GameObject soal5;
	public GameObject soal6;
	public GameObject soal7;
	public GameObject soal8;
	public GameObject soal9;
	public GameObject soal10;

	public void onClick(GameObject soal){
		Destroy (soal);
		Time.timeScale = 1;

	}
	private GameController gameController;
	public void onClick2(){
		int random2 = Random.Range (1, 11);
		GameObject Musuh = soal1;
		if (random2 == 1) {
			Musuh = soal1;
		} else if (random2 == 2) {
			Musuh = soal2;
		} else if (random2 == 3) {
			Musuh = soal3;
		} else if (random2 == 4) {
			Musuh = soal4;
		} else if (random2 == 5) {
			Musuh = soal5;
		} else if (random2 == 6) {
			Musuh = soal6;
		} else if (random2 == 7) {
			Musuh = soal7;
		} else if (random2 == 8) {
			Musuh = soal8;
		} else if (random2 == 9) {
			Musuh = soal9;
		} else if (random2 == 10) {
			Musuh = soal10;
		}

		Vector3 position;
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		gameController = gameControllerObject.GetComponent<GameController>();
		
		int random = Random.Range (1, 4);
		if (random == 1) {
			position = GameObject.FindGameObjectWithTag ("Spawn1").transform.position;
			Instantiate (Musuh, position, transform.rotation);
			Instantiate (Musuh, position, transform.rotation);
		} else if (random == 2) {
			position = GameObject.FindGameObjectWithTag ("Spawn2").transform.position;
			Instantiate (Musuh, position, transform.rotation);
			Instantiate (Musuh, position, transform.rotation);
		} else if (random == 3) {
			position = GameObject.FindGameObjectWithTag ("Spawn1").transform.position;
			Instantiate (Musuh, position, transform.rotation);
			Instantiate (Musuh, position, transform.rotation);
		}
		gameController.MinHP (1);
	}
}
