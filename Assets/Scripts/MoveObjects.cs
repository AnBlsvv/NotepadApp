using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveObjects : MonoBehaviour
{
	float speed = 6f; //��������, � ������� ��������� ���������

	void FixedUpdate()
	{
		//��������� ��������� �����, � �������� ��������� speed
		transform.Translate(Vector3.left * speed * Time.deltaTime);
		// ���� ��������� ������� �� ������� ������, ������� ��
		if (transform.position.x < -17.0f)
		{
			Destroy(gameObject);
		}
	}
}
