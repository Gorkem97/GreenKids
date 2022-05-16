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
    public GameObject LELELEY;
    public GameObject disclaimer;
    public int isworking = 0;

    private bool isCamAvailable = false;
    private WebCamTexture _cameraTexture;

    // Start is called before the first frame update
    void Start()
    {
        disclaimer.SetActive(false);
        Button.SetActive(false);
        SetUpCamera();
        LELELEY.SetActive(false);
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
            disclaimer.SetActive(true);
            isworking += 1;
        }
        if (_textOut.text == "video2")
        {
            Application.OpenURL("https://youtu.be/h1YHq2Mn64A");
        }
        if (_textOut.text == "video3")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video4")
        {
            Application.OpenURL("https://youtu.be/4S17MjHhuy8");
        }
        if (_textOut.text == "video5")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video6")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video7")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video8")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video9")
        {
            Application.OpenURL("https://youtu.be/y6DOqIR-JaI");
        }
        if (_textOut.text == "video10")
        {
            Application.OpenURL("https://youtu.be/uKAJ5pSz-P8");
        }
        if (_textOut.text == "video11")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video12")
        {
            Application.OpenURL("https://youtu.be/bVoi5v434qE");
        }
        if (_textOut.text == "video13")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video14")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video15")
        {
            Application.OpenURL("https://youtu.be/SlfrBu_pxDY");
        }
        if (_textOut.text == "video16")
        {
            Application.OpenURL("https://youtu.be/RpVrm03VqEo");
        }
        if (_textOut.text == "video17")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video18")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video19")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video20")
        {
            disclaimer.SetActive(true);
        }
        if (_textOut.text == "video21")
        {
            Application.OpenURL("https://www.youtube.com/watch?v=7OvW8Z7kiws");
        }
        if (_textOut.text == "Witcher3"|| _textOut.text == "Witcher 3" || _textOut.text == "witcher3" || _textOut.text == "witcher 3" || _textOut.text == "Viçýr3")
        {
            LELELEY.SetActive(true);
            Application.OpenURL("https://www.youtube.com/watch?v=FiYQMlCBKKc&ab_channel=EnisKirazoglu");
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
