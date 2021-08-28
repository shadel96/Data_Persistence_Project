using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public InputField nameInput;
    

    // Start is called before the first frame update
    public void StartGame()
    {
        if(nameInput.text != "")
        {
            Manager.Instance.playerName = nameInput.text;
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("No name entered");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
