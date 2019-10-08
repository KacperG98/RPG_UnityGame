using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFade : MonoBehaviour
{
    public static UIFade instance;

    public Image fadeScrean;
    public float fadeSpeed;

    public bool shouldFadeToBlack;
    public bool shouldFadeFromBlack;

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }


    void Update()
    {

        if (shouldFadeToBlack)
        {
            fadeScrean.color = new Color(fadeScrean.color.r, fadeScrean.color.g, fadeScrean.color.b, Mathf.MoveTowards(fadeScrean.color.a, 1f, fadeSpeed * Time.deltaTime));

            if (fadeScrean.color.a == 1f)
            {
                shouldFadeToBlack = false;
            }
        }

        if (shouldFadeFromBlack)
        {
            fadeScrean.color = new Color(fadeScrean.color.r, fadeScrean.color.g, fadeScrean.color.b, Mathf.MoveTowards(fadeScrean.color.a, 0f, fadeSpeed * Time.deltaTime));

            if (fadeScrean.color.a == 0f)
            {
                shouldFadeFromBlack = false;
            }
        }
    }

    public void FadeToBlack()
    {
        shouldFadeToBlack = true;
        shouldFadeFromBlack = false;
    }

    public void FadeFromBlack()
    {
        shouldFadeFromBlack = true;
        shouldFadeToBlack = false;
    }
}
