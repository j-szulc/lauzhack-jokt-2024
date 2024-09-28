using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSlideshowScript : MonoBehaviour
{
    private static SceneSlideshowScript singleton;

    private SceneSlideshowScript()
    {
        singleton = this;
    }

    public static SceneSlideshowScript get()
    {
        return singleton;
    }

    public static SlideData? getSlideData()
    {
        if(singleton is null)
        {
            return null;
        }
        return singleton.scenes[singleton.currentSceneIdx];
    }
    
    private int currentSceneIdx = -1;
    public List<SlideData> scenes;
    
    public void NextScene()
    {
        currentSceneIdx++;
        if (currentSceneIdx < scenes.Count)
        {
            SceneManager.LoadScene("SlideTemplateScene");
        }
    }
    
    private void Start()
    {
        DontDestroyOnLoad(this);
        NextScene();
    }
    
}
