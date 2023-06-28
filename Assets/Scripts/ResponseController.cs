using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class ResponseController : Singleton<ResponseController>
{
    [SerializeField] private GameObject buttonPrefab;
    private List<GameObject> activeButtons = new List<GameObject>();

    public void ShowResponses(DialogueResponse[] responses)
    {
        foreach (DialogueResponse response in responses)
        {
            GameObject button = Instantiate(buttonPrefab, transform);
            TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

            buttonText.text = response.responseText;
            activeButtons.Add(button);
            button.GetComponent<ResponseButton>().SetLineToPlay(response.nextLine);
        }
    }

    public void DestroyResponses()
    {
        if (!(activeButtons.Count > 0)) return;

        foreach (GameObject button in activeButtons)
        {
            Destroy(button);
        }

        activeButtons.Clear();
    }
}
