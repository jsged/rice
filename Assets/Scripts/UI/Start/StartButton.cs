using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler
{
    public Outline outline;
    public Shadow shadow;
    public RectTransform label;

    void Awake()
    {
        SetRaised();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SetPressed();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SetRaised();
    }

    void SetPressed()
    {
        outline.effectDistance = new Vector2(1, -1);
        shadow.effectDistance = new Vector2(-1, 1);
        label.anchoredPosition = new Vector2(2, -2);
    }

    void SetRaised()
    {
        outline.effectDistance = new Vector2(-1, 1);
        shadow.effectDistance = new Vector2(1, -1);
        label.anchoredPosition = new Vector2(1, -1);
    }
}
