using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Opening : MonoBehaviour
{
    public GameObject player;
    public GameObject fadeScreen;
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(OpeningSequence());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator OpeningSequence()
    {
        yield return new WaitForSeconds(1f);
        fadeScreen.SetActive(false);

        textBox.GetComponent<Text>().text = "Neler oluyor? Neredeyim?";
        yield return new WaitForSeconds(1f);
        textBox.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
