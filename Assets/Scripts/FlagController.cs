using System.Collections.Generic;
using UnityEngine;

public class FlagController : Singleton<FlagController>
{
    private Dictionary<string, bool> flags = new Dictionary<string, bool>();

    public bool CheckForFlags(string[] flagNames)
    {
        foreach (string flagName in flagNames)
        {
            if (!flags.ContainsKey(flagName) || !flags[flagName])
            {
                return false;
            }
        }

        return true;
    }

    public void ToggleFlags(string[] flagNames, bool state)
    {
        foreach (string flagName in flagNames)
        {
            flags[flagName] = state;
            Debug.Log(flagNames + "" + flags[flagName]);
        }
    }
}
