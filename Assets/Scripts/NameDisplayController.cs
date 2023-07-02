using TMPro;

public class NameDisplayController : Singleton<NameDisplayController>
{
    private TextMeshProUGUI textBox;

    protected override void Awake()
    {
        base.Awake();

        textBox = GetComponent<TextMeshProUGUI>();
    }

    public void SetDisplayName(Character character)
    {
        if (character)
        {
            textBox.text = character.characterName;
        }
        else
        {
            textBox.text = "";
        }
    }
}
