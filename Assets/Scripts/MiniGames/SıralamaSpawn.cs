using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SıralamaSpawn : MonoBehaviour
{
    public GameObject[] Elmalar = new GameObject[6];
    public GameObject[] Portakallar = new GameObject[6];
    public int ilk_sutun;
    public int ikinci_sutun;
    private int spawnsayi;
    public int yol;
    public Vector3 ilk_sutun_baslandgic;
    void Start()
    {
        spawnsayi = ilk_sutun + ikinci_sutun;

        List<GameObject> siraylameyve = new List<GameObject>();

        for (int i = 0; i < 6; i++)
        {
            int a = Random.Range(0, 2);
            if (a == 0)
            {
                siraylameyve.Add(Elmalar[i]);
            }
            if (a == 1)
            {
                siraylameyve.Add(Portakallar[i]);
            }
        }

        for (int i = 0; i < ilk_sutun + ikinci_sutun; i++)
        {
            if (i == 0)
            {
                if (ilk_sutun == 2)
                {
                    ilk_sutun_baslandgic.x += yol / 2;
                }
                if (ilk_sutun == 1)
                {
                    ilk_sutun_baslandgic.x += yol;
                }
            }
            if (i == ilk_sutun)
            {
                ilk_sutun_baslandgic.x -= ilk_sutun * yol;
                ilk_sutun_baslandgic.y -= yol;
                if (ilk_sutun == 2)
                {

                    ilk_sutun_baslandgic.x -= yol / 2;
                }
                if (ikinci_sutun == 1)
                {
                    ilk_sutun_baslandgic.x += yol;
                }
                if (ikinci_sutun == 2)
                {
                    ilk_sutun_baslandgic.x += yol / 2;
                }
            }
            int a = Random.Range(0, spawnsayi);
            Instantiate(siraylameyve[a], ilk_sutun_baslandgic, transform.rotation);
            siraylameyve.Remove(siraylameyve[a]);
            ilk_sutun_baslandgic.x += yol;
            spawnsayi -= 1;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
