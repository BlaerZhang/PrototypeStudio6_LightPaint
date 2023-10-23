using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
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
        SceneManager.LoadScene("Zen");
    }

    public void ToDrawNGuess()
    {
        // if (Display.displays.Length > 1)
        {
            SceneManager.LoadScene("Guess");
        }
        // else
        {
            //Requires 2 screens to play
        }
    }
}
