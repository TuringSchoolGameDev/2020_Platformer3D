using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	//starting health will be set from UnityEditor Inspector, not here
	public int health;

	//This method will be called then player will receive damage
	public void TakeDamage()
	{
		//decrease health by 1 every time we receive a damage
		health = health - 1;

		//if health is 0 or less, then we should die. Just reload all game..
		if (health <= 0)
		{
			int whichLevel = PlayerPrefs.GetInt("WhichLevel", 1);
			SceneManager.LoadScene(whichLevel);
		}
	}
}



