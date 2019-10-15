using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class GameScene : MonoBehaviour {

	public LoadSceneMode loadMode = LoadSceneMode.Single;

	public void LoadScene (string sceneName)
	{
		SceneManager.LoadScene (sceneName, loadMode);
	}

	public void LoadScene (int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex, loadMode);
	}
}
	