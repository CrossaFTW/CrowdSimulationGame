using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public void Quit(){
		Application.Quit ();
	}

	public void PlayAgain(){
		Application.LoadLevel ("Crossa");
	}
}
