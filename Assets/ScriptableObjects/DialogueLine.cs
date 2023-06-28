using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Line", menuName = "Custom Types/Dialogue Line")]
public class DialogueLine : ScriptableObject
{
    public GameObject character;
    public string dialogueText;
    public AudioClip voiceLine;
    public DialogueResponse[] responses;
    public DialogueLine previousLine;
    public DialogueLine nextLine;
    public string[] setFlags;
}