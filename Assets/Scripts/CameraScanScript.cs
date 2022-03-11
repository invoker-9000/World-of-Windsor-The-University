using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScanScript : MonoBehaviour
{
    static WebCamTexture frontCam;

    // Start is called before the first frame update
    void Start()
    {
        if (frontCam == null)
        frontCam = new WebCamTexture();

        GetComponent<Renderer>().material.mainTexture = frontCam;

        if (!frontCam.isPlaying)
        frontCam.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
