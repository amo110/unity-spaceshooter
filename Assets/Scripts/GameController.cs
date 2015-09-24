﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public GameObject hazard;
	public Vector3 spawnValues;
	void Start ()
	{
		SpawnWaves ();
	}

	void SpawnWaves ()
	{
		Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identify;
		Instantiate (hazard, spawnPosition, spawnRotation);
	}
}