using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{

    [SerializeField] private PXStrax strax;
    // [SerializeField] private PXFemme femme;
    [SerializeField] private float midiNote = 100.0f;
    public MouseHoverDetect mhd;

    void ReadInput() 
    {
        if (Input.GetMouseButton(0) && !mhd.IsPointerOverUIElement()) 
        {
            strax.KeyOn(midiNote);
            // femme.KeyOn(midiNote);
        }
        // if (Input.GetKeyDown(KeyCode.UpArrow)) 
        // {
        //     midiNote += 10.0f;
        // }
        // if (Input.GetKeyDown(KeyCode.DownArrow))
        // {
        //     midiNote -= 10.0f;
        // }
        if (Input.GetMouseButton(0) && !mhd.IsPointerOverUIElement())
        {
            strax.sustain = true;
            // femme.sustain = true;
        }
        if (Input.GetMouseButtonUp(0)) 
        {
            strax.sustain = false;
            strax.KeyOff();
            // femme.sustain = false;
            // femme.KeyOff();
        }

    }

    private void Update()
    {
        ReadInput();
    }
}
