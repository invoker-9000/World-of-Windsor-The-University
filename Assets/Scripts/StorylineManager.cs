using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StorylineManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogActive;

    public string[] dialogLines;
    public int currentLine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialogActive=false;

            currentLine++;
        }
       if(dialogActive && currentLine >= dialogLines.Length){

            dBox.SetActive(false);
            dialogActive=false;

            currentLine=0;
        }
        dText.text = dialogLines[currentLine];
     }


}
