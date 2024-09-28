using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public struct SlideData
{
    public string name;
    public List<string> subscenes;
    public Sprite sprite;
    public string text;
    public int fadeFrameCount;
    public string nextSlide;
}
