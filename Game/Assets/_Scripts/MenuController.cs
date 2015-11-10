using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject HowToPlay;
	public GameObject Settings;

	public void ToMainMenu()
	{
		mainMenu.SetActive(true);
		HowToPlay.SetActive(false);
		Settings.SetActive(false);
	}

	public void ToHowToPlay()
	{
		mainMenu.SetActive(false);
		HowToPlay.SetActive(true);
	}

	public void ToSettings()
	{
		mainMenu.SetActive(false);
		Settings.SetActive(true);
	}

	public void startGame()
	{
		Application.LoadLevelAsync(2);
	}

	public void quitGame()
	{
		Application.Quit();
	}
}
