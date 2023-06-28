using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Response", menuName = "Custom Types/Dialogue Response")]
public class DialogueResponse : ScriptableObject
{
    public string responseText;
    public AudioClip voiceLine;
    public DialogueLine previousLine;
    public DialogueLine nextLine;
    public string[] checkFlags;
    public string[] setFlags;
}