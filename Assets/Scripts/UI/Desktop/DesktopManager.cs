using UnityEngine;

public class DesktopManager : MonoBehaviour
{
    public static DesktopManager Instance;

    DesktopItem selected;

    void Awake()
    {
        Instance = this;
    }

    public void Select(DesktopItem item)
    {
        if (selected != null)
            selected.SetSelected(false);

        selected = item;
        selected.SetSelected(true);
    }

    public void ClearSelection()
    {
        if (selected != null)
            selected.SetSelected(false);

        selected = null;
    }
}
