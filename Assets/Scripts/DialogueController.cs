using UnityEngine;

public class DialogueController : Singleton<DialogueController>
{
    private DialogueLine currentLine;
    [SerializeField] private DialogueLine defaultLine;
    [SerializeField] private bool isVoiceActingEnabled = true;

    private void Start()
    {
        PlayDialogue(defaultLine);
    }

    public void PlayDialogue(DialogueLine dialogueLine, bool isRewinding = false)
    {
        if (isRewinding && currentLine.setFlags.Length > 0)
        {
            FlagController.Instance.ToggleFlags(currentLine.setFlags, !isRewinding);
        }
        
        currentLine = dialogueLine;
        TextController.Instance.SetText(currentLine.dialogueText);
        ResponseController.Instance.DestroyResponses();

        if (isVoiceActingEnabled && currentLine.voiceLine)
        {
            AudioController.Instance.PlaySound(currentLine.voiceLine);
        }

        if (currentLine.responses.Length > 0)
        {
            ResponseController.Instance.ShowResponses(currentLine.responses);
        }

        if (!isRewinding && currentLine.setFlags.Length > 0)
        {
            FlagController.Instance.ToggleFlags(currentLine.setFlags, !isRewinding);
        }
    }

    public void StepForward()
    {
        if (!currentLine.nextLine) return;
        PlayDialogue(currentLine.nextLine);
    }

    public void StepBackward()
    {
        if (!currentLine.previousLine) return;
        PlayDialogue(currentLine.previousLine, true);
    }

    public void RepeatLine()
    {
        if (!currentLine) return;
        PlayDialogue(currentLine);
    }
}
