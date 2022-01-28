using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject[] sayilar = new GameObject[3];
    public GameObject[] yuvalar = new GameObject[3];
    public Vector3 Start_point = new Vector3(-5, 4, -5);
    public Vector3 yuva_start_point = new Vector3(-5, -8, -5);
    public int kacsayi = 3;
    public float yol;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(yuvalar[0], yuva_start_point, transform.rotation);
        yuva_start_point.x += yol;
        Instantiate(yuvalar[1], yuva_start_point, transform.rotation);
        yuva_start_point.x += yol;
        Instantiate(yuvalar[2], yuva_start_point, transform.rotation);
        yuva_start_point.x += yol;
        int a = Random.Range(0, 5);
            if (a==0)
            {
                Instantiate(sayilar[0], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[1], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[2], Start_point, transform.rotation);
                Start_point.x += yol;
            }

            if (a == 1)
            {
                Instantiate(sayilar[0], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[2], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[1], Start_point, transform.rotation);
                Start_point.x += yol;
            }

            if (a == 2)
            {
                Instantiate(sayilar[1], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[0], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[2], Start_point, transform.rotation);
                Start_point.x += yol;
            }

            if (a == 3)
            {
                Instantiate(sayilar[1], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[2], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[0], Start_point, transform.rotation);
                Start_point.x += yol;
            }

            if (a == 4)
            {
                Instantiate(sayilar[2], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[0], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[1], Start_point, transform.rotation);
                Start_point.x += yol;
            }

            if (a == 5)
            {
                Instantiate(sayilar[2], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[1], Start_point, transform.rotation);
                Start_point.x += yol;
                Instantiate(sayilar[0], Start_point, transform.rotation);
                Start_point.x += yol;
            }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
