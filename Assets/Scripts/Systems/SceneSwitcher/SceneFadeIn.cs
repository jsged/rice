using UnityEngine;
using System.Collections;

public class SceneFadeIn : MonoBehaviour
{
    public CanvasGroup fadeGroup;
    public float fadeTime = 1.5f;

    public AudioSource audioSource;
    public AudioClip startupSound;

    void Start()
    {
        if (audioSource != null && startupSound != null)
        {
            audioSource.PlayOneShot(startupSound);
        }

        StartCoroutine(FadeFromBlack());
    }

    IEnumerator FadeFromBlack()
    {
        float t = 0f;

        while (t < fadeTime)
        {
            t += UnityEngine.Time.deltaTime;
            fadeGroup.alpha = 1f - (t / fadeTime);
            yield return null;
        }

        fadeGroup.alpha = 0f;
        fadeGroup.gameObject.SetActive(false);
    }
}
