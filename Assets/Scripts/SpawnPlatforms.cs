using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour
{
	public GameObject[] platforms; //массив с нашими разными по длинне платформами, а точнее пустыми местами между ними =) 
	float y_coordinate = -2.5f; // координата у для расположения платформы (только начальная)

	private void Start()
	{
		// запускаем бесконечный цикл спавна платформ
		StartCoroutine(spawn());
	}
	IEnumerator spawn()
	{
		while (true)
		{
			// спавмим пустое место
			Instantiate(
				platforms[Random.Range(0, platforms.Length)],
				//на новый вектор 
				new Vector3(15.0f, y_coordinate, 0),
				// объект no rotation
				Quaternion.identity
			);
			// и меняем у координату
			y_coordinate *= -1;
			yield return new WaitForSeconds(1.7f);
		}
	}
}

