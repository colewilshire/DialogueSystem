using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Custom Types/Character")]
public class Character : ScriptableObject
{
    public string characterName;
    public Sprite defaultPose;
}