using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EslesmeSpawn : MonoBehaviour
{
    public GameObject[] Eslesenbirler = new GameObject[8];
    private GameObject[] Eslesenikiler = new GameObject[8];
    public EslesmeManager eslesing;
    public int ilk_sutun;
    public int ikinci_sutun;
    public int ucuncu_sutun;
    public int dorduncu_sutun;
    private int sutunbasi1;
    public float yol;
    public Vector3 Start_point1 = new Vector3(-5, 10, -5);
    int a = 0;

    bool Spawnem = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnwait());
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawnem == true)
        {
            Sýralama();
            Spawnem = false;
        }
    }

    public void Sýralama()
    {


        Eslesenikiler[0] = Eslesenbirler[0];
        Eslesenikiler[1] = Eslesenbirler[1];
        Eslesenikiler[2] = Eslesenbirler[2];
        Eslesenikiler[3] = Eslesenbirler[3];
        Eslesenikiler[4] = Eslesenbirler[4];
        Eslesenikiler[5] = Eslesenbirler[5];
        Eslesenikiler[6] = Eslesenbirler[6];
        Eslesenikiler[7] = Eslesenbirler[7];


        sutunbasi1 = eslesing.oyuncounter*2;


        List<GameObject> EslesmeSpawn = new List<GameObject>();
        EslesmeSpawn.Add(Eslesenbirler[0]);
        EslesmeSpawn.Add(Eslesenikiler[0]);
        EslesmeSpawn.Add(Eslesenbirler[1]);
        EslesmeSpawn.Add(Eslesenikiler[1]);
        EslesmeSpawn.Add(Eslesenbirler[2]);
        EslesmeSpawn.Add(Eslesenikiler[2]);
        EslesmeSpawn.Add(Eslesenbirler[3]);
        EslesmeSpawn.Add(Eslesenikiler[3]);
        EslesmeSpawn.Add(Eslesenbirler[4]);
        EslesmeSpawn.Add(Eslesenikiler[4]);
        EslesmeSpawn.Add(Eslesenbirler[5]);
        EslesmeSpawn.Add(Eslesenikiler[5]);
        EslesmeSpawn.Add(Eslesenbirler[6]);
        EslesmeSpawn.Add(Eslesenikiler[6]);
        EslesmeSpawn.Add(Eslesenbirler[7]);
        EslesmeSpawn.Add(Eslesenikiler[7]);



        for (int i = 0; i < eslesing.oyuncounter*2; i++)
        {
            if (i == ilk_sutun)
            {
                Start_point1.x -= ilk_sutun * yol;
                Start_point1.y -= yol*1.5f;
            }
            if (i == ilk_sutun + ikinci_sutun)
            {
                Start_point1.x -= ikinci_sutun * yol;
                Start_point1.y -= yol*1.5f;
            }
            if (i == ilk_sutun + ikinci_sutun + ucuncu_sutun)
            {
                Start_point1.x -= ucuncu_sutun * yol;
                Start_point1.y -= yol*1.5f;
            }
            if (i == ilk_sutun + ikinci_sutun + ucuncu_sutun + dorduncu_sutun)
            {
                Start_point1.x -= dorduncu_sutun * yol;
                Start_point1.y -= yol*1.5f;

            }
            int b = Random.Range(0, sutunbasi1);
            Instantiate(EslesmeSpawn[b], Start_point1, transform.rotation);
            EslesmeSpawn.Remove(EslesmeSpawn[b]);
            Start_point1.x += yol;
            sutunbasi1 -= 1;
        }

    }

    IEnumerator Spawnwait()
    {
        yield return new WaitForSeconds(0.1f);
        Spawnem = true;
    }
}
