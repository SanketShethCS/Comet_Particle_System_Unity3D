using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

	public Vector3 myPos;
	public Transform myPlay;

	public void Update()
	{
		transform.position = myPlay.position + myPos;
	}
}
