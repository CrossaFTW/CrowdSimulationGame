using UnityEngine;
using System.Collections;

public class MenuAwal : MonoBehaviour {
	public Canvas Prakata;
	public Canvas Pembuat;
	public Canvas Mulai;
	public Object Canvas;

	public void ButtonPembuat(){
		Destroy (Canvas);
		Instantiate (Pembuat);
	}
	public void ButtonMulai(){
		Destroy (Canvas);
	}
		        
	public void ButtonPrakata(){
		Destroy (Canvas);
		Instantiate (Prakata);
	}
	
}
