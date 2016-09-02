var warptarget : Transform;
var warptarget2 : Transform;
var warptarget3 : Transform;


function Update () {
	
}

function OnTriggerEnter (col : Collider){
	if(col.gameObject.tag == "Warp001"){
		this.transform.position = warptarget.position;
	}
	if(col.gameObject.tag == "Warp002"){
	this.transform.position = warptarget2.position;
	}
	
	if(col.gameObject.tag == "Warp003"){
	this.transform.position = warptarget3.position;
	}
}
