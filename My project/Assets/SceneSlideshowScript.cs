using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSlideshowScript : MonoBehaviour
{
    private static SceneSlideshowScript singleton;

    public static SceneSlideshowScript get()
    {
        return singleton;
    }

    public static SlideData getSlideData()
    {
        return singleton.scenes[singleton.currentSceneName];
    }

    public string currentSceneName;
    public List<SlideData> scenes_list;
    public Dictionary<string, SlideData> scenes;
    
    public void ReloadCurrentScene()
    {
        if (currentSceneName != "")
        {
            SlideData slideData = scenes[currentSceneName];
            if (slideData.subscenes.Count == 0)
            {
                return;
            }
            SceneManager.LoadScene(slideData.subscenes[0]);
            for (int i = 1; i < slideData.subscenes.Count; i++)
            {
                SceneManager.LoadScene(slideData.subscenes[i], LoadSceneMode.Additive);
            }
        }
    }
    public void NextScene(string name){
        currentSceneName = name;
        ReloadCurrentScene();
    }
    
    private void Start()
    {
        DontDestroyOnLoad(this);
        singleton = this;
        scenes = new Dictionary<string, SlideData>();
        foreach (var slide in scenes_list)
        {
            scenes[slide.name] = slide;
        }
        ReloadCurrentScene();
    }
    
}
