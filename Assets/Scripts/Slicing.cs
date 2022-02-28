using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicing : MonoBehaviour
{
    public GameObject targetCube;
    public Vector3 cube_start_position;
    private Camera mainCamera;
    private float cameraZdistance;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        cameraZdistance =
        mainCamera.WorldToScreenPoint(transform.position).z;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ScreenPosition =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, -4);
        Vector3 WorldPosition =
            mainCamera.ScreenToWorldPoint(ScreenPosition);
        transform.position = WorldPosition;
    }

}
