using UnityEngine;
using System.Collections;

public class MainMenuHandler : MonoBehaviour {

	public Canvas MainMenuCanvas;
	public Canvas SettingsCanvas;
	public Canvas CreditCavas;


	void Start(){
		MainMenuCanvas.enabled = true;
		SettingsCanvas.enabled = false;
		CreditCavas.enabled = false;
	}
	public void startLevelOne(){
		Application.LoadLevel("First Scene");
	}
	public void settingsPanel(){
		MainMenuCanvas.enabled = false;
		SettingsCanvas.enabled = true;
	}
	public void Back(){
		SettingsCanvas.enabled = false;
		CreditCavas.enabled = false;
		MainMenuCanvas.enabled= true;


	}
	public void creditsPanel(){
		MainMenuCanvas.enabled = false;
		CreditCavas.enabled = true;
	}
	public void exitApp(){
		Application.Quit();
	}
}
