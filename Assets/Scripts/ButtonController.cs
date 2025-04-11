using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
 
    public int[] inputSequence = {0, 0, 0, 0};  //the array in which the player's last 4 inputs are recorded
    public UnityEvent answerCorrect;
    const int correctValue = 10; // Correct value to compare against in stage 1. ADCB A=1 B=2 C=3 D=4
    public int valueOfButtonPressed;    //each button has a numerical value. This variable parses that putton's value to the AddInputSequence
    public SpriteRenderer buttonASprite;    //references to buttons. Only need to check which button the cursor is over when the mouse is clicked
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

        if (buttonASprite.bounds.Contains(mousePosition))   //if the cursor is hovering over the specified button sprite
        {
            if (Input.GetMouseButtonDown(0)) {  
                AddInputSequence(1);    //since 1 is the value of button A, that number is given to the function which adds it to the array
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
                answerCorrect.Invoke(); //invoke the Unity Event which then calls the ChangeStage function in timer script
            }
        }


    }

    public void AddInputSequence(int valueOfButtonPressed)
    {
        if (inputSequence[0] == 0)  //systemically checks if the first, then second, third, and fourth value in the array are equal to 0 (meaning they have no value from input yet)
        {
            inputSequence[0] = valueOfButtonPressed;    //puts the value of the last button pressed into the first empty spot in the array
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

            inputSequence[0] = 0;   //if all four spots in the array have values, once the player tries putting in another, it automatically clears it to make room.
            inputSequence[1] = 0;   //likely will not reach this else, if the correct series of values is met
            inputSequence[2] = 0;
            inputSequence[3] = 0;
        }


    }

}
