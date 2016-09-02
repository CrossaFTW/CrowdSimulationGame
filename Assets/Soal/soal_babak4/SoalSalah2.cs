using UnityEngine;
using System.Collections;

public class SoalSalah2: MonoBehaviour {
	public void onClick(Canvas soal){
		Destroy (soal);
		Time.timeScale = 1;
		
	}
	private GameController gameController;
	public void onClick2(GameObject Musuh){
		Vector3 position;
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		gameController = gameControllerObject.GetComponent<GameController>();
		position = GameObject.FindGameObjectWithTag ("Cube2").transform.position;
		Instantiate (Musuh, position, transform.rotation);
		Instantiate (Musuh, position, transform.rotation);
		gameController.MinHP (1);
	}
}
