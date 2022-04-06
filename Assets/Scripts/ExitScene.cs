using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
  
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("QUIT!!!");
    }
    public void OnClickPlayAgain()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }
}
