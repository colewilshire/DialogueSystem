using System.Collections.Generic;
using TMPro;

public class NameDisplayController : Singleton<NameDisplayController>
{
    private TextMeshProUGUI textBox;

    protected override void Awake()
    {
        base.Awake();

        textBox = GetComponent<TextMeshProUGUI>();
    }

    public void SetDisplayName(List<CharacterInstance> characterInstances)
    {
        if (characterInstances.Count > 0 && characterInstances[0])
        {
            textBox.text = characterInstances[0].character.name;
        }
        else
        {
            textBox.text = "";
        }
    }
}
