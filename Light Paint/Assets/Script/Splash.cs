using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Splash : MonoBehaviour
{
    private Image splash;
    
    // Start is called before the first frame update
    void Start()
    {
        splash = GetComponent<Image>();

        Sequence splashAnim = DOTween.Sequence();
        
        splash.rectTransform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 4f).SetEase(Ease.Linear);

        splashAnim
            .Append(splash.DOFade(0, 0f))
            .Append(splash.DOFade(1, 2))
            .Append(splash.DOFade(0, 2))
            .OnComplete((() => { SceneManager.LoadScene("Menu"); }));

        splashAnim.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
