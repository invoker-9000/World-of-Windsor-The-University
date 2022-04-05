using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class CharacterSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGameMale()
    {
        PlayerController.playerCharacter = "Animations/MalePlayer/Player";
        SceneManager.LoadScene("MainGame");
    }
    public void PlayGameFemale()
    {
        PlayerController.playerCharacter = "Animations/FemalePlayer/F_Player_Front_view";
        SceneManager.LoadScene("MainGame");
    }
}
