#pragma strict
import UnityEngine.UI;

var textFile : TextAsset;
var dialogLines : String [];
var lineNumber : int;

var uiText : Text;
var canvas : Canvas;

function Start () {
	if(textFile){
		dialogLines = (textFile.text.Split("\n"[0]));
	}
}

function Update () {
	if(lineNumber < 0){
	lineNumber = 0;
	}
	
}

function Empty() {

}