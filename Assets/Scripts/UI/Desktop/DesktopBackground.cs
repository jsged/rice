using UnityEngine;
using UnityEngine.EventSystems;

public class DesktopBackground : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        DesktopManager.Instance.ClearSelection();
    }
}
