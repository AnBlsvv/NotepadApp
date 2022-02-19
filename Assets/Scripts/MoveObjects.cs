using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveObjects : MonoBehaviour
{
	float speed = 6f; //скорость, с которой двигаются платформы

	void FixedUpdate()
	{
		//платформы двигаются влево, с заданной скоростью speed
		transform.Translate(Vector3.left * speed * Time.deltaTime);
		// если платформа выходит за границы экрана, удаляем ее
		if (transform.position.x < -17.0f)
		{
			Destroy(gameObject);
		}
	}
}
