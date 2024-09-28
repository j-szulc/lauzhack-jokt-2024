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
    private GameObject btn_right;
    
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
        while (!Input.GetKeyUp(KeyCode.Space))
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
            SetText(dat.Text);
            monkey.SetActive(dat.ShowMonkey);
            shark.SetActive(dat.ShowShark);
            cat.SetActive(dat.ShowCat);
            if (dat.RequireChoice)
            {
                btn_left.SetActive(true);
                btn_right.SetActive(true);
                button = -1;
                yield return waitForButton();
                btn_left.SetActive(false);
                btn_right.SetActive(false);
                Debug.Log(button);
            }
            else
            {
                yield return waitForKeyPress();
            }
            if (dat.FinalMessage)
            {
                if (button == 0)
                {
                    SceneSlideshowScript.get().NextScene("end_monkey1");
                }
                else if (button == 1)
                {
                    SceneSlideshowScript.get().NextScene("end_shark1");
                }
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
        btn_right = GameObject.Find("btn_right");
        btn_right.SetActive(false);
        StartCoroutine("dialog");
    }

}
