using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowGraph : MonoBehaviour
{
    [SerializeField] private Sprite downSprite;
    [SerializeField] private Sprite upSprite;
    [SerializeField] private Sprite nullSprite;
    private RectTransform graphContainer;

    private void Awake()//Change to some other caller
    {
        graphContainer = transform.Find("Graph_Container").GetComponent<RectTransform>();

        List<int> valueList = new List<int>() { 5, 20, 50, 45, 30, 60, 90, 70, 60, 10 };
        ShowGraph(valueList);

    }

    private GameObject CreateCircle(Vector2 anchoredPosition, Sprite dotColor)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = dotColor;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(13, 13);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private void ShowGraph(List<int> valueList)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float yMaximum = 100f;
        float xSize = 50f;

        GameObject lastCircle = null;
        for (int i = 0; i < valueList.Count; i++)
        {
            float xPosition = 10f + i * xSize;
            float yPosition = (valueList[i] / yMaximum) * graphHeight;
            if (i == 0)
            {
                GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition),nullSprite);
                if (lastCircle != null)
                {
                    CreateDotConnection(lastCircle.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                }
                lastCircle = circleGameObject;
            }
            else if ((valueList[i-1] < valueList[i]) && i >= 1) 
            {
                GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition), upSprite);
                if (lastCircle != null)
                {
                    CreateDotConnection(lastCircle.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                }
                lastCircle = circleGameObject;
            }
            else if ((valueList[i - 1] > valueList[i]) && i >= 1)
            {
                GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition),downSprite);
                if (lastCircle != null)
                {
                    CreateDotConnection(lastCircle.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                }
                lastCircle = circleGameObject;
            } 
            
            
        }
    }

    private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject connection = new GameObject("dotConnection", typeof(Image));
        connection.transform.SetParent(graphContainer, false);
        connection.GetComponent<Image>().color = new Color(1,1,1,.5f);
        RectTransform rectTransform = connection.GetComponent<RectTransform>();
        Vector2 direction = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 3f);
        rectTransform.anchoredPosition = dotPositionA + direction * distance * .5f;
        float n = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rectTransform.localEulerAngles = new Vector3(0, 0, n);
        
    }


   

}
