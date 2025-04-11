using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public int currentStage = 1;    //stages are the different challenges that you can use the buttons to complete
    public float timeLimit; //time limit is defied in inspector. Set to 100 seconds
    public TMP_Text timerText;
    public GameObject panel_1;
    public GameObject panel_2;
    public UnityEvent timerDone;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Timekeeping());
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLimit <= 0)
        {
            timerDone.Invoke(); //This invoked event calls the predefined function ParticleSystemRenderer.enabled which causes the explosion particle effect
        }

    }
    public void ChangeStage()
    {
        currentStage = 2;  //Invoked by answerCorrect UnityEvent on Button Controller
    }

   private IEnumerator Timekeeping()
 {
        panel_1.SetActive(false);   //uncovers the first service panel to reveal the first input to solve

        while (currentStage == 1)
       {
       timeLimit -= Time.deltaTime; //decrements timer every second
       timerText.text = timeLimit.ToString();   //update new time value to text UI
       yield return null;     //returns to beginning and if currentStage is still equal to 1, stay in this loop
       }
        panel_1.SetActive(true);    //once the condition for the previous while loop is met, reveal the second stage and put the previous service panel back in place
        panel_2.SetActive(false);

        while (currentStage == 2)
        {
            timeLimit -= Time.deltaTime;
            timerText.text = timeLimit.ToString();
            yield return null;
        }   //Unfortunately ran out of time to add in the second stage of the challenge

    }
}
