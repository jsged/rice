using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class SystemButton : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler
{
    public Outline outline;
    public Shadow shadow;
    public RectTransform label;

    bool latched;

    void Awake()
    {
        SetRaised();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!latched)
            SetPressed();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (!latched)
            SetRaised();
    }

    // Called by StartMenuController
    public void SetLatched(bool value)
    {
        latched = value;

        if (latched)
            SetPressed();
        else
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
