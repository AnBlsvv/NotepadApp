using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Data", menuName = "Data")]
public class Data : ScriptableObject
{
	public float y_up; // upper y coordinate for player
	public float y_down; // lower y coordinate for player
	public float speed; //speed for the empty spaces
	public float leftCoordinate_for_destroy;
}
