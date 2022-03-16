using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class SahneDuzeni : MonoBehaviour
{

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


    public static bool yardirsinmi;

    public static int kacoldu;
   // public static int nihaipuan = 0;
    public static int puan = 0;
    void Start()
    {

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
            nihaisender += puan;
            SaveData();
            nihaui.text = nihaisender.ToString();
            puan = 0;
        }
        if (SceneManager.GetActiveScene().name == "deney")
        {
            kacoldu -= 1;
        }
        if (eslesmemi == true)
        {
            puan = 10;
        }
        if (coklumu == true)
        {
            puan = 40;
        }
        Debug.Log(kacoldu);
        Debug.Log(puan);
        Debug.Log(nihaisender);
        LanguageIdentifier();

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
            barajhesapla();
            barajui.text = barajpuan.ToString();
            ikincipuanui.text = puan.ToString();
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
    public void LanguageIdentifier()
    {
        if (dil == 0)
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
        }
        if (dil == 1)
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
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

}
