using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlideDataScript : MonoBehaviour
{

    public static void SetText(string text)
    {
        GameObject.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = text;
    }
    public SlideData updateSlideData()
    {
        SlideData slideData = SceneSlideshowScript.getSlideData();
        GameObject.Find("Slide").GetComponent<Image>().sprite = slideData.sprite;
        SetText(slideData.text);
        GameObject.Find("EventSystem").GetComponent<Fader>().fadeFrameCount = slideData.fadeFrameCount;
        return slideData;
    }

    private void Start()
    {
        updateSlideData();
    }  

}
