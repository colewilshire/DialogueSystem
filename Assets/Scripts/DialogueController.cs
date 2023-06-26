using UnityEngine;

public class DialogueController : Singleton<DialogueController>
{
    private string[] exampleDialogue =
    {
        "Hello, world!",
        "Goodbye, world."
    };
    private string[] openDialogue;
    private int currentLine = 0;

    private void Start()
    {
        BeginDialogue(exampleDialogue);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StepForward();
        }
        else if(Input.GetMouseButtonDown(1))
        {
            StepBackward();
        }
    }

    private void BeginDialogue(string[] dialogue)
    {
        openDialogue = dialogue;
        currentLine = 0;
    
        RepeatLine();
    }

    private void AdvanceDialogue(int steps)
    {
        currentLine = currentLine + steps;
        TextController.Instance.SetText(openDialogue[currentLine]);
    }

    private void StepForward()
    {
        AdvanceDialogue(1);
    }

    private void StepBackward()
    {
        AdvanceDialogue(-1);
    }

    private void RepeatLine()
    {
        AdvanceDialogue(0);
    }
}
