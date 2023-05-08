using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionsActionCube : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3(0,0.5f,1.5f), Space.Self);
		}
	}
}
