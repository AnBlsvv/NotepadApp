using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	//  нопка начала игры
	public void StartGame()
	{
		SceneManager.LoadScene(1);
		Time.timeScale = 1f;
	}
	// кнопка дл€ выхода из игры
	public void Quit()
	{
		Application.Quit();
	}
}
