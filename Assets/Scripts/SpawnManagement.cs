using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject[] sayilar = new GameObject[6];
    public GameObject[] yuvalar = new GameObject[6];
    public Vector3 Start_point1 = new Vector3(-5, 10, -5);
    public Vector3 yuva_start_point1 = new Vector3(-5, -5, -4);
    public int ilk_sutun;
    public int ikinci_sutun;
    private int sutunbasi1;
    public int yuva_ilk_sutun;
    public int yuva_ikinci_sutun;
    private int yuva_sutunbasi1;


    public float yol;
    void Start()
    {
        EslesmeSpawner();
    }

    void Update()
    {
    }
    public void EslesmeSpawner()
    {
        yuva_sutunbasi1 = yuva_ilk_sutun + yuva_ikinci_sutun;
        sutunbasi1 = ilk_sutun + ikinci_sutun;


        List<GameObject> dragspawn = new List<GameObject>();
        dragspawn.Add(sayilar[0]);
        dragspawn.Add(sayilar[1]);
        dragspawn.Add(sayilar[2]);
        dragspawn.Add(sayilar[3]);
        dragspawn.Add(sayilar[4]);
        dragspawn.Add(sayilar[5]);

        List<GameObject> yuvaspawn = new List<GameObject>();
        yuvaspawn.Add(yuvalar[0]);
        yuvaspawn.Add(yuvalar[1]);
        yuvaspawn.Add(yuvalar[2]);
        yuvaspawn.Add(yuvalar[3]);
        yuvaspawn.Add(yuvalar[4]);
        yuvaspawn.Add(yuvalar[5]);


        for (int i = 0; i < ilk_sutun + ikinci_sutun; i++)
        {
            if (i == ilk_sutun)
            {
                Start_point1.x -= ilk_sutun * yol;
                Start_point1.y -= yol;
            }
            int a = Random.Range(0, sutunbasi1);
            Instantiate(dragspawn[a], Start_point1, transform.rotation);
            dragspawn.Remove(dragspawn[a]);
            Start_point1.x += yol;
            sutunbasi1 -= 1;
        }
        for (int i = 0; i < yuva_ilk_sutun + yuva_ikinci_sutun; i++)
        {
            if (i == yuva_ilk_sutun)
            {
                yuva_start_point1.x -= ilk_sutun * yol;
                yuva_start_point1.y -= yol;
            }
            int b = Random.Range(0, yuva_sutunbasi1);
            Instantiate(yuvaspawn[b], yuva_start_point1, transform.rotation);
            yuvaspawn.Remove(yuvaspawn[b]);
            yuva_start_point1.x += yol;
            yuva_sutunbasi1 -= 1;
        }
    }
}
