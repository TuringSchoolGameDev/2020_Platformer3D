using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
	//this is our player gameObject
	public GameObject playerGameObject;

	//will triger then someone with rigidbody and collider will be on this object collision area
	public void OnTriggerEnter(Collider other)
	{
		//we will check if object is our expected player object
		if (other.gameObject == playerGameObject)
		{
			//we will try to get Player script which is on playerGameObject. And call damage method there.
			playerGameObject.GetComponent<Player>().TakeDamage();
		}
	}
}
