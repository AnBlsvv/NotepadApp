using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int Score = 0; // подсчет очков за игру
    public Text scoreCount; // отображает очки во время игры
    public Text scoreNum; // отображает очки на экране Пройгрыша

    private Coroutine myCoroitine;

    void Start()
    {
        myCoroitine = StartCoroutine(AddScore()); // вызываем функцию подсчета очков
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount.text = Score.ToString(); //преобразуем наше число в текст для игрового процесса
        scoreNum.text = Score.ToString(); // и для экрана пройгрыша
    } 
    IEnumerator AddScore()
	{
		while (true)
		{
            Score++;
            yield return new WaitForSeconds(1f);
        }
       
	}
}
