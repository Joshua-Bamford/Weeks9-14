using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public int seconds;
    public int minutes;
    public int currentStage;
    public float timeLimit = 500;
    public TMP_Text timerText;
    public GameObject panel_1;
    public GameObject panel_2;
    public UnityEvent timerDone;

    
    const int correctValue = 15; // Correct value to compare against in stage 1. ADBBCC A=1 B=2 C=3 D=4
    // Start is called before the first frame update
    void Start()
    {
        currentStage = 1;
       StartCoroutine(Timekeeping());
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLimit <= 0)
        {
            timerDone.Invoke();
        }

    }
    public void ChangeStage()
    {
        currentStage = 2;
    }

   private IEnumerator Timekeeping()
 {
        panel_1.SetActive(false);

        while (currentStage == 1)
       {
       timeLimit -= Time.deltaTime;
       timerText.text = timeLimit.ToString();
       yield return null;     
       }
        panel_1.SetActive(true);
        panel_2.SetActive(false);

        while (currentStage == 2)
        {
            timeLimit -= Time.deltaTime;
            timerText.text = timeLimit.ToString();
            yield return null;
        }

    }
}
