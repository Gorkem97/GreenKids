using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_removal : MonoBehaviour
{
    public AudioSource klick;
    bool isklick = false;
    public AudioSource kalm;
    public LevelCounter geri_sayim;
    public GameObject targetCube;
    public Vector3 cube_start_position;
    public bool icinde_mi;
    private Camera mainCamera;
    private float cameraZdistance;
    Vector3 scaleChange = new Vector3(1.5f, 1.5f, 1.5f);
    bool isbig = false;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        cameraZdistance =
        mainCamera.WorldToScreenPoint(transform.position).z;

        cube_start_position = transform.position;
        icinde_mi = false;
        
    }

    void Update()
    {

    }
    
    private void OnMouseDrag()
    {

        Vector3 ScreenPosition =
            new Vector3(Input.mousePosition.x,Input.mousePosition.y,cameraZdistance-1);
        Vector3 WorldPosition =
            mainCamera.ScreenToWorldPoint(ScreenPosition);
        transform.position = WorldPosition;


        if (isbig == false)
        {
            this.gameObject.transform.localScale += scaleChange;
            isbig = true;
        }
        if (isklick == false)
        {
            klick.Play();
            isklick = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (this.gameObject.tag == "kub1" && other.gameObject.tag == "yer1")
        {
            icinde_mi = true;
            targetCube = other.gameObject;
            
        }
        if (this.gameObject.tag == "kub2" && other.gameObject.tag == "yer2")
        {
            icinde_mi = true;
            targetCube = other.gameObject;
        }
        if (this.gameObject.tag == "kub3" && other.gameObject.tag == "yer3")
        {
            icinde_mi = true;
            targetCube = other.gameObject;
        }
        if (this.gameObject.tag == "kub4" && other.gameObject.tag == "yer4")
        {
            icinde_mi = true;
            targetCube = other.gameObject;

        }
        if (this.gameObject.tag == "kub5" && other.gameObject.tag == "yer5")
        {
            icinde_mi = true;
            targetCube = other.gameObject;
        }
        if (this.gameObject.tag == "kub6" && other.gameObject.tag == "yer6")
        {
            icinde_mi = true;
            targetCube = other.gameObject;
        }
        if (other.gameObject.tag =="targetwatcher")
        {
            geri_sayim = other.gameObject.GetComponent<LevelCounter>();
        }
        if (other.gameObject.tag == "WrongSound")
        {
            kalm = other.gameObject.GetComponent<AudioSource>();
        }
        if (other.gameObject.tag == "klik")
        {
            klick = other.gameObject.GetComponent<AudioSource>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        icinde_mi = false;
    }
    private void OnMouseUp()
    {
        isklick = false;
        this.gameObject.transform.localScale -= scaleChange;
        isbig = false;

        if (icinde_mi == true)
        {
            Vector3 Attaching = targetCube.transform.position;
            Attaching.z -= 1;
            transform.position = Attaching;
            geri_sayim.LevelCounting();
            kalm.Play();
        }
        if (icinde_mi == false)
        {
            transform.position = cube_start_position;
            kalm.Play();
        }
    }
}
