using UnityEngine;
using TMPro;
using System;

public class TaskbarClock : MonoBehaviour
{
    public TMP_Text clockText;
    public bool use24Hour = true;

    void Start()
    {
        UpdateClock();
        InvokeRepeating(nameof(UpdateClock), 0f, 1f);
    }

    void UpdateClock()
    {
        DateTime now = DateTime.Now;

        clockText.text = use24Hour
            ? now.ToString("HH:mm")
            : now.ToString("h:mm tt");
    }
}
