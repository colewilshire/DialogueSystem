using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPortaitController : MonoBehaviour
{
    [SerializeField] private Character character;
    //CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
    Sprite characterImage;
    private Coroutine currentFade;

    private void Awake()
    {
        characterImage = GetComponent<Sprite>();
    }

    private void Start()
    {
        TroupeController.Instance.OnSceneChange += HandleSceneChange;
        //CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
    }

    private void OnDestroy()
    {
        TroupeController.Instance.OnSceneChange -= HandleSceneChange;
    }

    private void HandleSceneChange(List<CharacterInstance> characterInstances)
    {
        foreach(CharacterInstance characterInstance in characterInstances)
        {
            if (characterInstance && characterInstance.character == character)
            {
                ShowCharacter(characterInstance);
                return;
            }
        }

        HideCharacter();
    }

    private void ShowCharacter(CharacterInstance characterInstance)
    {
        SetAttitude("test");
        gameObject.SetActive(true);
        SetFade(characterInstance.fadeTime);
    }

    private void HideCharacter()
    {
        gameObject.SetActive(false);
    }

    private void SetFade(float? fadeTime)
    {
        if (currentFade != null)
        {
            StopCoroutine(currentFade);
        }

        if (!fadeTime.HasValue) return;

        if (fadeTime > 0)
        {
            currentFade = StartCoroutine(FadeIn(fadeTime.Value));
        }
        else if (fadeTime < 0)
        {
            currentFade = StartCoroutine(FadeOut(-fadeTime.Value));
        }
    }

    private IEnumerator FadeIn(float fadeInTime)
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        float startAlpha = 0f;
        float rate = 1.0f / fadeInTime;

        for (float i = 0; i <= 1.0; i += Time.deltaTime * rate)
        {
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 1.0f, i);
            yield return null;
        }

        canvasGroup.alpha = 1.0f;
    }

    private IEnumerator FadeOut(float fadeOutTime)
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        float startAlpha = 1f;
        float rate = 1.0f / fadeOutTime;

        for (float i = 0; i <= 1.0; i += Time.deltaTime * rate)
        {
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 0.0f, i);
            yield return null;
        }

        canvasGroup.alpha = 0.0f;
    }

    private void SetAttitude(string attitude)
    {
        characterImage = character.defaultPose;
    }
}
