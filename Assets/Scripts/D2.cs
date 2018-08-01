using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Vuforia;

public class D2 : MonoBehaviour {

    public GameObject imageTarget;
    public GameObject imageTarget1;
    public GameObject imageTarget2;
    public Text consigne;
    public bool targetDetecte = false;
    Vuforia.TrackableBehaviour.Status status;
    Vuforia.TrackableBehaviour.Status status1;
    Vuforia.TrackableBehaviour.Status status2;
    Vuforia.TrackableBehaviour tb;
    Vuforia.TrackableBehaviour tb1;
    Vuforia.TrackableBehaviour tb2;

    // Use this for initialization
    void Start () {
        tb = imageTarget.GetComponent<DefaultTrackableEventHandler>().GetComponent<TrackableBehaviour>();
        tb1 = imageTarget1.GetComponent<DefaultTrackableEventHandler>().GetComponent<TrackableBehaviour>();
        tb2 = imageTarget2.GetComponent<DefaultTrackableEventHandler>().GetComponent<TrackableBehaviour>();
    }
	
	// Update is called once per frame
	void Update () {
        status = tb.CurrentStatus;
        status1 = tb1.CurrentStatus;
        status2 = tb2.CurrentStatus;

        if (status == Vuforia.TrackableBehaviour.Status.DETECTED || status == Vuforia.TrackableBehaviour.Status.TRACKED || status == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            targetDetecte = true;
            consigne.text = "Buste de Jules César - Vercingétorix - 52 av J.-C.";
        }
        else if (status1 == Vuforia.TrackableBehaviour.Status.DETECTED || status1 == Vuforia.TrackableBehaviour.Status.TRACKED || status1 == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            targetDetecte = true;
            consigne.text = "Buste de Néfertiti - Thoutmôsis - XIVème siècle av J.-C.";
        }
        else if (status2 == Vuforia.TrackableBehaviour.Status.DETECTED || status2 == Vuforia.TrackableBehaviour.Status.TRACKED || status2 == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            targetDetecte = true;
            consigne.text = "Paysage exotique - Douanier Rousseau - 1910";
        }
        else
        {
            targetDetecte = false;
            consigne.text = "Scannez un marqueur pour ajouter une oeuvre à votre collection.";
        }
	}
}
