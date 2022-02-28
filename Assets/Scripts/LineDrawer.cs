using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{

    public GameObject linePrefab;
    public LayerMask cantDrawOverLayer;
    int cantDrawOverLayerIndex;

    [Space(30f)]
    public Gradient lineColor;
    public float linePointsMinDistance;
    public float lineWidth;

    Line currentLine;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        cantDrawOverLayerIndex = LayerMask.NameToLayer("CantDrawOver");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            BeginDraw ();

        if (currentLine != null)
            Draw ();

        if (Input.GetMouseButtonUp(0))
            endDraw ();
    }


    // Begin Draw -----------------------------
    void BeginDraw()
    {
        currentLine = Instantiate(linePrefab, this.transform).GetComponent<Line>();

        currentLine.UsePhysics(false);
        currentLine.SetLineColor(lineColor);
        currentLine.SetPointsMinDistance(linePointsMinDistance);
        currentLine.SetLineWidth(lineWidth);

    }
    // Draw -----------------------------------
    void Draw()
    {
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.CircleCast(mousePosition, lineWidth / 3f, Vector2.zero, 1f, cantDrawOverLayer);

        if (hit)
            endDraw();
        else
            currentLine.AddPoint(mousePosition);

        
    }
    // End Draw -------------------------------
    void endDraw()
    {
        if (currentLine != null)
        {
            if (currentLine.pointsCount < 2)
            {
                //if line has one point
                Destroy(currentLine.gameObject);
            }

            else
            {
                currentLine.gameObject.layer = cantDrawOverLayerIndex;
                currentLine.UsePhysics(true);
                currentLine = null;
            }
        }
    }


}
