using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    Light Flight;
    public bool drainOverTime;
    public float maxBrightness;
    public float minBrightness;
    public float drainSpeed;


    void Start()
    {
        Flight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.F))
        {
            Flight.enabled = !Flight.enabled;
        }
        if (drainOverTime == true && Flight.enabled == true)
        {
            Flight.intensity = Mathf.Clamp(Flight.intensity, minBrightness, maxBrightness);
            if (Flight.intensity>minBrightness)
            {
                Flight.intensity -= Time.deltaTime * (drainSpeed / 1000);
            }
         
        }
        else if (drainOverTime==true && Flight.enabled == false)
        {
            if (Flight.intensity < maxBrightness)
            {
                Flight.intensity += Time.deltaTime * (drainSpeed / 1000);
            }
        }
    }
}
