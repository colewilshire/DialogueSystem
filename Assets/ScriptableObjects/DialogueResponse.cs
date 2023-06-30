using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Response", menuName = "Custom Types/Dialogue Response")]
public class DialogueResponse : ScriptableObject
{
    public string responseText;
    public DialogueLine nextLine;
    public string[] checkFlags;
}