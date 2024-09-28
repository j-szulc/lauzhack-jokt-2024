using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlideDataScript : MonoBehaviour
{
    public SlideData slideDataDefault;

    public SlideData updateSlideData()
    {
        SlideData slideData = SceneSlideshowScript.getSlideData().GetValueOrDefault(slideDataDefault);
        GameObject.Find("Slide").GetComponent<Image>().sprite = slideData.sprite;
        GameObject.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = slideData.text;
        GameObject.Find("EventSystem").GetComponent<Fader>().fadeFrameCount = slideData.fadeFrameCount;
        return slideData;
    }
    
    private void Start()
    {
        SlideData slideData = updateSlideData();
        if (slideData.sceneOverrideName != "")
        {
            SceneManager.LoadScene(slideData.sceneOverrideName, LoadSceneMode.Additive);
        }
    }
    
}
