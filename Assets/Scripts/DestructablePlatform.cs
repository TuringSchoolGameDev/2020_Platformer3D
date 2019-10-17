using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructablePlatform : MonoBehaviour
{
	public float respawnTime;
	public float disappearTime;

	//private variables is variables which will be invisible by other scripts or unity editor
	public float respawnTimer = 0;
	public float disappearTimer = 0;
	public bool calculatedTimeForDisappearance;

	//this is our player gameObject
	public GameObject playerGameObject;
	//we will drag some components here.
	public Renderer thisRenderer;
	public Collider thisCollider;


	private void Update()
	{
		//this is AND operation &&
		//if will be true if both operators are true
		if ((thisRenderer.enabled == false) && (thisCollider.enabled == false))
		{
			//calculating time
			respawnTimer += Time.deltaTime;
			//if time is greater than our respawn time then do something
			if (respawnTimer > respawnTime)
			{
				respawnTimer = 0;
				disappearTimer = 0;
				//enabled collision and visuals of platform
				thisRenderer.enabled = true;
				thisCollider.enabled = true;
			}
		}

		if (calculatedTimeForDisappearance == true)
		{
			disappearTimer += Time.deltaTime;
			//calculate disappear time here
			if (disappearTimer > disappearTime)
			{
				respawnTimer = 0;
				disappearTimer = 0;
				//disable collision and visuals of platform
				thisRenderer.enabled = false;
				thisCollider.enabled = false;
			}
		}
	}

	//will triger then someone with rigidbody and collider will be on this object collision area
	public void OnTriggerEnter(Collider other)
	{
		//we will check if object is our expected player object
		if (other.gameObject == playerGameObject)
		{
			respawnTimer = 0;
			calculatedTimeForDisappearance = true;
		}
	}

	public void OnTriggerExit(Collider other)
	{
		//we will check if object is our expected player object
		if (other.gameObject == playerGameObject)
		{
			calculatedTimeForDisappearance = false;
		}
	}
}
