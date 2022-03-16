using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaksıDetection : MonoBehaviour
{
    public GameObject adam;
    public LevelCounter geri_sayim;
    public GameObject Sayac;
    public AudioSource SuSesi;
    public bool birmi = false;
    public float birinsayisi = 0;
    bool birbittimi = false;
    bool birlevel = false;
    public bool ikimi = false;
    public float ikininsayisi = 0;
    bool ikibittimi = false;
    bool ikilevel = false;
    public bool ucmu = false ;
    public float ucunsayisi = 0;
    bool ucbittimi = false;
    bool uclevel = false;
    void Start()
    {
        geri_sayim = Sayac.GetComponent<LevelCounter>();
    }

    void Update()
    {
        if (birmi == true && birinsayisi < 3)
        {
            birinsayisi += Time.deltaTime;
        }
        if (birmi == false && birinsayisi < 3)
        {
            birinsayisi = 0;
        }
        if (birinsayisi >= 3)
        {
            Debug.Log("1Done");
            birbittimi = true;
            if (birlevel == false)
            {
                SuSesi.Stop();
                GameObject.Find("fidan1(Clone)").GetComponentInChildren<ParticleSystem>().Play();
                geri_sayim.LevelCounting();
                birlevel = true;
            }
        } 


        if (ikimi == true && ikininsayisi < 3)
        {
            ikininsayisi += Time.deltaTime;
        }
        if (ikimi == false && ikininsayisi < 3)
        {
            ikininsayisi = 0;
        }
        if (ikininsayisi >= 3)
        {
            Debug.Log("2Done");
            ikibittimi = true;
            if (ikilevel == false)
            {
                SuSesi.Stop();
                GameObject.Find("fidan2(Clone)").GetComponentInChildren<ParticleSystem>().Play();
                geri_sayim.LevelCounting();
                ikilevel = true;
            }
        }


        if (ucmu == true && ucunsayisi < 3)
        {
            ucunsayisi += Time.deltaTime;
        }
        if (ucmu == false && ucunsayisi < 3)
        {
            ucunsayisi = 0;
        }
        if (ucunsayisi >= 3)
        {
            Debug.Log("3Done");
            ucbittimi = true;
            if (uclevel == false)
            {
                SuSesi.Stop();
                GameObject.Find("fidan3(Clone)").GetComponentInChildren<ParticleSystem>().Play();
                geri_sayim.LevelCounting();
                uclevel = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yer1")
        {
            birmi = true;
            if (birbittimi!= true)
            {
                SuSesi.Play();
            }
        }
        if (other.gameObject.tag == "yer2" && birbittimi == true)
        {
            ikimi = true;
            if (ikibittimi != true)
            {
                SuSesi.Play();
            }
        }
        if (other.gameObject.tag == "yer3" && ikibittimi == true)
        {
            ucmu = true; if (ucbittimi != true)
            {
                SuSesi.Play();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "yer1")
        {
            SuSesi.Stop();
            birmi = false;
        }
        if (other.gameObject.tag == "yer2")
        {
            ikimi = false;
            SuSesi.Stop();
        }
        if (other.gameObject.tag == "yer3")
        {
            ucmu = false;
            SuSesi.Stop();
        }
    }
}
