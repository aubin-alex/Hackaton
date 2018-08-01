using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Collection : MonoBehaviour {

	[Header("Prefab")]
	public GameObject pref;

	[Header("Canvas")]
	public Canvas canvas;

	/*
	[Header("Objet 3D(vrai modèle)")]
	public GameObject tableau1;
	*/
	[Header("Nom - Auteur - Date")]
	public List<string> listText = new List<string> ();

	[Header("Miniature(bouton)")]
	public List<Sprite> listMiniature = new List<Sprite> ();

    [Header("Panels")]
    public List<GameObject> listPanels = new List<GameObject>();

    List<GameObject> listOeuvre = new List<GameObject> (new GameObject[4]);
	// Use this for initialization
	void Start () {
		int nombreMax = listText.Count > 4 ? 4 : listText.Count;
		Debug.Log (nombreMax);
		Vector2 dim = canvas.GetComponent<RectTransform> ().sizeDelta*canvas.scaleFactor;

		for (int i = 0; i < nombreMax; i++) 
		{
			Vector3 pos = new Vector3 ();
			if (i % 2 == 0) {
				pos = new Vector3 (-dim.x/4+dim.x/2, 0, 0);
			} else {
				pos = new Vector3 (dim.x/4+dim.x/2, 0, 0);
			}
			pos = new Vector3 (pos.x, (i/2) *-1*dim.y/2+3*dim.y/4, 0);
            //on instantie un prefab à la bonne position 
            //listOeuvre[i]= (GameObject) Instantiate(pref,pos, Quaternion.identity);
            //on le met enfant du canvas 
            //listOeuvre[i].transform.SetParent(canvas.transform);
            //on modifie ses infos et son oeuvre 

            //test de johst
            listOeuvre[i] = GameObject.Instantiate(pref);
            listOeuvre[i].transform.position = listPanels[i].transform.position;
            listOeuvre[i].transform.localScale *= 0.7f;
            listOeuvre[i].transform.SetParent(listPanels[i].GetComponent<RectTransform>());

			listOeuvre[i].GetComponentsInChildren<Text>()[1].text=listText[i];//"Paysage exotique - Douannier Rousseau - 1910";
			listOeuvre[i].GetComponentsInChildren<Button> () [0].image.overrideSprite = listMiniature[i];

		}
			
	

	}

	// Update is called once per frame
	void Update () {
	
	}
}
