using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class MenuItem : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler
{
    public Image background;
    public TMP_Text label;

    Color normal = new Color(0, 0, 0, 0);
    Color highlight = new Color(0.1f, 0.2f, 0.6f, 1f); // Win2000 blue

    void Awake()
    {
        background.color = normal;
        label.color = Color.black;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        background.color = highlight;
        label.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        background.color = normal;
        label.color = Color.black;
    }
}
