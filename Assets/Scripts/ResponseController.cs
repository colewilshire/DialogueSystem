using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResponseController : Singleton<ResponseController>
{
    [SerializeField] private GameObject buttonPrefab;
    private string[] testResponses =
    {
        "string1",
        "string2",
        "string3",
        "string4",
        "string5",
        "string6",
        "string7",
        "string8",
        "string9"
    };

    void Start()
    {
        GenerateResponses(testResponses);
    }

    private void GenerateResponses(string[] responses)
    {
        foreach (string response in responses)
        {
            GameObject button = Instantiate(buttonPrefab, transform);
            TextMeshProUGUI textMesh = button.GetComponentInChildren<TextMeshProUGUI>();

            if (textMesh != null)
            {
                textMesh.text = response;
            }

            button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(response));
        }
    }

    void OnButtonClick(string label)
    {
        Debug.Log($"Button with label '{label}' was clicked");
    }
}
