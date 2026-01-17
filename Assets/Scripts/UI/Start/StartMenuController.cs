using UnityEngine;
using UnityEngine.EventSystems;

public class StartMenuController : MonoBehaviour
{
    [Header("References")]
    public GameObject startMenu;
    public SystemButton startButton;

    bool isOpen;

    void Awake()
    {
        startMenu.SetActive(false);
        startButton.SetLatched(false);
    }

    // Called by Start button OnClick
    public void ToggleMenu()
    {
        isOpen = !isOpen;

        startMenu.SetActive(isOpen);
        startButton.SetLatched(isOpen);
    }

    void Update()
    {
        if (!isOpen)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            // If click is NOT over any UI element
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                CloseMenu();
            }
        }
    }

    public void CloseMenu()
    {
        isOpen = false;
        startMenu.SetActive(false);
        startButton.SetLatched(false);
    }
}
