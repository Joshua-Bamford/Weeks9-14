using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int seconds;
    public int minutes;
    public int currentStage;
    public float timeLimit;

   // Coroutine beginClock;

    // Start is called before the first frame update
    void Start()
    {
        currentStage = 1;
        //beginClock = StartCoroutine(Timekeeping());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private IEnumerator Timekeeping()
  //  {
       // while (currentStage == 1)
      //  {
        //    timeLimit -= Time.deltaTime;
           // timerDisplay.text = timeLimit.ToString();
            
      //  }
       // yield return null;
    //}
}
