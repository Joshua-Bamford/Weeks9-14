using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
   // public SpriteRenderer buttonImage;
    Color highlightColor = new Color(255f, 218f, 69f);
    Color regularColor = new Color(178f, 178f, 785f);
    public int[] inputSequence = {0, 0, 0, 0};
    public UnityEvent HoveringOver;
    public UnityEvent HoveringOut;
    public UnityEvent ButtonClicked;
    bool previouslyHovering = false;
    SpriteRenderer buttonSprite;
    public int valueOfButtonPressed;
    

    // Start is called before the first frame update
    void Start()
    {
        buttonSprite = GetComponent<SpriteRenderer>();
     inputSequence = new int[4];
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("Current Answer" + inputSequence[0] + inputSequence[1] + inputSequence[2] + inputSequence[3]);
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (buttonSprite.bounds.Contains(mousePosition))
        {
            previouslyHovering = true;
            HoveringOver.Invoke();

            if (Input.GetMouseButtonDown(0)) {
                ButtonClicked.Invoke();
            }
        }
        if (!buttonSprite.bounds.Contains(mousePosition) && previouslyHovering) 
        {
            HoveringOut.Invoke();
        }
    }

    public void AddInputSequence()
    {
        if (inputSequence[0] == 0)
        {
            inputSequence[0] = valueOfButtonPressed;
        }
        else if (inputSequence[1] == 0)
        {
            inputSequence[1] = valueOfButtonPressed;
        }
        else if (inputSequence[2] == 0)
        {
            inputSequence[2] = valueOfButtonPressed;
        }
        else if (inputSequence[3] == 0)
        {
            inputSequence[3] = valueOfButtonPressed;
        }
       
    }

    public void HighlightButton()
    {
        buttonSprite.color = highlightColor;
       // Debug.Log("Mouse is over button");
    }
    public void DeHighlightButton()
    {
            buttonSprite.color = regularColor;
            previouslyHovering = false;
        
       // Debug.Log("Mouse is no longer over button");
    }
}
