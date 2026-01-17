using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class DesktopItem : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text label;
    public Image selectionBox;

    float lastClick;
    const float doubleClickDelay = 0.35f;

    void Awake()
    {
        SetSelected(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        DesktopManager.Instance.Select(this);

        if (Time.unscaledTime - lastClick < doubleClickDelay)
        {
            Open();
        }

        lastClick = Time.unscaledTime;
    }

    public void SetSelected(bool selected)
    {
        selectionBox.enabled = selected;
    }

    void Open()
    {
        Debug.Log("Opened: " + label.text);
    }
}
