using UnityEngine;

public class DialogueController : Singleton<DialogueController>
{
    private DialogueLine currentLine;
    [SerializeField] private DialogueLine defaultLine;

    private void Start()
    {
        PlayDialogue(defaultLine);
    }

    public void PlayDialogue(DialogueLine dialogueLine)
    {
        currentLine = dialogueLine;
        TextController.Instance.SetText(currentLine.dialogueText);
        ResponseController.Instance.DestroyResponses();

        if (!(currentLine.responses.Length > 0)) return;
        ResponseController.Instance.ShowResponses(currentLine.responses);
    }

    public void StepForward()
    {
        if (!currentLine.nextLine) return;
        PlayDialogue(currentLine.nextLine);
    }

    public void StepBackward()
    {
        if (!currentLine.previousLine) return;
        PlayDialogue(currentLine.previousLine);
    }

    public void RepeatLine()
    {
        if (!currentLine) return;
        PlayDialogue(currentLine);
    }
}
