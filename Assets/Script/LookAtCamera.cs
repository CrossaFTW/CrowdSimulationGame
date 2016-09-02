using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {
	public GameObject target;

	void LastUpdate(){
		transform.LookAt (target.transform);
	}

}
