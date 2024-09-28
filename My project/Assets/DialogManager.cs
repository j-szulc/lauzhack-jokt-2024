using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{

    private GameObject cat;
    private GameObject shark;
    private GameObject monkey;
    private int button = -1;
    private GameObject btn_left;
    
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

    public void pressButton(int input)
    {
        button = input;
    }
    private IEnumerator waitForButton()
    {
        while (button == -1)
        {
            yield return null;
        }
    }
    
    public IEnumerator dialog()
    {
        while (true)
        {
            Dat dat = textHandler.queryData(button);
            Debug.Log(dat.RequireChoice);
            button = -1;
            SetText(dat.Text);
            monkey.SetActive(dat.ShowMonkey);
            shark.SetActive(dat.ShowShark);
            cat.SetActive(dat.ShowCat);
            if (dat.RequireChoice)
            {
                btn_left.SetActive(true);
                yield return waitForButton();
                btn_left.SetActive(false);
                Debug.Log(button);
            }
            else
            {
                yield return waitForKeyPress();
            }
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
        btn_left = GameObject.Find("btn_left");
        btn_left.SetActive(false);
        StartCoroutine("dialog");
    }

}
