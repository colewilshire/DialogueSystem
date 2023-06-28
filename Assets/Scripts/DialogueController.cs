using UnityEngine;

public class DialogueController : Singleton<DialogueController>
{
    private string[] exampleDialogue =
    {
        "Hello, world!",
        "The sun is shining brightly and the birds are chirping.",
        "Smog covers the sun and the trees are dying.",
        "The world is ending.",
        "Goodbye, world."
    };
    private string[] openDialogue;
    private int currentLine = 0;

    private void Start()
    {
        BeginDialogue(exampleDialogue);
    }

    private void LoadDialogue()//string[] dialogue)
    {
        //Speaking character [enum? string?]
        //Emotion/Appearance [enum? string?]
        //Line [string]
        //Audio clip
        //Stage left, right, center
        //Fade in/out type

        //Dog: <Left> [Angry] "Ruff ruff ruff!"
    }

    private void BeginDialogue(string[] dialogue)
    {
        openDialogue = dialogue;
        currentLine = 0;
    
        RepeatLine();
    }

    private void AdvanceDialogue(int steps)
    {
        int newLineIndex = currentLine + steps;
        
        if (newLineIndex >= 0 && newLineIndex < openDialogue.Length)
        {
            Debug.Log(steps);
            currentLine = newLineIndex;
            TextController.Instance.SetText(openDialogue[currentLine]);
        }
    }

    public void StepForward()
    {
        AdvanceDialogue(1);
    }

    public void StepBackward()
    {
        AdvanceDialogue(-1);
    }

    public void RepeatLine()
    {
        AdvanceDialogue(0);
    }
}
