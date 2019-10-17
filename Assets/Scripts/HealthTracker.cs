using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTracker : MonoBehaviour
{
	//we will drag Text label in unity inspector
	public Text healthText;

	//we will drag our player script here. in theore there can be multiple players, we will drag player, which should be tracked here.
	public Player player;

	//this is called every frame
	void Update()
	{
		//we will not think about performance for now. Each frame we will set out health here
		healthText.text = "Gyvybės: " + player.health.ToString();
	}
}

