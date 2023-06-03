using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    public GameObject paper;
    public GameObject realpaper;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
   
        if (other.gameObject.tag == "Player")
        {
            paper.SetActive(true);
            realpaper.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            paper.SetActive(false);
            realpaper.SetActive(true);
        }
    }

}
