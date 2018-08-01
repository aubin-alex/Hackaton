using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class passeCollection : MonoBehaviour {
	void Start()
	{
	}

	public void NextLevelButton(string levelName)
	{
		SceneManager.LoadScene(3);
	}
}


