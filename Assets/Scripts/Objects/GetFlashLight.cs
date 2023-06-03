using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFlashLight : MonoBehaviour
{
    public float theDistance;
    public GameObject flashLight;
    public GameObject actionKey;
    public GameObject flashTakenText;


    public GameObject realFlasgLight;
    public GameObject flashActivition;
    
    public bool flashTaken;
    // Start is called before the first frame update
    void Start()
    {
        flashTaken = false;
    }

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRay.distanceFromTarget;
    }
    void OnMouseOver()
    {
        if (theDistance<=2)
        {
            actionKey.SetActive(true);
            
        }
        else
        {
            actionKey.SetActive(false);

        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 2)
            {
                flashTaken = true;
                this.GetComponent<BoxCollider>().enabled = false;
           
                actionKey.SetActive(false);
                flashTakenText.SetActive(true);
                flashActivition.SetActive(true);
                StartCoroutine(FlashTakenText());
                flashLight.GetComponent<MeshRenderer>().enabled = false;
           
                
                realFlasgLight.SetActive(true);
            }
        }
      
    }

    void OnMouseExit()
    {
        actionKey.SetActive(false);
    
    }
    IEnumerator FlashTakenText()
    {
        yield return new WaitForSeconds(2f);
        flashTakenText.SetActive(false);
        yield return new WaitForSeconds(4f);
        flashActivition.SetActive(false);
    }


}
