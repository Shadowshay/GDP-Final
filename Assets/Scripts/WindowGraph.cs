using System;
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
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;
    private List<GameObject> gameObjectList;

    private void Awake()//Change to some other caller
    {
        graphContainer = transform.Find("Graph_Container").GetComponent<RectTransform>();
        labelTemplateX = graphContainer.Find("Label_Template_X").GetComponent<RectTransform>();
        labelTemplateY = graphContainer.Find("Label_Template_Y").GetComponent<RectTransform>();
        dashTemplateX = graphContainer.Find("Dash_Template_X").GetComponent<RectTransform>();
        dashTemplateY = graphContainer.Find("Dash_Template_Y").GetComponent<RectTransform>();
        gameObjectList = new List<GameObject>();

        ShowGraph(Code.Instance.StockValue, (int _i) => "Day "+ (_i + (-9)), (float _f) => "$" + Mathf.RoundToInt(_f));
    }

    private GameObject CreateCircle(Vector2 anchoredPosition, Sprite dotColor)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = dotColor;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(0.3f, 0.3f);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private void ShowGraph(List<float> valueList, Func<int, string> getAxisLabelX = null, Func<float, string> getAxisLabelY = null)
    {
        if (getAxisLabelX == null)
        {
            getAxisLabelX = delegate (int _i) { return _i.ToString();};
        }
        if (getAxisLabelY == null)
        {
            getAxisLabelY = delegate (float _f) { return Mathf.RoundToInt(_f).ToString(); };
        }

        foreach (GameObject graphObject in gameObjectList)
        {
            Destroy(graphObject);
        }
        gameObjectList.Clear();

        float graphHeight = graphContainer.sizeDelta.y;
        float yMaximum = valueList[0];
        float yMinimum = valueList[0];
        foreach (int value in valueList)
        {
            if (value > yMaximum)
            {
                yMaximum = value;
            }
            if (value < yMinimum)
            {
                yMinimum = value;
            }
        }
        yMaximum = yMaximum + ((yMaximum - yMinimum) * 0.2f);
        yMinimum = yMinimum - ((yMaximum - yMinimum) * 0.2f);

        float xSize = 1.85f;

        GameObject lastCircle = null;
        for (int i = 0; i < valueList.Count; i++)
        {
            float xPosition = 0.0045f + i * xSize;
            float yPosition = ((valueList[i] - yMinimum)/ (yMaximum- yMinimum)) * graphHeight;
            if (i == 0)
            {
                GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition), nullSprite);
                gameObjectList.Add(circleGameObject);
                if (lastCircle != null)
                {
                    GameObject dotConnectionGameObject = CreateDotConnection(lastCircle.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                    gameObjectList.Add(dotConnectionGameObject);
                }
                lastCircle = circleGameObject;
                RectTransform dashX = Instantiate(dashTemplateX);  //CODE TO DRAW THE DASHES
                dashX.SetParent(graphContainer, false);
                dashX.gameObject.SetActive(true);
                dashX.anchoredPosition = new Vector2(xPosition, -0.2f);
                gameObjectList.Add(dashX.gameObject);

                RectTransform labelX = Instantiate(labelTemplateX); //CODE TO DRAW LABELS
                labelX.SetParent(graphContainer, false);
                labelX.gameObject.SetActive(true);
                labelX.anchoredPosition = new Vector2(xPosition, -0.3f);
                labelX.GetComponent<Text>().text = getAxisLabelX(i);
                gameObjectList.Add(labelX.gameObject);
            }
            else if ((valueList[i - 1] < valueList[i]) && i >= 1)
            {
                GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition), upSprite);
                gameObjectList.Add(circleGameObject);
                if (lastCircle != null)
                {
                    GameObject dotConnectionGameObject = CreateDotConnection(lastCircle.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                    gameObjectList.Add(dotConnectionGameObject);
                }
                lastCircle = circleGameObject;
                RectTransform dashX = Instantiate(dashTemplateX);  //CODE TO DRAW THE DASHES
                dashX.SetParent(graphContainer, false);
                dashX.gameObject.SetActive(true);
                dashX.anchoredPosition = new Vector2(xPosition, -0.2f);
                gameObjectList.Add(dashX.gameObject);

                RectTransform labelX = Instantiate(labelTemplateX); //CODE TO DRAW LABELS
                labelX.SetParent(graphContainer, false);
                labelX.gameObject.SetActive(true);
                labelX.anchoredPosition = new Vector2(xPosition, -0.3f);
                labelX.GetComponent<Text>().text = getAxisLabelX(i);
                gameObjectList.Add(labelX.gameObject);
            }
            else if ((valueList[i - 1] > valueList[i]) && i >= 1)
            {
                GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition), downSprite);
                gameObjectList.Add(circleGameObject);
                if (lastCircle != null)
                {
                    GameObject dotConnectionGameObject = CreateDotConnection(lastCircle.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                    gameObjectList.Add(dotConnectionGameObject);
                }
                lastCircle = circleGameObject;
                RectTransform dashX = Instantiate(dashTemplateX);  //CODE TO DRAW THE DASHES
                dashX.SetParent(graphContainer, false);
                dashX.gameObject.SetActive(true);
                dashX.anchoredPosition = new Vector2(xPosition, -0.2f);
                gameObjectList.Add(dashX.gameObject);

                RectTransform labelX = Instantiate(labelTemplateX); //CODE TO DRAW LABELS
                labelX.SetParent(graphContainer, false);
                labelX.gameObject.SetActive(true);
                labelX.anchoredPosition = new Vector2(xPosition, -0.3f);
                labelX.GetComponent<Text>().text = getAxisLabelX(i);
                gameObjectList.Add(labelX.gameObject);
            }
        }
        int seperatorCount = 10; //Code for Y Axis 
        for (int i = 0; i <= seperatorCount; i++) //Code for labels
        {
            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(graphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / seperatorCount;
            labelY.anchoredPosition = new Vector2(-0.5f, normalizedValue * graphHeight);
            labelY.GetComponent<Text>().text = getAxisLabelY(yMinimum  + (normalizedValue * (yMaximum- yMinimum)));
            gameObjectList.Add(labelY.gameObject);

            RectTransform dashY = Instantiate(dashTemplateY);  //CODE TO DRAW THE DASHES
            dashY.SetParent(graphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(-0.3f, normalizedValue * graphHeight);
            gameObjectList.Add(dashY.gameObject);
        }
    }

    private GameObject CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB)
    {
        GameObject connection = new GameObject("dotConnection", typeof(Image));
        connection.transform.SetParent(graphContainer, false);
        connection.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        RectTransform rectTransform = connection.GetComponent<RectTransform>();
        Vector2 direction = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 0.03f);
        rectTransform.anchoredPosition = dotPositionA + direction * distance * .5f;
        float n = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rectTransform.localEulerAngles = new Vector3(0, 0, n);
        return gameObject;
    }
}
