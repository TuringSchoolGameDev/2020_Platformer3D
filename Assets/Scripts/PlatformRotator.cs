using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotator : MonoBehaviour
{
	//kintamojo matomumas - kinamojo tipas - kintamojo pavadinimas
	public Rigidbody platformRigidbody;
	public Vector3 speed;

	private void Start()
	{
	}

	private void Update()
	{
		Quaternion tmpRotation = platformRigidbody.rotation;
		tmpRotation.eulerAngles += speed * Time.deltaTime;
		platformRigidbody.MoveRotation(tmpRotation);
	}


}