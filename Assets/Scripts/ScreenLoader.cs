using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour {
	void Start()
	{
	}

	public void NextLevelButton1(string levelName)
	{
		SceneManager.LoadScene(1);
	}
    public void NextLevelButton3(string levelName)
    {
        SceneManager.LoadScene(3);
    }

    public void NextLevelButton2(string levelName)
    {
        SceneManager.LoadScene(2);
    }

    public void nefertiti(string levelname)
    {
        SceneManager.LoadScene(4);
    }

    public void jules(string levelname)
    {
        SceneManager.LoadScene(5);
    }

    public void paysage(string levelname)
    {
        SceneManager.LoadScene(6);
    }
}


