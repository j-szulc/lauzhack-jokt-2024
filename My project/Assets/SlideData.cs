using System;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public struct SlideData
{
    public Sprite sprite;
    public string text;
    public int fadeFrameCount;
    public string sceneOverrideName;
}
