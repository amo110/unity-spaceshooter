﻿using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float tumble;

	void Start ()
	{
		Rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	
	}

}
