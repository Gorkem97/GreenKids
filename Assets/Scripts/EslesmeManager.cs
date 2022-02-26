using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EslesmeManager : MonoBehaviour
{
    public Text EslesmeGeriSayim;
    public AudioSource Wow;
    public GameObject replayer;
    public GameObject Finisher;
    public GameObject Sayackapat;
    public int eslesingcounter;
    public EslesmeMekanik sayim1;
    public EslesmeMekanik sayim2;
    public EslesmeMekanik sayim3;
    public EslesmeMekanik sayim4;
    public EslesmeMekanik sayim5;
    public EslesmeMekanik sayim6;
    public EslesmeMekanik sayim7;
    public EslesmeMekanik sayim8;
    public LevelCounter LevelRenewer;

    public bool LevelRenewedhmm = false ;

    public int mousecounter = 0;

    public bool[] bitti = new bool[8];

    public int birler =0;
    int ikiler = 0;
    int ucler = 0;
    int dortler = 0;
    int besler = 0;
    int altilar = 0;
    int yediler = 0;
    int sekizler = 0;

    public int oyuncounter = 8;

    // Start is called before the first frame update
    void Start()
    {
        replayer.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        EslesmeGeriSayim.text = eslesingcounter.ToString();


        if (mousecounter == 2)
        {
            eslesingcounter -= 1;
        }
        if (birler == 2 && mousecounter ==2)
        {
            Wow.Play();
            bitti[0] = true;
            oyuncounter -= 1;
        }
        if (ikiler == 2 && mousecounter == 2)
        {
            Wow.Play();
            bitti[1] = true;
            oyuncounter -= 1;
        }
        if (ucler == 2 && mousecounter == 2)
        {
            Wow.Play();
            bitti[2] = true;
            oyuncounter -= 1;
        }
        if (dortler == 2 && mousecounter == 2)
        {
            Wow.Play();
            bitti[3] = true;
            oyuncounter -= 1;
        }
        if (besler == 2 && mousecounter == 2)
        {
            Wow.Play();
            bitti[4] = true;
            oyuncounter -= 1;
        }
        if (altilar == 2 && mousecounter == 2)
        {
            Wow.Play();
            bitti[5] = true;
            oyuncounter -= 1;
        }
        if (yediler == 2 && mousecounter == 2)
        {
            Wow.Play();
            bitti[6] = true;
            oyuncounter -= 1;
        }
        if (sekizler == 2 && mousecounter == 2)
        {
            bitti[7] = true;
            oyuncounter -= 1;
        }
        if (mousecounter == 2)
        {
            mousecounter = 0;
        }
        if (mousecounter ==0)
        {
            birler = 0;
            ikiler = 0;
            ucler = 0;
            dortler = 0;
            besler = 0;
            altilar = 0;
            yediler = 0;
            sekizler = 0;
        }
        if (oyuncounter == 0 && LevelRenewedhmm == false)
        {
            LevelRenewer.AlternateEnd();
            Sayackapat.SetActive(false);
            Finisher.SetActive(true);

            LevelRenewedhmm = true;

            eslesingcounter = 15;
        }
        if (eslesingcounter == 0)
        {
            Sayackapat.SetActive(false);
            replayer.SetActive(true);
        }
    }
    public void BirArttirici()
    {
        birler += 1;
        mousecounter += 1;
    }
    public void IkiArttirici()
    {
        ikiler += 1;
        mousecounter += 1;
    }
    public void UcArttirici()
    {
        ucler += 1;
        mousecounter += 1;
    }
    public void DortArttirici()
    {
        dortler += 1;
        mousecounter += 1;
    }
    public void BesArttirici()
    {
        besler += 1;
        mousecounter += 1;
    }
    public void AltiArttirici()
    {
        altilar += 1;
        mousecounter += 1;
    }
    public void YediArttirici()
    {
        yediler += 1;
        mousecounter += 1;
    }
    public void SekizArttirici()
    {
        sekizler += 1;
        mousecounter += 1;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "esles1")
        {
            sayim1 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
        if (other.gameObject.tag == "esles2")
        {
            sayim2 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
        if (other.gameObject.tag == "esles3")
        {
            sayim3 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
        if (other.gameObject.tag == "esles4")
        {
            sayim4 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
        if (other.gameObject.tag == "esles5")
        {
            sayim5 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
        if (other.gameObject.tag == "esles6")
        {
            sayim6 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
        if (other.gameObject.tag == "esles7")
        {
            sayim7 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
        if (other.gameObject.tag == "esles8")
        {
            sayim8 = other.gameObject.GetComponent<EslesmeMekanik>();
        }
    }
}
