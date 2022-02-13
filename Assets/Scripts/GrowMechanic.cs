using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowMechanic : MonoBehaviour
{
    public GameObject Evre1;
    public GameObject Evre2;
    public GameObject growPartical;

    public int a;
    public int b;
    public int c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = new Vector3(a, b, c);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            a += 10;
            b += 10;
            c += 10;
        }

        if (a == 50)
        {
            growPartical.SetActive(true);
            Evre2.SetActive(true);
            Evre1.SetActive(false);
        }
       
    }
}
