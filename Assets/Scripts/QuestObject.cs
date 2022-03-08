using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
    public int questNumber;

    public QuestManager questManager;

    public string startText;
    public string endText;

    public bool isItemQuest;
    public string targetItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isItemQuest)
        {
            if(questManager.itemCollected == targetItem )
            {
                questManager.itemCollected = null;
                EndQuest();
            }
        }
        
    }

    public void StartQuest()
    {
        questManager.ShowQuestText(startText);
    }

    public void EndQuest()
    {
        questManager.ShowQuestText(endText);
        questManager.questCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}
