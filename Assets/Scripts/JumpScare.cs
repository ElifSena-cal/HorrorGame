using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject monster;

    // Start is called before the first frame update
    void Start()
    {
        monster.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            monster.SetActive(true);
            StartCoroutine(Jumps());
        }
     

    }
    
    IEnumerator Jumps()
    {
        yield return new WaitForSeconds(1);
        monster.SetActive(false);
        Destroy(gameObject);
    }


}
