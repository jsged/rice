using UnityEngine;

public class BootLoader : MonoBehaviour
{
    public RectTransform[] segments;
    public float speed = 200f;
    public float resetX = -60f;
    public float endX = 260f;

    void Update()
    {
        foreach (RectTransform seg in segments)
        {
            seg.anchoredPosition += Vector2.right * speed * Time.deltaTime;

            if (seg.anchoredPosition.x > endX)
            {
                seg.anchoredPosition = new Vector2(resetX, seg.anchoredPosition.y);
            }
        }
    }
}
