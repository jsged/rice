using UnityEngine;
using System.Collections;

public class SceneFadeIn : MonoBehaviour
{
    public CanvasGroup fadeGroup;
    public float fadeTime = 1.5f;

    void Start()
    {
        StartCoroutine(FadeFromBlack());
    }

    IEnumerator FadeFromBlack()
    {
        float t = 0f;

        while (t < fadeTime)
        {
            t += Time.deltaTime;
            fadeGroup.alpha = 1f - (t / fadeTime);
            yield return null;
        }

        fadeGroup.alpha = 0f;
        fadeGroup.gameObject.SetActive(false);
    }
}
