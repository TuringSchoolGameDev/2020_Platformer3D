using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
	//this object is object we want to teleport somewhere. Will be set in unity inspector
	public GameObject objectToTeleport;
	//place where we will teleport some object. will be set in unity inspector
	public GameObject targetPlace;

	//this is standart unity monobehaviour function. Is called if two objects with colliders and at least on of them has rigidbody collides with one another
	
	public void OnTriggerEnter(Collider other)
	{
		//we will check if object which collided is our object. If not, then do nothing
		if (other.gameObject == objectToTeleport)
		{
			//if yes, then we want to teleport that object to new place
			other.gameObject.transform.position = targetPlace.transform.position;
		}
	}
}
