using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;

	// Продолжить игру. Меню паузы скрывается
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	// Игра на паузе, игровое время останавливается
	public void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	// При проигрыше, можно переиграть
	public void Resrart()
	{
		Time.timeScale = 1f;
		GameIsPaused = false;
		SceneManager.LoadScene(1);
	}
	// выход в начальное меню
	public void LoadMenu()
	{
		SceneManager.LoadScene(0);
	}
}
