using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	public float speed;

	void Start ()
	{
		Rigidbody.velocity = Transform.forward * speed;
	}
}
