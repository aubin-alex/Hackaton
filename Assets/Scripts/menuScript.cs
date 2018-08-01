using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

    public GameObject sidePanel;

    public void showOrHideSidePanel()
    {
        bool enabled = sidePanel.activeSelf;
        sidePanel.SetActive(!enabled);
    }
}
