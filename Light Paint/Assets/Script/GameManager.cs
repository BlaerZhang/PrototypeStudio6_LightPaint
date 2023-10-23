using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {

    }

    void Start()
    {
        if (Display.displays.Length > 1)
        {
            Display.displays[0].Activate();
            Display.displays[1].Activate();
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void FinishPainting()
    {
        // List<GameObject> lines = GameObject.FindGameObjectsWithTag("Line").ToList();
        // foreach (var line in lines)
        // {
        //     line.GetComponent<LineRenderer>().material.DOColor(Color.white, 2);
        // }

        GameObject.Find("Mask").GetComponent<Image>().DOFade(0, 2);
    }
}
