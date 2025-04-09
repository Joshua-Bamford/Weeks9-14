using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public SpriteRenderer buttonImage;
    Color highlightColor = new Color(255f, 218f, 69f);
    Color regularColor = new Color(185f, 185f, 185f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MouseHoveringOverButton()
    {
        buttonImage.color = highlightColor;
        Debug.Log("Mouse is over button");
    }

    public void MouseLeavingButton()
    {
        buttonImage.color = regularColor;
        Debug.Log("Mouse is no longer over button");
    }
}
