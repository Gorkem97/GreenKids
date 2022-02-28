using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakasControl : MonoBehaviour
{
    public Slider _slider;
    public AudioSource basari;
    public LevelCounter geri_sayim;
    float a;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        a = _slider.value;
        if (a == 1)
        {
            basari.Play();
            geri_sayim.LevelCounting();
            this.gameObject.SetActive(false);
        }
        Debug.Log(a);
    }
}
