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
        if (Display.displays.Length > 1 && SceneManager.GetActiveScene().name == "Guess")
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

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ClearCanvas()
    {
        GameObject[] lines = GameObject.FindGameObjectsWithTag("Line");
        Image mask = GameObject.Find("Mask").GetComponent<Image>();
        
        foreach (var line in lines)
        {
            Destroy(line);
        }

        Sequence flash = DOTween.Sequence();
        flash
            .Append(mask.DOColor(Color.white, 0.1f))
            .Append(mask.DOColor(Color.black, 0.5f));
        flash.Play();

    }
}
