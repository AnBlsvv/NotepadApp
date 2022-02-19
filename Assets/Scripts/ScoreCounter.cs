using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int Score = 0; // ������� ����� �� ����
    public Text scoreCount; // ���������� ���� �� ����� ����
    public Text scoreNum; // ���������� ���� �� ������ ���������

    private Coroutine myCoroitine;

    void Start()
    {
        myCoroitine = StartCoroutine(AddScore()); // �������� ������� �������� �����
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount.text = Score.ToString(); //����������� ���� ����� � ����� ��� �������� ��������
        scoreNum.text = Score.ToString(); // � ��� ������ ���������
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
