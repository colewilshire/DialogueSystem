using UnityEngine;
using UnityEngine.UI;

public class ResponseButton : MonoBehaviour
{
    Button button;
    DialogueLine nextLine;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(PlayNextLine);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(PlayNextLine);
    }

    private void PlayNextLine()
    {
        if (!nextLine) return;
        DialogueController.Instance.PlayDialogue(nextLine);
    }

    public void SetLineToPlay(DialogueLine dialogueLine)
    {
        nextLine = dialogueLine;
    }
}
