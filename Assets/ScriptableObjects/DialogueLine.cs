using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Line", menuName = "Custom Types/Dialogue Line")]
public class DialogueLine : ScriptableObject
{
    public string dialogueText;
    public AudioClip voiceLine;
    public DialogueResponse[] responses;
    public DialogueLine nextLine;
    public List<string> setFlags;
    public List<string> checkFlags;
    public DialogueLine alternateLine;
    public Sprite backgroundImage;
    public List<CharacterInstance> characterInstances;    //Perhaps first character is the one speaking? Empty index means narrator? Separate speaker field? Narrator character?
}