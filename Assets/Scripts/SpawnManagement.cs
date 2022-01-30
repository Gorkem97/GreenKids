using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject[] sayilar = new GameObject[6];
    public GameObject[] yuvalar = new GameObject[6];
    public Vector3 Start_point1 = new Vector3(-5, 8, -5);
    public Vector3 Start_point2 = new Vector3(-5, 2, -5);
    public Vector3 yuva_start_point1 = new Vector3(-5, -8, -4);
    public Vector3 yuva_start_point2 = new Vector3(-5, -15, -4);
    public int ilk_sutun = 3;
    public int ikinci_sutun = 3;
    private int sutunbasi1 = 3;
    private int sutunbasi2 = 3;
    public int yuva_ilk_sutun = 3;
    public int yuva_ikinci_sutun = 3;
    private int yuva_sutunbasi1;
    private int yuva_sutunbasi2;


    public float yol;
    void Start()
    {
        yuva_sutunbasi1 = yuva_ilk_sutun + yuva_ikinci_sutun - 1;
        yuva_sutunbasi2 = yuva_ikinci_sutun - 1;
        sutunbasi1 = ilk_sutun + ikinci_sutun - 1;
        sutunbasi2 = ikinci_sutun - 1;
        List<GameObject> dragspawn = new List<GameObject>();
        dragspawn.Add(sayilar[0]);
        dragspawn.Add(sayilar[1]);
        dragspawn.Add(sayilar[2]);
        dragspawn.Add(sayilar[3]);
        dragspawn.Add(sayilar[4]);
        dragspawn.Add(sayilar[5]);
        for (int i = 0; i < ilk_sutun; i++)
        {
                int a = Random.Range(0, sutunbasi1);
                Instantiate(dragspawn[a], Start_point1, transform.rotation);
                Start_point1.x += yol;
                sutunbasi1 -= 1;
                dragspawn.Remove(dragspawn[a]);
        }
        for (int i = 0; i < ikinci_sutun; i++)
        {
            int b = Random.Range(0, sutunbasi2);
            Instantiate(dragspawn[b], Start_point2, transform.rotation);
            Start_point2.x += yol;
            sutunbasi2 -= 1;
            dragspawn.Remove(dragspawn[b]);
        }

        List<GameObject> yuvaspawn = new List<GameObject>();
        yuvaspawn.Add(yuvalar[0]);
        yuvaspawn.Add(yuvalar[1]);
        yuvaspawn.Add(yuvalar[2]);
        yuvaspawn.Add(yuvalar[3]);
        yuvaspawn.Add(yuvalar[4]);
        yuvaspawn.Add(yuvalar[5]);

        for (int i = 0; i < yuva_ilk_sutun; i++)
        {
            int c = Random.Range(0, yuva_sutunbasi1);
            Instantiate(yuvaspawn[c], yuva_start_point1, transform.rotation);
            yuva_start_point1.x += yol;
            yuva_sutunbasi1 -= 1;
            yuvaspawn.Remove(yuvaspawn[c]);
        }
        for (int i = 0; i < yuva_ikinci_sutun; i++)
        {
            int d = Random.Range(0, yuva_sutunbasi2);
            Instantiate(yuvaspawn[d], yuva_start_point2, transform.rotation);
            yuva_start_point2.x += yol;
            yuva_sutunbasi2 -= 1;
            yuvaspawn.Remove(yuvaspawn[d]);
        }


    }

    void Update()
    {
        
    }
}
