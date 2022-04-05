using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideController : MonoBehaviour
{
    public GuideItem guide;
    public GuideItem mapGuide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            guide.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            guide.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            mapGuide.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            mapGuide.gameObject.SetActive(false);
        }


    }
}
