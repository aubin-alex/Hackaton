using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Oeuvre {

	Infos info;
	GameObject objet3d; //Sera remplacé par point cloud
	Button img;

	//Constructeur
	public Oeuvre(Infos m_info, GameObject m_objet, Button m_img)
	{
		info = m_info;
		objet3d = m_objet;
		img = m_img;
	}
	//Destructeur
	~Oeuvre(){
	}


	//Getter et setter pour la miniature de l'oeuvre
	public Button image
	{
		get 
		{ 
			return img;
		}
		set 
		{
			img = value;
		}
	}

	//Getter et setter pour le "nuage de points" de l'oeuvre
	public GameObject Objet
	{
		get
		{ 
			return objet3d;
		}
		set
		{ 
			objet3d = value;
		}
	}

	//Getter et setter des infos de l'oeuvre
	public Infos Informations
	{
		get
		{ 
			return info;
		}
		set
		{ 
			info = value;
		}
	}

}
