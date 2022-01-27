using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_removal : MonoBehaviour
{
    public LevelCounter geri_sayim;
    public GameObject targetCube;
    public Vector3 target_cube_position;
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
        target_cube_position = targetCube.transform.position;
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
        if (other.gameObject == targetCube)
        {
            icinde_mi = true;
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
            transform.position = target_cube_position;
            geri_sayim.LevelCounting();
        }
        if (icinde_mi == false)
        {
            transform.position = cube_start_position;
        }

    }

}
