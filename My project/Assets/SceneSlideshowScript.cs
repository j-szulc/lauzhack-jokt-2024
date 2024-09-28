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
    
    private int currentSceneIdx = -1;
    public List<string> sceneOrder;
    
    public void NextScene()
    {
        currentSceneIdx++;
        if (currentSceneIdx < sceneOrder.Count)
        {
            SceneManager.LoadScene(sceneOrder[currentSceneIdx]);
        }
    }
    
    private void Start()
    {
        DontDestroyOnLoad(this);
        NextScene();
    }
    
}
