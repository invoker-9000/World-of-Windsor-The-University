using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{
    public int questNumber;
    public string itemName;
    private int animateCounter;
    private bool itemScaled;

    private QuestManager questManager; 
    // Start is called before the first frame update
    void Start()
    {
        questManager = FindObjectOfType<QuestManager>();
        animateCounter = 0;
        itemScaled = false;
    }

    // Update is called once per frame
    void Update()
    {
        animateCounter++;
        if (animateCounter % 60 == 0)
        {
            if (itemScaled)
            {
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / 2, gameObject.transform.localScale.y / 2, gameObject.transform.localScale.z);
                itemScaled = false;
            }
            else
            {
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 2, gameObject.transform.localScale.y * 2, gameObject.transform.localScale.z);
                itemScaled = true;
            }
            animateCounter = 0;
        }
            


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
