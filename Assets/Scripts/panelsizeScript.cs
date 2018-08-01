using UnityEngine;
using System.Collections;

public class panelsizeScript : MonoBehaviour {

    // Use this for initialization
    public GameObject canvas;
    public GameObject sidePanel;

    void Update()
    {
        Rect canvasRect = canvas.GetComponent<RectTransform>().rect;

        Vector2 tailleCanvas = new Vector2(canvasRect.width, canvasRect.height);
        Vector2 taillePanel = sidePanel.GetComponent<RectTransform>().sizeDelta;
        float scaleFactorX = tailleCanvas.x / taillePanel.x;
        float scaleFactorY = tailleCanvas.y / taillePanel.y;
        gameObject.GetComponent<RectTransform>().localScale = new Vector3 (scaleFactorX,scaleFactorY,1);


    }
}
