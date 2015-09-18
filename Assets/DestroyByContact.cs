 using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary")
		{
			return
		}
		Instantiate(explossion, tranform.position, transform.rotation);
		if (other.tag == "Player") {
			Instantiate(PlayerExplossion, other.tranform.position, other.transform.rotation);
		}
		DestroyByContact (other.gameObject);
		Destroy (gameObject);
	}

}
