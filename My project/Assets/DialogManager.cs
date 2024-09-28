using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{

    private GameObject cat;
    private GameObject shark;
    private GameObject monkey;
    
    public TextHandler textHandler;
    
    public static void SetText(string text)
    {
        GameObject.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = text;
    }
    
    private IEnumerator waitForKeyPress()
    {
        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }
    }
    
    public IEnumerator dialog()
    {
        while (true)
        {
            Dat dat = textHandler.queryData(0);
            SetText(dat.Text);
            monkey.SetActive(dat.ShowMonkey);
            shark.SetActive(dat.ShowShark);
            cat.SetActive(dat.ShowCat);
            yield return waitForKeyPress();
            if (dat.FinalMessage)
            {
                break;
            }
        }

        string nextScene = SceneSlideshowScript.getSlideData().nextSlide;
        SceneSlideshowScript.get().NextScene(nextScene);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        cat = GameObject.Find("cat");
        monkey = GameObject.Find("monkey");
        shark = GameObject.Find("shark");
        StartCoroutine("dialog");
    }

}
