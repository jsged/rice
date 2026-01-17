using UnityEngine;
using UnityEngine.EventSystems;

public class StartMenuController : MonoBehaviour
{
    [Header("References")]
    public GameObject startMenu;
    public RectTransform startMenuRect;

    bool isOpen;

    void Awake()
    {
        if (startMenu != null)
            startMenu.SetActive(false);
    }

    // Call this from the Start button OnClick
    public void ToggleMenu()
    {
        isOpen = !isOpen;
        startMenu.SetActive(isOpen);
    }

    void Update()
    {
        if (!isOpen)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            // Ignore clicks over UI
            if (EventSystem.current != null &&
                EventSystem.current.IsPointerOverGameObject())
                return;

            CloseMenu();
        }
    }

    public void CloseMenu()
    {
        isOpen = false;
        startMenu.SetActive(false);
    }
}
