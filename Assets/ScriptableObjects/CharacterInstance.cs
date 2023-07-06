using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Instance", menuName = "Custom Types/Character Instance")]
public class CharacterInstance : ScriptableObject
{
    public Character character;
    public string attitude; // Custom enum
    public RectTransform position;
    public float fadeTime;  //Use negative to fade out
    //public List<string> transitions;    // Custom enum/scriptable object?
}