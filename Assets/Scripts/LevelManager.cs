using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public SahneDuzeni puantoplar;
    bool onceseviyeoldu = false;
    float onceseviye;
    public float puanmanager;
    public float puanbefore;
    public Slider Level;
    public TextMeshProUGUI Seviying;
    public TextMeshProUGUI Seviyeahremain;
    public TextMeshProUGUI levelup;
    public GameObject leveluptab;
    public static int seviye = 1;
    public static bool levelchecker=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puanbefore = (75 * (seviye - 1)) + (25*(seviye-1) * (seviye - 1));
        puanmanager = (75 * seviye) + (25 * seviye * seviye);
        if (puantoplar.nihaisender>=puanmanager)
        {
            if (!onceseviyeoldu)
            {
                onceseviye = seviye;
                onceseviyeoldu = true;
            }
            seviye += 1;
            if (levelchecker)
            {
                leveluptab.SetActive(true);
                levelup.text = onceseviye.ToString() + " >>> " + seviye.ToString();
            }
        }
        if (puantoplar.nihaisender <= puanmanager)
        {
            levelchecker = true;
        }

        Level.value = (puantoplar.nihaisender-puanbefore) / (puanmanager-puanbefore);
        Seviying.text = seviye.ToString();
        Seviyeahremain.text = (puantoplar.nihaisender - puanbefore).ToString() + "/" + (puanmanager - puanbefore).ToString();

    }
    public void puanmanagement()
    {
        puanmanager = seviye*50;
    }
    public void OnceSevidelete()
    {
        onceseviyeoldu = false;

    }
    public void AgacSeviye()
    {
        if (seviye < 5)
        {
            //tree1.SetActive(true)
        }
        if (seviye < 10)
        {

            //tree1.SetActive(false)
            //tree2.SetActive(true)
        }
        if (seviye < 15)
        {
            //tree2.SetActive(false)
            //tree3.SetActive(true)
        }
        if (seviye < 20)
        {
            //tree3.SetActive(false)
            //tree4.SetActive(true)
        }
        if (seviye < 25)
        {
            //tree4.SetActive(false)
            //tree5.SetActive(true)
        }
        if (seviye < 30)
        {
            //tree5.SetActive(false)
            //tree6.SetActive(true)
        }
        if (seviye < 40)
        {
            //tree6.SetActive(false)
            //tree7.SetActive(true)
        }
        if (seviye < 50)
        {
            //tree7.SetActive(false)
            //tree8.SetActive(true)
        }
    }

}
