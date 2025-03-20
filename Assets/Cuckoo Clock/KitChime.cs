using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public Transform theBird;
    public float timeBirdIsOut = 2;
    public float t;
    
    public void Chime(int hour)
    {
        Debug.Log("Chiming" + hour + "o'clock !");
       // StartCoroutine(Cuckoo());
    }
    public void ChimeWithoutArguments()
    {
        Debug.Log("Chiming !");
    }

    //private IEnumerator Cuckoo()
   // {
    //    t = 0;
     //   while(t < timeBirdIsOut)
    //    {
     //       t += Time.deltaTime;
           // theBird.localPosition(0, 3, 0);
       // }
        
   // }
}
