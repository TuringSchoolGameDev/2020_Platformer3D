using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public GameObject creditsGameObject;
	public GameObject menuGameObject;

	// methods will be linked with button in unity
	public void OnStartClick()
	{
		//we will look for player prefs value with name WhichLevel. if none - then return 1;
		int whichLevel = PlayerPrefs.GetInt("WhichLevel", 1);
		if (whichLevel == 0)
		{
			PlayerPrefs.SetInt("WhichLevel", 1);
			whichLevel = 1;
		}
		//load new scene.
		SceneManager.LoadScene(whichLevel);
	}

	public void OnCreditsClick()
	{
		//enable credits menu
		creditsGameObject.SetActive(true);
		//disable menu object. if this script is on some object which will be disabled, this script will be disabled as well.
		//anything after this line cannt be called
		menuGameObject.SetActive(false);
	}

	public void OnExitClick()
	{
		Debug.Log("Exit");
		//this will quit application
		Application.Quit();
	}

	//same as before with oncreditsclick, but in reverse. we will close cedits and show menu again
	public void OnBackButtonInCreditsClick()
	{
		creditsGameObject.SetActive(false);
		menuGameObject.SetActive(true);
	}
}
