using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveObjects : MonoBehaviour
{
	private float speed = 7f; // speed for the empty spaces

	void FixedUpdate()
	{
		// empty spaces between platforms move to the left at a given speed
		transform.Translate(Vector3.left * speed * Time.deltaTime);
		// if the empty space is out of screen view on the left (-17.0), destroy this game object
		if (transform.position.x < -17.0f)
		{
			Destroy(gameObject);
		}
	}
}
