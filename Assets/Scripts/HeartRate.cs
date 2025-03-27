using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRate : MonoBehaviour
{

    public AnimationCurve curve;
    public TrailRenderer trail;
    [Range(0, 1)] public float t;
    public float monitoringSpeed;
    Vector2 monitoringPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monitoringPosition = transform.position;

    if(trail.enabled == false && monitoringPosition.x >= (-7))
        {
            trail.enabled = true;
        }

        monitoringPosition.x += monitoringSpeed * Time.deltaTime;
        monitoringPosition.y = curve.Evaluate(t);
         t += (monitoringSpeed/4) * Time.deltaTime;
        if(monitoringPosition.x >= 6)
        {
            monitoringPosition.x = -6;
            trail.enabled = false;
        }

        if(t >= 1)
        {
        t = 0;
        }
        
        transform.position = monitoringPosition;
       
    }
}
