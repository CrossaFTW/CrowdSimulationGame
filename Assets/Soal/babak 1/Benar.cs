using UnityEngine;
using System.Collections;

public class Benar : MonoBehaviour {

    GameObject CharRuang1;
    GameObject thisPlayer;

    GameObject Glow1;
    GameObject Glow2;

    Collider myCollider;
    Collider myCollider2;

    void Start()
    {

    }


    public void onClick(GameObject soal){

        Destroy (soal);


        Glow1 = GameObject.FindGameObjectWithTag("Glow2");
        myCollider = Glow1.GetComponent<Collider>();
        myCollider.isTrigger = true;

        Glow2 = GameObject.FindGameObjectWithTag("Glow3");
        myCollider = Glow2.GetComponent<Collider>();
        myCollider.isTrigger = true;


        thisPlayer = GameObject.FindGameObjectWithTag("Player");
        thisPlayer.gameObject.tag = "PlayerTembus";


        CharRuang1 = GameObject.FindGameObjectWithTag("Cube1");
        Destroy(CharRuang1);
        
        Time.timeScale = 1;
	}
}
