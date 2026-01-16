using UnityEngine;
using TMPro;
using System;

public class TaskbarDate : MonoBehaviour
{
    public TMP_Text dateText;  // Assign your TextMeshPro UI element
    public string dateFormat = "dd/MM/yyyy"; // Customize format

    void Start()
    {
        UpdateDate();
        InvokeRepeating(nameof(UpdateDate), 0f, 60f); // update once per minute
    }

    void UpdateDate()
    {
        DateTime today = DateTime.Today; // Date only, time = 00:00:00
        dateText.text = today.ToString(dateFormat);
    }
}
