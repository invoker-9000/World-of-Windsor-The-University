using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    public bool dialogActive;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown("space"))
        {
            dBox.SetActive(false);
            dialogActive = false;
        }

        
    }
    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
        RectTransform rt = dBox.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(1000, 50 + (dialogue.Length / 53) * 50);

    }
    public void HideBox()
    {
        dialogActive = false;
        dBox.SetActive(false);
    }
   

}