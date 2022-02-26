using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EslesmeManager : MonoBehaviour
{
    public EslesmeMekanik sayim1;
    public EslesmeMekanik sayim2;
    public EslesmeMekanik sayim3;
    public EslesmeMekanik sayim4;
    public EslesmeMekanik sayim5;
    public EslesmeMekanik sayim6;
    public EslesmeMekanik sayim7;
    public EslesmeMekanik sayim8;

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

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (birler == 2 && mousecounter ==2)
        {
            bitti[0] = true;
        }
        if (ikiler == 2 && mousecounter == 2)
        {
            bitti[1] = true;
        }
        if (ucler == 2 && mousecounter == 2)
        {
            bitti[2] = true;
        }
        if (dortler == 2 && mousecounter == 2)
        {
            bitti[3] = true;
        }
        if (besler == 2 && mousecounter == 2)
        {
            bitti[4] = true;
        }
        if (altilar == 2 && mousecounter == 2)
        {
            bitti[5] = true;
        }
        if (yediler == 2 && mousecounter == 2)
        {
            bitti[6] = true;
        }
        if (sekizler == 2 && mousecounter == 2)
        {
            bitti[7] = true;
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
