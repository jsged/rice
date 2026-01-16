using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneSwitcherFade : MonoBehaviour
{
    public float delay = 10f;
    public float fadeTime = 1f;
    public CanvasGroup fadeGroup;
    public string nextSceneName = "MainMenu";

    void Start()
    {
        StartCoroutine(Sequence());
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(delay - fadeTime);

        float t = 0f;
        while (t < fadeTime)
        {
            t += Time.deltaTime;
            fadeGroup.alpha = t / fadeTime;
            yield return null;
        }

        SceneManager.LoadScene(nextSceneName);
    }
}
