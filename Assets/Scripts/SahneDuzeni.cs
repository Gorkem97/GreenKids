using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Advertisements;

public class SahneDuzeni : MonoBehaviour
{

#if UNITY_IOS
    string gameId = "4664847";
#else
    string gameId = "4664846";
#endif

    bool barajkapa = false;

    public EslesmeManager EslesmeControl;
    public Text puanui;
    public Text ikincipuanui;
    public Text barajui;
    public Text nihaui;
    public bool yardirsender;
    public int kacoldusender;
    public int nihaisender ;
    public int dil = 0;
    public int barajpuan = 0;
    public bool eslesmemi = false;
    public bool coklumu = false;

    private static bool dilsecildimi = false;


    public static bool yardirsinmi;
    public static int adcounter = -1;
    public static int kacoldu;
    public static int puan = 0;
    void Start()
    {
        Advertisement.Initialize(gameId);


        if (!File.Exists(Application.persistentDataPath + "/sahnecim.puantik"))
        {
            English();
            SaveData();
        }
        kacoldusender = kacoldu;
        if (SceneManager.GetActiveScene().name != "Main")
        {
            kacoldu += 1;
            
        }
        if (SceneManager.GetActiveScene().name == "Main")
        {
            LoadData();
            yardirsinmi = false;
            kacoldu = 0;
            SelectLanguage();
            nihaisender += puan;
            SaveData();
            puan = 0;
            adcounter += 1;
            if (adcounter >= 3)
            {
                PlayAd();
                adcounter = 0;
            }
        }
        if (SceneManager.GetActiveScene().name == "deney")
        {
            kacoldu -= 1;
        }
        if (eslesmemi == true)
        {
            puan = 20;
        }
        if (coklumu == true)
        {
            puan = 50;
        }
        if (yardirsinmi == true)
        {
            adcounter += 1;
            if (adcounter >= 4)
            {
                PlayAd();
                adcounter = 0;
            }
        }
        Debug.Log(kacoldu);
        Debug.Log(puan);
        Debug.Log(nihaisender);

    }
    void Update()
    {
        
        yardirsender = yardirsinmi;
        kacoldusender = kacoldu;
        if (SceneManager.GetActiveScene().name != "Main")
        {
            puanui.text = puan.ToString();
        }
        if (yardirsinmi == true)
        {
            if (barajkapa == false)
            {
                barajhesapla();
            }
            barajui.text = barajpuan.ToString();
            ikincipuanui.text = puan.ToString();
        }
        if (dilsecildimi == false)
        {
            SelectLanguage();
            dilsecildimi = true;
        }

    }
    public void ContinueHafiza()
    {
        int katsayi = EslesmeControl.eslesingcounter + 1;
        puan += kacoldusender * 2 * katsayi;
        
    }
    public void yardirmibasla()
    {
        yardirsinmi = true;
    }
    public void barajhesapla()
    {
        if (puan <20 && puan <=0)
        {
            barajpuan = 0;
        }
        if (puan >= 20 && puan < 60)
        {
            barajpuan = 10;
        }
        if (puan >= 60 && puan < 100)
        {
            barajpuan = 50;
        }
        if (puan >= 100 && puan < 150)
        {
            barajpuan = 80;
        }
        if (puan >= 150)
        {
            barajpuan = 120;
        }
    }
    public void kacolduartir()
    {
        kacoldu += 1;
    }
    public void Defeat()
    {
        puan = barajpuan;
        kacoldu = 0;
        barajkapa = true;
    }
    public void don()
    {
        puan = 0;
    }

    public void English()
    {
        dil = 0; 
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
        SaveData();
    }
    public void Turkish()
    {
        dil = 1;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
        SaveData();
    }
    void SelectLanguage()
    {
        if (dil== 0)
        {
            English();
        }
        if (dil == 1)
        {
            Turkish();
        }
    }

    public void SaveData()
    {
        SaveKeep.SavePuan(this);
    }
    public  void LoadData()
    {
        SaveSystem data = SaveKeep.loadsave();
        nihaisender = data.tumpuan;
        dil = data.diling;
    }

    public void PlayAd()
    {
        if (Advertisement.IsReady("First"))
        {
            Advertisement.Show("First");
        }
    }

}
