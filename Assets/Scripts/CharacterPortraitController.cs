using System.Collections.Generic;

public class CharacterPortraitController : Singleton<CharacterPortraitController>
{
    public delegate void OnSceneChangeHandler(List<CharacterInstance> characterInstances);
    public event OnSceneChangeHandler OnSceneChange;

    public void ShowCharacters(List<CharacterInstance> characterInstances)
    {
        OnSceneChange?.Invoke(characterInstances);
    }
}