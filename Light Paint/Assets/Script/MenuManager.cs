using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Image mask = GameObject.Find("Mask").GetComponent<Image>();
        mask.DOFade(0, 1f);

        UnityEngine.Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ToZen()
    {
        Image mask = GameObject.Find("Mask").GetComponent<Image>();
        mask.DOFade(1, 1f).OnComplete((() => { SceneManager.LoadScene("Zen"); }));
    }

    public void ToDrawNGuess(TextMeshProUGUI warningText)
    {
        if (Display.displays.Length > 1)
        {
            warningText.enabled = false;
            Image mask = GameObject.Find("Mask").GetComponent<Image>();
            mask.DOFade(1, 1f).OnComplete((() => { SceneManager.LoadScene("Guess"); }));
        }
        else
        {
            warningText.enabled = true;
            warningText.DOFade(0, 0);
            warningText.DOFade(1, 1f);
        }
    }

    public void Exit()
    {
        Image mask = GameObject.Find("Mask").GetComponent<Image>();
        mask.DOFade(1, 1f).OnComplete((() => { Application.Quit(); }));
    }
}
