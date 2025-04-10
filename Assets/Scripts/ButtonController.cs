using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
 
    public int[] inputSequence = {0, 0, 0, 0};
    public UnityEvent answerCorrect;
    const int correctValue = 10; // Correct value to compare against in stage 1. ADCB A=1 B=2 C=3 D=4
    public int valueOfButtonPressed;
    public SpriteRenderer buttonASprite;
    public SpriteRenderer buttonBSprite;
    public SpriteRenderer buttonCSprite;
    public SpriteRenderer buttonDSprite;
    // Start is called before the first frame update
    void Start()
    {
        inputSequence = new int[4];
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("Current Answer" + inputSequence[0] + inputSequence[1] + inputSequence[2] + inputSequence[3]);
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);    //record current position of mouse

        if (buttonASprite.bounds.Contains(mousePosition))   
        {
            if (Input.GetMouseButtonDown(0)) {
                AddInputSequence(1);
            }
        }
        if(buttonBSprite.bounds.Contains(mousePosition))
        {
            if (Input.GetMouseButtonDown(0))
            {
                AddInputSequence(2);
            }
        }
        if (buttonCSprite.bounds.Contains(mousePosition))
        {
            if (Input.GetMouseButtonDown(0))
            {
                AddInputSequence(3);
            }
        }

        if(buttonDSprite.bounds.Contains(mousePosition))
        {
            if (Input.GetMouseButtonDown(0))
            {
                AddInputSequence(4);
            }
        }

        if (inputSequence[3] != 0)
        {
            if ((inputSequence[0] + inputSequence[1] + inputSequence[2] + inputSequence[3]) == correctValue)    //if the sum value of all button inputs equals the correct amount for the sequence
            {
                answerCorrect.Invoke();
            }
        }


    }

    public void AddInputSequence(int valueOfButtonPressed)
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
        else
        {

            inputSequence[0] = 0;
            inputSequence[1] = 0;
            inputSequence[2] = 0;
            inputSequence[3] = 0;
        }


    }

}
