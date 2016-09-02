#pragma strict
private var guiShow : boolean = false;

var riddle : Texture;

function onTriggerStay(Col : Collider){
	if(Col.tag == "Player"){
		guiShow = true;
		}
}

function onTriggerExit(Col : Collider){
	if(Col.tag == "Player"){
		guiShow = false;
		}
}

function OnGui(){
	if(guiShow == true){
		GUI.DrawTexture(Rect(Screen.width/4.5 , Screen.height/4.5 , 1024, 512), riddle);
	}
}
