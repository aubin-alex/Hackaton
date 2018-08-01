using UnityEngine;
using System.Collections;

public class Infos {

	string nom;
	string artiste;
	string date;

	//Constructeur
	public Infos(string m_nom, string m_artiste, string m_date)
	{
		nom = m_nom;
		artiste = m_artiste;
		date = m_date;
	}
	//Destructeur

	//Getter et setter du nom de l'oeuvre
	public string Nom
	{
		get
		{
			return nom;
		}
		set
		{
			nom = value;
		}
	}

	//Getter et setter de l'artiste de l'oeuvre
	public string Artiste
	{
		get
		{ 
			return artiste;
		}
		set
		{
			artiste = value;
		}
	}

	//Getter et setter de la date de création de l'oeuvre
	public string Date
	{
		get
		{ 
			return date;
		}
		set
		{ 
			date = value;
		}
	}

}
