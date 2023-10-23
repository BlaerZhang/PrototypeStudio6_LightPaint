using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private SpriteRenderer cursor;
    private TrailRenderer trail;
    public FlexibleColorPicker fcp;
    public MouseHoverDetect mhd;
    public Color colorPicked;
    
    // Start is called before the first frame update
    void Start()
    {
        cursor = GetComponent<SpriteRenderer>();
        trail = GetComponent<TrailRenderer>();
        trail.emitting = false;
        cursor.material.color = Color.gray;
        trail.material.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Cursor.visible = false;

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        colorPicked = fcp.color;
        cursor.color = colorPicked;

        if (Input.GetMouseButtonDown(0) && !mhd.IsPointerOverUIElement())
        {
            trail.startColor = colorPicked;
            trail.endColor = colorPicked;

            trail.emitting = true;
            
            cursor.material.DOColor(Color.white, 0.5f);
            trail.material.DOColor(Color.white, 0.5f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            trail.emitting = false;
            
            cursor.material.DOColor(Color.gray, 0.5f);
            trail.material.DOColor(Color.clear, 0.5f);

        }
    }
}
