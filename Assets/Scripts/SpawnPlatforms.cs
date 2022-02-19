using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour
{
	public GameObject[] platforms; //������ � ������ ������� �� ������ �����������, � ������ ������� ������� ����� ���� =) 
	float y_coordinate = -2.5f; // ���������� � ��� ������������ ��������� (������ ���������)

	private void Start()
	{
		// ��������� ����������� ���� ������ ��������
		StartCoroutine(spawn());
	}
	IEnumerator spawn()
	{
		while (true)
		{
			// ������� ������ �����
			Instantiate(
				platforms[Random.Range(0, platforms.Length)],
				//�� ����� ������ 
				new Vector3(15.0f, y_coordinate, 0),
				// ������ no rotation
				Quaternion.identity
			);
			// � ������ � ����������
			y_coordinate *= -1;
			yield return new WaitForSeconds(1.7f);
		}
	}
}

