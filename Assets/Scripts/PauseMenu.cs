using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public GameObject pauseMenuUI;

	// Resume the Game. Hide the pause menu
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
	}
	// The game is on pause, time stops in the game
	public void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
	}
	// Restart Button 
	public void Resrart()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}
	// Load Main Menu Button
	public void LoadMenu()
	{
		SceneManager.LoadScene(0);
	}
}
