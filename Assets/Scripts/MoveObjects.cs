using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveObjects : MonoBehaviour
{
	public Data data;

	void FixedUpdate()
	{		
		// empty spaces between platforms move to the left at a given speed
		transform.Translate(Vector3.left * data.speed * Time.deltaTime);
		// if the empty space is out of screen view on the left (-17.0), destroy this game object
		if (transform.position.x < data.leftCoordinate_for_destroy)
		{
			Destroy(gameObject);
		}
	}
}
