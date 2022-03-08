using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{
    public int questNumber;
    public string itemName;

    private QuestManager questManager; 
    // Start is called before the first frame update
    void Start()
    {
        questManager = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (!questManager.questCompleted[questNumber] && questManager.quests[questNumber].gameObject.activeSelf)
            {
                questManager.itemCollected = itemName;
                gameObject.SetActive(false);
            }
        }
    }
}
