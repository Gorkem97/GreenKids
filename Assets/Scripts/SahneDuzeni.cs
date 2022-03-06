using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SahneDuzeni : MonoBehaviour
{
    public EslesmeManager EslesmeControl;
    public Text puanui;
    public Text ikincipuanui;
    public Text barajui;
    public Text nihaui;
    public bool yardirsender;
    public int kacoldusender;
    public int barajpuan = 0;
    public bool eslesmemi = false;


    public static bool yardirsinmi;

    public static int kacoldu;
    public static int nihaipuan = 0;
    public static int puan = 0;
    void Start()
    {
        if (SceneManager.GetActiveScene().name != "Main")
        {
            kacoldu += 1;
        }
        if (SceneManager.GetActiveScene().name == "Main")
        {
            yardirsinmi = false;
            kacoldu = 0;
            nihaipuan += puan;
            nihaui.text = nihaipuan.ToString();
            puan = 0;
        }
        yardirsender = yardirsinmi;
        kacoldusender = kacoldu;

        Debug.Log(kacoldu);
        Debug.Log(puan);
        Debug.Log(nihaipuan);

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
            barajui.text = barajpuan.ToString();
            ikincipuanui.text = puan.ToString();
            barajhesapla();
        }
        if (eslesmemi == true)
        {
            puan = 40;
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
            barajpuan = puan;
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
}
