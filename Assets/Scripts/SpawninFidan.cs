using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawninFidan : MonoBehaviour
{
    public GameObject[] fidanlar = new GameObject[3];
    public int kacfidan = 3;
    public int yol;
    public Vector3 Start_Position = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        FideYeah();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FideYeah()
    {

        List<GameObject> fidanspawn = new List<GameObject>();
        fidanspawn.Add(fidanlar[0]);
        fidanspawn.Add(fidanlar[1]);
        fidanspawn.Add(fidanlar[2]);

        for (int i = 0; i < 3; i++)
        {
            int a = Random.Range(0, kacfidan);
            Instantiate(fidanspawn[a], Start_Position, transform.rotation);
            fidanspawn.Remove(fidanspawn[a]);
            kacfidan -= 1;
            Start_Position.x += yol;
        }
    }
}
