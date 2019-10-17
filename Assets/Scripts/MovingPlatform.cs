using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	public Rigidbody movingRigidbody;
	public Vector3 speed;
	public Vector3 amplitude;

	Vector3 startingPosition;
	void Start()
	{
		startingPosition = movingRigidbody.position;
	}


	void Update()
	{
		Vector3 tmpPosition = startingPosition;
		tmpPosition.x += Mathf.Sin(Time.time * speed.x) * amplitude.x;
		tmpPosition.y += Mathf.Sin(Time.time * speed.y) * amplitude.y;
		tmpPosition.z += Mathf.Sin(Time.time * speed.z) * amplitude.z;
		movingRigidbody.MovePosition(tmpPosition);
	}
}
