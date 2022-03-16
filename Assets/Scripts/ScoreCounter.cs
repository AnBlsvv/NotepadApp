using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int Score = 0; // score in game
    public Text scoreCount; // text field for score in game
    public Text scoreNum; // text field for score in lose menu

    void Start()
    {
        StartCoroutine(AddScore()); // call the coroutine
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount.text = Score.ToString(); //from int to text for the text field score in game
        scoreNum.text = Score.ToString(); //from int to text for the text field score in lose menu
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
