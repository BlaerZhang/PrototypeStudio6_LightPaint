using System;
using UnityEngine;
using System.Collections;

public class ClickDrawer : MonoBehaviour
{
    Coroutine drawing;
    public GameObject line;
    public FlexibleColorPicker fcp;
    private MouseHoverDetect mhd;
    public Color colorPicked;

    private void Start()
    {
        mhd = GetComponent<MouseHoverDetect>();
    }

    void Update()
    {
        colorPicked = fcp.color;
        
        if (Input.GetMouseButtonDown(0) && !mhd.IsPointerOverUIElement())
        {
            StartLine();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }
    }

    void StartLine()
    {
        if (drawing != null)
        {
            StopCoroutine(drawing);
        }
        drawing = StartCoroutine(DrawLine());
    }

    void FinishLine()
    {
        if (drawing != null)
        {
            StopCoroutine(drawing);
        }
    }

    IEnumerator DrawLine()
    {
        GameObject lineObject = Instantiate(this.line, new Vector3(0, 0, 0), Quaternion.identity);
        LineRenderer line = lineObject.GetComponent<LineRenderer>();
        line.startColor = colorPicked;
        line.endColor = colorPicked;
        line.positionCount = 0;

        while (true)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, position);
            yield return null;
        }
    }
}