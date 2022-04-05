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

        
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;

            if (currentLine >= dialogLines.Length)
            {

                dBox.SetActive(false);
                dialogActive = false;

                currentLine = 0;
                sMan.CharacterSeletionIntegration();

            }
            else
            {
                mMan.musicSource.clip = mMan.musicClips[currentLine];
                mMan.musicSource.Play();
            }

        }
       
        dText.text = dialogLines[currentLine];

       
     }



}
