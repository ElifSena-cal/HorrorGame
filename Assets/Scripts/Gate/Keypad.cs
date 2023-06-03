using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Keypad : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject keypadUI;
    public Text passwordText;
    public string password;
    public FirstPersonController playerScript;
    public GameObject dropText;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            playerScript.enabled = true;
            keypadUI.SetActive(false);
            dropText.SetActive(false);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            keypadUI.SetActive(true);
            playerScript.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            dropText.SetActive(true);
        }
    }

    public void OpenDoor()
    {
        if (passwordText.text == "120")
        {
            keypadUI.SetActive(false);
            Debug.Log("Password Correct");

        }
    }
    public void KeyButton(string key)
    {
        passwordText.text += key;
    }
    public void ResetPassword()
    {
        passwordText.text = "";
    }
    public void CheckPassword()
    {
        if (passwordText.text == "120")
        {

            keypadUI.SetActive(false);
            Debug.Log("Password Correct");
            playerScript.enabled = true;
            dropText.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            ResetPassword();
        }
    }
}
