using System.Collections.Generic;
using UnityEngine;

public class CharacterPortait : MonoBehaviour
{
    [SerializeField] private Character character;

    private void Start()
    {
        CharacterPortraitController.Instance.OnSceneChange += HandleSceneChange;
    }

    private void OnDestroy()
    {
        CharacterPortraitController.Instance.OnSceneChange -= HandleSceneChange;
    }

    private void HandleSceneChange(List<CharacterInstance> characterInstances)
    {
        foreach(CharacterInstance characterInstance in characterInstances)
        {
            if (characterInstance && characterInstance.character == character)
            {
                ShowCharacter();
                return;
            }
        }

        HideCharacter();
    }

    private void ShowCharacter()
    {
        gameObject.SetActive(true);
    }

    private void HideCharacter()
    {
        gameObject.SetActive(false);
    }
}
