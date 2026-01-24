using UnityEngine;
using UnityEngine.EventSystems;

public class Window : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public RectTransform titleBar;
    private RectTransform windowRect;
    private Vector2 offset;
    
    private Canvas canvas;

    private void Awake()
    {
        windowRect = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        WindowManager.Instance.FocusWindow(this);

        // Calculate offset for dragging
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            windowRect, eventData.position, eventData.pressEventCamera, out offset);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.pointerPress == titleBar.gameObject || eventData.pointerPress == gameObject)
        {
            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvas.transform as RectTransform, eventData.position, eventData.pressEventCamera, out pos);

            windowRect.localPosition = pos - offset;
        }
    }

    public void CloseWindow()
    {
        gameObject.SetActive(false);
    }
}
