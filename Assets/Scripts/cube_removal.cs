using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_removal : MonoBehaviour
{
    public AudioSource kalm;
    public LevelCounter geri_sayim;
    public GameObject targetCube;
    public Vector3 cube_start_position;
    public bool icinde_mi;
    private Camera mainCamera;
    private float cameraZdistance;
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
            new Vector3(Input.mousePosition.x,Input.mousePosition.y,cameraZdistance);
        Vector3 WorldPosition =
            mainCamera.ScreenToWorldPoint(ScreenPosition);
        transform.position = WorldPosition;
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
        if (other.gameObject.tag =="targetwatcher")
        {
            geri_sayim = other.gameObject.GetComponent<LevelCounter>();
        }
        if (other.gameObject.tag == "WrongSound")
        {
            kalm = other.gameObject.GetComponent<AudioSource>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        icinde_mi = false;
    }
    private void OnMouseUp()
    {
        if (icinde_mi==true)
        {
            transform.position = targetCube.transform.position;
            geri_sayim.LevelCounting();
            kalm.Play();
        }
        if (icinde_mi == false)
        {
            transform.position = cube_start_position;
            kalm.Play();
        }

    }
    IEnumerator secondWait()
    {
        yield return new WaitForSeconds(0.01f);


    }
    public void DisplayMyTarget()
    {

    }

}
