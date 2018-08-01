using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PointManager : MonoBehaviour {

	public Image point1;
	public Image point2;
	public Image point3;
	int i,j;


	// Use this for initialization
	void Awake () {
		
		point1.color = new Color (point1.color.r, point1.color.g, point1.color.b, 0);
		point2.color = new Color (point2.color.r, point2.color.g, point2.color.b, 0);
		point3.color = new Color (point3.color.r, point3.color.g, point3.color.b, 0);
		i = 0;
		j = 0;

	}
		
	void FixedUpdate()
	{
		Colorier (i);
		Debug.Log (i);
		i = i + 1;
		if (i == 120) 
		{
			i = 0;
			point1.color = new Color (point1.color.r, point1.color.g, point1.color.b, 0);
			point2.color = new Color (point2.color.r, point2.color.g, point2.color.b, 0);
			point3.color = new Color (point3.color.r, point3.color.g, point3.color.b, 0);
			j++;
		}
		if (j == 2) 
		{
			LoadNiveau ();
		}

	}



	void Colorier(int i)
	{

		if (i==30) 
		{
			point1.color = new Color (255, 255, 255, 255);
		}
		if (i==60)
		{
			point2.color = new Color(255,255,255,255);
		}
		if (i==90) 
		{
			point3.color = new Color(255,255,255, 255);
		}


	}

	void LoadNiveau()
	{
		SceneManager.LoadScene (1);
	}

}
