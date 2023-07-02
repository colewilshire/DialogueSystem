using System.Collections.Generic;
using UnityEngine;

public class DialogueController : Singleton<DialogueController>
{
    [SerializeField] private DialogueLine defaultLine;
    public List<DialogueLine> DialoguePath { get; private set; }

    private void Start()
    {
        StartDialogue();
    }

    public void StartDialogue()
    {
        SaveData saveData = SaveController.Instance.Load("quicksave");
        DialogueLine currentLine = defaultLine;

        if (saveData)
        {
            Debug.Log("Loading game.");
            DialoguePath = saveData.dialoguePath;
            currentLine = DialoguePath[DialoguePath.Count - 1];
            FlagController.Instance.LoadFlags(saveData.activeFlags);
        }
        else
        {
            Debug.Log("Starting new game.");
            DialoguePath = new List<DialogueLine>();
        }

        JumpToLine(currentLine);
    }

    private void ReadDialogueLine()
    {
        DialogueLine currentLine = DialoguePath[DialoguePath.Count - 1];

        TextController.Instance.SetText(currentLine.dialogueText);
        AudioController.Instance.PlaySound(currentLine.voiceLine);

        ResponseController.Instance.DestroyResponses();
        ResponseController.Instance.ShowResponses(currentLine.responses);
    }

    public void JumpToLine(DialogueLine dialogueLine)
    {
        if(dialogueLine.checkFlags.Count > 0 && dialogueLine.alternateLine)
        {
            if (!(FlagController.Instance.CheckForFlags(dialogueLine.checkFlags)))
            {
                JumpToLine(dialogueLine.alternateLine);
                return;
            }
        }

        DialoguePath.Add(dialogueLine);

        FlagController.Instance.ToggleFlags(dialogueLine.setFlags, true);
        ReadDialogueLine();
    }

    public void StepForward()
    {
        if (!(DialoguePath.Count > 0)) return;
        DialogueLine currentLine = DialoguePath[DialoguePath.Count - 1];

        if (!currentLine.nextLine) return;
        JumpToLine(currentLine.nextLine);
    }

    public void StepBackward()
    {
        if (!(DialoguePath.Count > 1)) return;
        DialogueLine currentLine = DialoguePath[DialoguePath.Count - 1];

        DialoguePath.RemoveAt(DialoguePath.Count - 1);
    
        FlagController.Instance.ToggleFlags(currentLine.setFlags, false);
        ReadDialogueLine();
    }

    public void RepeatLine()
    {
        if (!(DialoguePath.Count > 0)) return;
        DialogueLine currentLine = DialoguePath[DialoguePath.Count - 1];

        ReadDialogueLine();
    }
}
