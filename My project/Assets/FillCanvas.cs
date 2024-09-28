using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FillCanvas : MonoBehaviour
{
    public Offset TopOffset;
    public Offset BottomOffset;
    public Offset LeftOffset;
    public Offset RightOffset;

    public Color abc;
    // Start is called before the first frame update
    void fill()
    {
        Canvas parentCanvas = GetComponentInParent<Canvas>();
        RectTransform canvasRectTransform = parentCanvas.GetComponent<RectTransform>();

        float topOffsetPixels = TopOffset.CalculateOffset(canvasRectTransform.rect.height);
        float bottomOffsetPixels = BottomOffset.CalculateOffset(canvasRectTransform.rect.height);
        float leftOffsetPixels = LeftOffset.CalculateOffset(canvasRectTransform.rect.width);
        float rightOffsetPixels = RightOffset.CalculateOffset(canvasRectTransform.rect.width);
        
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.offsetMin = new Vector2(leftOffsetPixels, bottomOffsetPixels);
        rectTransform.offsetMax = new Vector2(-rightOffsetPixels, -topOffsetPixels);
        rectTransform.localScale = Vector3.one;
    }
    
    void Start()
    {
        fill();
    }

    // Update is called once per frame
    void Update()
    {
        fill();
    }
}
