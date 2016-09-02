using UnityEngine;
using System.Collections;

public class CollisionAwal : MonoBehaviour {
    Transform thisPlayer;
    Collider myCollider;
    GameObject Glow;
	// Use this for initialization
	void Start () {
        thisPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        thisPlayer.gameObject.tag = "PlayerTembus";
    }
	
	// Update is called once per frame
	void Update () {
        if (thisPlayer.gameObject.tag == "PlayerTembus")
        {
            Glow = GameObject.FindGameObjectWithTag("Glow");
            myCollider = Glow.GetComponent<Collider>();
            myCollider.isTrigger = true;
            if(this.thisPlayer.transform.position.z > 105)
            {
                myCollider.isTrigger = false;
                thisPlayer.gameObject.tag = "Player";
                GetComponent<CollisionAwal>().enabled = false;
            }
        }
	}


}
