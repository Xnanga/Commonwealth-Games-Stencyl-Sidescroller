using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {
	
	public GUISkin customSkin = null;
	
	public void OnGUI() {
		if(customSkin != null)
			GUI.skin = customSkin;
		
		int buttonWidth = 100;
		int buttonHeight = 50;
		int halfButtonWidth = buttonWidth / 2;
		int halfScreenWidth = Screen.width / 2;
		
		if( GUI.Button( new Rect(halfScreenWidth-halfButtonWidth,450, buttonWidth, buttonHeight), "Play") )
		{
			Application.LoadLevel("LevelSelect");
		}	
	}
}
