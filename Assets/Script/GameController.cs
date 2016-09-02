using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	public Text HPText;
	public Canvas GameOver;
	
	private int healthPoint;

	// Use this for initialization
	void Start () {
		healthPoint = 3;
		UpdateScore_HP ();
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MinHP(int newHealthPoint){
		healthPoint -= newHealthPoint;
		UpdateScore_HP ();
	}

	public void UpdateScore_HP(){
		HPText.text= "HP: " + healthPoint.ToString ();
		if (healthPoint <= 0) {
			Destroy (GameObject.FindWithTag ("Player"));
			Instantiate(GameOver);
			Time.timeScale = 0;
		}
	}
	
}