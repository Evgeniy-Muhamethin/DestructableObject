using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Bullet"))
		{
			gameObject.GetComponent<Rigidbody>().useGravity = true;
		}
	}
}
