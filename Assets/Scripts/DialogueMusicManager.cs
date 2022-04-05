using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMusicManager : MonoBehaviour
{
    public static DialogueMusicManager instance;

    public bool playing;
    public AudioSource musicSource;
    public AudioClip[] musicClips;
  

    // Start is called before the first frame update
    void Start()
    { 
    }

    public void PlayMusicLoop(){

            for(int i=0;i<musicClips.Length;i++){
               musicSource.clip= musicClips[i];
                musicSource.Play();
           }
    }
    // Update is called once per frame
    void Update()
    {
     
    }

}
