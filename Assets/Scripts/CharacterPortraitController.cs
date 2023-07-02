using UnityEngine;

public class CharacterPortraitController : MonoBehaviour
{
    [SerializeField] Character characterData;

    private void OnEnable()
    {
        SetMood();
        PlayEntranceEffect();
    }

    private void PlayEntranceEffect()
    {
        // Read in arbitrarily long list of effects (slide stage right, shake screen, etc.)

    }

    private void SetMood()
    {
        // Change portrait based on mood enum
    }
}
