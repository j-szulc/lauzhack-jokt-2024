using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    public Image image;
    
    public int fadeFrameCount;
    
    IEnumerator fade(int direction)
    {
        for (int i = 0; i < fadeFrameCount; i++)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + -direction * (1.0f / fadeFrameCount));
            yield return new WaitForFixedUpdate();
        }
        SceneSlideshowScript.get().NextScene();
        yield return null;
    }
    
    IEnumerator WaitAndFade()
    {
        yield return fade(1);
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(2);
        yield return fade(-1);
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
