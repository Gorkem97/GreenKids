using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public SahneDuzeni puantoplar;
    public float puanmanager;
    public float puanbefore;
    public Slider Level;
    public TextMeshProUGUI Seviying;
    public TextMeshProUGUI Seviyeahremain;
    public int seviye = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puanbefore = (50 * (seviye - 1)) + ((seviye-1) * (seviye - 1));
        puanmanager = (50 * seviye) + (seviye * seviye);
        if (puantoplar.nihaisender>=puanmanager)
        {
            seviye += 1;
        }

        Level.value = (puantoplar.nihaisender-puanbefore) / (puanmanager-puanbefore);
        Seviying.text = seviye.ToString();
        Seviyeahremain.text = (puantoplar.nihaisender - puanbefore).ToString() + "/" + (puanmanager - puanbefore).ToString();
        if (puantoplar.nihaisender == 31 || seviye ==31)
        {
            Seviyeahremain.text = (puantoplar.nihaisender - puanbefore).ToString() + "/" + (puanmanager - puanbefore).ToString() + ";)";
        }

    }
    public void puanmanagement()
    {
        puanmanager = seviye*50;
    }
}
