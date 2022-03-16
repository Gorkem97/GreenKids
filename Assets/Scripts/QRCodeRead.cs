using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ZXing;
using UnityEngine.UI;
using TMPro;

public class QRCodeRead : MonoBehaviour
{
    [SerializeField]
    private RawImage _rawImageBackground;
    [SerializeField]
    private TextMeshProUGUI _textOut;
    [SerializeField]
    private AspectRatioFitter _aspectRatioFitter;
    [SerializeField]
    private RectTransform _scanZone;

    public GameObject Button;


    private bool isCamAvailable = false;
    private WebCamTexture _cameraTexture;

    // Start is called before the first frame update
    void Start()
    {
        Button.SetActive(false);
        SetUpCamera();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCamera();
    }
    public void SetUpCamera()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length == 0)
        {
            isCamAvailable = false;
            return;
        }
        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing == false)
            {
                _cameraTexture = new WebCamTexture(devices[i].name, (int)_scanZone.rect.width, (int)_scanZone.rect.height);

            }
        }

        _cameraTexture.Play();
        _rawImageBackground.texture = _cameraTexture;
        isCamAvailable = true;
    }
    public void Scan()
    {
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(_cameraTexture.GetPixels32(), _cameraTexture.width, _cameraTexture.height);
            if (result!= null)
            {
                _textOut.text = result.Text;
                Button.SetActive(true);
            }
            else
            {
                Button.SetActive(false);
            }
        }
        catch
        {
            Button.SetActive(false);
        }
    }

    private void UpdateCamera()
    {
        if (isCamAvailable == false)
        {
            return;
        }
        float ratio = (float)_cameraTexture.width / (float)_cameraTexture.height;
        _aspectRatioFitter.aspectRatio = ratio;

        int orientation = -_cameraTexture.videoRotationAngle;
        _rawImageBackground.rectTransform.localEulerAngles = new Vector3(0, 0, orientation);
    }
    public void OnClickScan()
    {
        Scan();
    }
    public void GoGoGo()
    {
        if (_textOut.text == "video1")
        {
             Application.OpenURL("");
        }
        if (_textOut.text == "video2")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video3")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video4")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video5")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video6")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video7")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video8")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video9")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video10")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video11")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video12")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video13")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video14")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video15")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video16")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video17")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video18")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video19")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video20")
        {
            Application.OpenURL("");
        }
        if (_textOut.text == "video21")
        {
            Application.OpenURL("https://www.youtube.com/watch?v=7OvW8Z7kiws");
        }
        else
        {
            Application.OpenURL(_textOut.text);
        }
    }
    public void Donmek()
    {
        SceneManager.LoadScene(0);
    }
}
