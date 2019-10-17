using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndTeleporter : MonoBehaviour
{
	//this object is object we want to teleport somewhere. Will be set in unity inspector
	public GameObject objectToTeleport;
	//we will tell script which scene we should load. Scenes will be draged in build options
	public int whichSceneToLoad;
	//this is standart unity monobehaviour function. Is called if two objects with colliders and at least on of them has rigidbody collides with one another
	public void OnTriggerEnter(Collider other)
	{
		//we will check if object which collided is our object. If not, then do nothing
		if (other.gameObject == objectToTeleport)
		{
			//0 - we will reserve for Menu. We dont want to save progress in menu. Progress should always be in some level
			//player prefs is some place which will persist even after game is closed. we can save some data there
			//we are setting new level in our whichlevel variable in playerprefs. If we will close the game, it will still be there
			PlayerPrefs.SetInt("WhichLevel", whichSceneToLoad);
			SceneManager.LoadScene(whichSceneToLoad);
		}
	}
}
