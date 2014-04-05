#pragma strict

var customSkin:GUISkin;

function OnGUI () {

	var buttonWidth:int=110;
	var buttonHeight:int = 70;
	
	var halfScreenWidth:float=Screen.width/2;
	var halfButtonWidth:float=buttonWidth/2;
	
	GUI.skin=customSkin;
	
	if(GUI.Button(Rect(halfScreenWidth+buttonWidth*2,450,buttonWidth,buttonHeight),"Play Game"))
		Application.LoadLevel("CubeView");
	if (GUI.Button (Rect (halfScreenWidth+buttonWidth*2,450+buttonHeight,buttonWidth,buttonHeight), "Exit Game"))
    	Application.Quit();
}