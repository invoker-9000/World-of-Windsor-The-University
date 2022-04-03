using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StorylineManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
   // public AudioSource musicSource;
   // public AudioClip[] musicClips;

    public bool dialogActive;

    private DialogueMusicManager mMan;
    private SceneController sMan;

    public string[] dialogLines;
    public int currentLine;
    // Start is called before the first frame update
     void Start()
    {
        mMan= FindObjectOfType<DialogueMusicManager>();
        sMan= FindObjectOfType<SceneController>();
      
      // mMan.PlayMusicLoop();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogActive && Input.GetKeyDown(KeyCode.Space))
        {

              
                mMan.musicSource.clip= mMan.musicClips[currentLine];
                mMan.musicSource.Play();
                currentLine++;
            
        }
       if(dialogActive && currentLine >= dialogLines.Length){

            dBox.SetActive(false);
            dialogActive=false;

            currentLine=0;
            sMan.CharacterSeletionIntegration();
        }
        dText.text = dialogLines[currentLine];

       
     }



}
