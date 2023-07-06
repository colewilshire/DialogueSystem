using System.Collections.Generic;

public class TroupeController : Singleton<TroupeController>
{
    public delegate void OnSceneChangeHandler(List<CharacterInstance> characterInstances);
    public event OnSceneChangeHandler OnSceneChange;

    public void ShowCharacters(List<CharacterInstance> characterInstances)
    {
        OnSceneChange?.Invoke(characterInstances);
    }
}