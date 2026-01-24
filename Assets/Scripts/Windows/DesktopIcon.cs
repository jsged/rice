using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DesktopIcon : MonoBehaviour, IPointerClickHandler
{
    public string windowToOpen;
    public Image iconImage;

    float lastClick;
    const float doubleClickTime = 0.3f;

    void Awake()
    {
        SetSelected(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Time.time - lastClick < doubleClickTime)
        {
            WindowManager.Instance.OpenWindow(windowToOpen);
        }
        else
        {
            DesktopManager.Instance.SelectIcon(this);
        }

        lastClick = Time.time;
    }

    // 🔹 THIS IS WHAT YOUR ERROR IS MISSING
    public void SetSelected(bool selected)
    {
        if (iconImage != null)
            iconImage.color = selected ? Color.cyan : Color.white;
    }
}
