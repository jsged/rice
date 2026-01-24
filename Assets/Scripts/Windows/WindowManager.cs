using UnityEngine;
using System.Collections.Generic;

public class WindowManager : MonoBehaviour
{
    public static WindowManager Instance;

    public Transform windowParent; // Usually your Canvas
    public List<Window> openWindows = new List<Window>();

    public DesktopIcon selectedIcon;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // Open window by name (assumes prefabs stored in Resources/Windows)
    public void OpenWindow(string windowName)
    {
        Window existing = openWindows.Find(w => w.name == windowName);
        if (existing != null)
        {
            FocusWindow(existing);
            existing.gameObject.SetActive(true);
            return;
        }

        GameObject prefab = Resources.Load<GameObject>("Windows/" + windowName);
        if (prefab == null) { Debug.LogError("Window prefab not found: " + windowName); return; }

        GameObject windowObj = Instantiate(prefab, windowParent);
        windowObj.name = windowName;

        Window windowScript = windowObj.GetComponent<Window>();
        openWindows.Add(windowScript);

        FocusWindow(windowScript);
    }

    public void FocusWindow(Window window)
    {
        window.transform.SetAsLastSibling();

        // Optional: change titlebar color for active window
        foreach (Window w in openWindows)
        {
            if (w == window) w.titleBar.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
            else w.titleBar.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
    }

    public void SelectIcon(DesktopIcon icon)
    {
        if (selectedIcon != null)
        {
            // Reset previous highlight (optional)
            selectedIcon.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }

        selectedIcon = icon;
        selectedIcon.GetComponent<UnityEngine.UI.Image>().color = Color.cyan; // selected highlight
    }
}
