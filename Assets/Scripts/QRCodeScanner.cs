using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QRCodeScanner : MonoBehaviour
{
    

    [SerializeField]
    private RawImage _rawImageBackground;
    [SerializeField]
    private AspectRatioFitter _aspectRatioFitter;
    [SerializeField]
    private TextMeshProUGUI _textOut;
    [SerializeField]
    private RectTransform _scanZone;

    private bool _isCamAvailable;
    private WebCamTexture _cameraTexture;

    private bool scanned = false ;
    public bool found = false;

    void Start()
    {
        SetUpCamera();
    }

    // Update is called once per frame
    void Update()
    {
        if (!scanned)
        UpdateCameraRender();

        
    }

    private void SetUpCamera()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        if(devices.Length == 0)
        {
            _isCamAvailable = false;
            return;
        }

        for (int i = 0; i< devices.Length; i++)
        {
            _cameraTexture = new WebCamTexture(devices[i].name,(int)_scanZone.rect.width,(int)_scanZone.rect.height);
        }

        _cameraTexture.Play();
        _rawImageBackground.texture =_cameraTexture;
        _isCamAvailable = true;

    }
    private void UpdateCameraRender()
    {
        if( _isCamAvailable == false)
        {
            return;
        }
        float ratio = (float)_cameraTexture.width/(float)_cameraTexture.height;
        _aspectRatioFitter.aspectRatio = ratio;
        int orientation = _cameraTexture.videoRotationAngle;
        _rawImageBackground.rectTransform.localEulerAngles = new Vector3(0, -180, 0);
        if (!scanned)

        Scan();


    }
    private void Scan()
    {
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(_cameraTexture.GetPixels32(),_cameraTexture.width,_cameraTexture.height);

            if( result != null)
            {
                SceneController sc = new SceneController();
            
                _textOut.text = result.Text;
                scanned = true;
               
            }
            else
            {
                _textOut.text = "Scanning . . .";
            }
        }
        catch 
        {
            _textOut.text = "Failed in try";
        }

    }

    public void OnClickScan()
    {
        Scan();
    }

   
       public  void OnClickDone()
   {
      if (scanned)
      {
        
       _cameraTexture.Stop();

      
        SceneManager.LoadScene("MainGame");
      
       }
      
       
       
   }
  
}
