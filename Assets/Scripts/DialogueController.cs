using System.Collections.Generic;
using UnityEngine;

public class DialogueController : Singleton<DialogueController>
{
    [SerializeField] private DialogueLine defaultLine;
    private List<DialogueLine> dialoguePath;

    private void Start()
    {
        StartDialogue();
    }

    private void StartDialogue()
    {
        dialoguePath = new List<DialogueLine>();

        JumpToLine(defaultLine);
    }

    private void ReadDialogueLine()
    {
        DialogueLine currentLine = dialoguePath[dialoguePath.Count - 1];

        TextController.Instance.SetText(currentLine.dialogueText);
        AudioController.Instance.PlaySound(currentLine.voiceLine);

        ResponseController.Instance.DestroyResponses();
        ResponseController.Instance.ShowResponses(currentLine.responses);
    }

    public void JumpToLine(DialogueLine dialogueLine)
    {
        dialoguePath.Add(dialogueLine);

        ReadDialogueLine();
        FlagController.Instance.ToggleFlags(dialogueLine.setFlags, true);
    }

    public void StepForward()
    {
        if (!(dialoguePath.Count > 0)) return;
        DialogueLine currentLine = dialoguePath[dialoguePath.Count - 1];

        if (!currentLine.nextLine) return;
        JumpToLine(currentLine.nextLine);
    }

    public void StepBackward()
    {
        if (!(dialoguePath.Count > 1)) return;
        DialogueLine currentLine = dialoguePath[dialoguePath.Count - 1];

        dialoguePath.RemoveAt(dialoguePath.Count - 1);
    
        ReadDialogueLine();
        FlagController.Instance.ToggleFlags(currentLine.setFlags, false);
    }

    public void RepeatLine()
    {
        if (!(dialoguePath.Count > 0)) return;
        DialogueLine currentLine = dialoguePath[dialoguePath.Count - 1];

        ReadDialogueLine();
    }
}
