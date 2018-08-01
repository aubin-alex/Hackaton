using UnityEngine;
using System.Collections;

public class scriptBoutonMenu : MonoBehaviour {

    // Use this for initialization
    public GameObject canvas;
    public GameObject sidePanel;

    void Update()
    {
        Rect canvasRect = canvas.GetComponent<RectTransform>().rect;

        Vector2 tailleCanvas = new Vector2(canvasRect.width, canvasRect.height);
        Vector2 taillePanel = sidePanel.GetComponent<RectTransform>().sizeDelta;
        float scaleFactor = tailleCanvas.x / taillePanel.x;
        gameObject.GetComponent<RectTransform>().localScale = Vector3.one * scaleFactor;

       
    }
}
