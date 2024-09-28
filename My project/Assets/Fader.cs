using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    public Image image;
    
    public int fadeFrameCount;
    
    IEnumerator fade()
    {
        for (int i = 0; i < fadeFrameCount; i++)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (1.0f / fadeFrameCount));
            Debug.Log(image.color);
            yield return StartCoroutine("WaitForFixedUpdate");
        }
        SceneSlideshowScript.get().NextScene();
        yield return null;
    }
    
    IEnumerator WaitAndFade()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(2);
        StartCoroutine("fade");
        yield return null;
    }

    IEnumerator Start()
    {
        yield return StartCoroutine("WaitAndFade");
    }

    private void Update()
    {
        return;
    }
}
