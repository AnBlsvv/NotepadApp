using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour
{
	public GameObject[] platforms; // an array containing empty spaces of different sizes 
	private float y_coordinate = -2.5f; // y coordinate for locating empty spaces

	private void Start()
	{
		// start an endless loop of spawning empty spaces between platforms
		StartCoroutine(spawn());
	}
	IEnumerator spawn()
	{
		while (true)
		{
			// create  empty space
			Instantiate(
				platforms[Random.Range(0, platforms.Length)], 
				new Vector3(15.0f, y_coordinate, 0),
				// no rotation
				Quaternion.identity
			);
			// change the coordinate
			y_coordinate *= -1;
			yield return new WaitForSeconds(0.9f);
		}
	}
}

