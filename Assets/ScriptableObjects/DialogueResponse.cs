using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Response", menuName = "Custom Types/Dialogue Response")]
public class DialogueResponse : ScriptableObject
{
    public string responseText;
    public DialogueLine nextLine;
    public List<string> checkFlags;
}