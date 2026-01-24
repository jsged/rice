using UnityEngine;


public class DesktopManager : MonoBehaviour
{
public static DesktopManager Instance;
DesktopIcon selected;


void Awake()
{
Instance = this;
}


public void SelectIcon(DesktopIcon icon)
{
if (selected != null) selected.SetSelected(false);
selected = icon;
selected.SetSelected(true);
}
}