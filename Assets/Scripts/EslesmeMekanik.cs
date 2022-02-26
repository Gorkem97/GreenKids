using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EslesmeMekanik : MonoBehaviour
{
    public EslesmeManager eslestirici;
    public AudioSource kilik;
    public AudioSource rong;
    public bool coroutinebasla = false;
    public Collider colieng;
    public GameObject texxX;
    public bool bitis = false;
     public int mousecunt;
    void Start()
    {
        kilik = GameObject.Find("Klik").GetComponent<AudioSource>();
        rong = GameObject.Find("WrongSound").GetComponent<AudioSource>();
        colieng = this.gameObject.GetComponent<Collider>();
        texxX = transform.GetChild(0).gameObject;
        texxX.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "esles1")
        {
            bitis = eslestirici.bitti[0];
        }
        if (this.gameObject.tag == "esles2")
        {
            bitis = eslestirici.bitti[1];
        }
        if (this.gameObject.tag == "esles3")
        {
            bitis = eslestirici.bitti[2];
        }
        if (this.gameObject.tag == "esles4")
        {
            bitis = eslestirici.bitti[3];
        }
        if (this.gameObject.tag == "esles5")
        {
            bitis = eslestirici.bitti[4];
        }
        if (this.gameObject.tag == "esles6")
        {
            bitis = eslestirici.bitti[5];
        }
        if (this.gameObject.tag == "esles7")
        {
            bitis = eslestirici.bitti[6];
        }
        if (this.gameObject.tag == "esles8")
        {
            bitis = eslestirici.bitti[7];
        }


        mousecunt = eslestirici.mousecounter;
        if (mousecunt == 0 && bitis == false)
        {
            colieng.enabled = true;
            if (coroutinebasla == true)
            {
                rong.Play();
                StartCoroutine(SetActiveCounter());
                coroutinebasla = false;
            }
        }

    }
    private void OnMouseDown()
    {
        
        if (this.gameObject.tag == "esles1")
        {
            eslestirici.BirArttirici();
        }
        if (this.gameObject.tag == "esles2")
        {
            eslestirici.IkiArttirici();
        }
        if (this.gameObject.tag == "esles3")
        {
            eslestirici.UcArttirici();
        }
        if (this.gameObject.tag == "esles4")
        {
            eslestirici.DortArttirici();
        }
        if (this.gameObject.tag == "esles5")
        {
            eslestirici.BesArttirici();
        }
        if (this.gameObject.tag == "esles6")
        {
            eslestirici.AltiArttirici();
        }
        if (this.gameObject.tag == "esles7")
        {
            eslestirici.YediArttirici();
        }
        if (this.gameObject.tag == "esles8")
        {
            eslestirici.SekizArttirici();
        }
        if (mousecunt == 0)
        {
            coroutinebasla = true;
            kilik.Play();
        }
        if (mousecunt == 1)
        {
            coroutinebasla = true;
        }
        colieng.enabled = false;
        texxX.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "targetwatcher")
        {
            eslestirici = other.gameObject.GetComponent<EslesmeManager>();
        }
    }
    IEnumerator SetActiveCounter()
    {

        yield return new WaitForSeconds(0.5f);
        texxX.SetActive(false);
    }
}
