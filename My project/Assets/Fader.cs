using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    public Image image;
    
    public int fadeFrameCount;
    public bool fadeOut;
    
    IEnumerator fade(int direction)
    {
        for (int i = 0; i < fadeFrameCount; i++)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + -direction * (1.0f / fadeFrameCount));
            yield return new WaitForFixedUpdate();
        }
        yield return null;
    }
    
    IEnumerator FadeOut()
    {
        yield return fade(-1);
        yield return null;
    }

    IEnumerator fade()
    {
        yield return fade(1);
    }
    
    private IEnumerator waitForKeyPress()
    {
        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }
        while (!Input.GetKeyUp(KeyCode.Space))
        {
            yield return null;
        }
        SceneSlideshowScript.get().NextScene(SceneSlideshowScript.getSlideData().nextSlide);
    }

    private void Start()
    {
        StartCoroutine("fade", 1);
        StartCoroutine("waitForKeyPress");
    }

    private void FixedUpdate()
    {
        return;
    }
}
