using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	// Game Start Button
	public void StartGame()
	{
		SceneManager.LoadScene(1);
		// if you remove this line end exit the game to the main menu, than back to the game
		// the game will be paused
		Time.timeScale = 1f;
	}
	// Game Exit Buttton
	public void Quit()
	{
		Application.Quit();
	}
}
