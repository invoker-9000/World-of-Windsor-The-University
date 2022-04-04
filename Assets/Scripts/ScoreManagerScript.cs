using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{

public static ScoreManagerScript instance;

    // Start is called before the first frame update
    public Text scoreText;
    int score = 0;

private void Awake()
{
instance= this;

}


    void Start()
    {
        scoreText.text= score.ToString()+" Points";
        
    }

   public void AddPoint() {
       score += 100;
       scoreText.text= score.ToString()+" Points";

   }
    
}
