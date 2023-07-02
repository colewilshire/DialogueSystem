using System.Collections.Generic;

public class FlagController : Singleton<FlagController>
{
    public Dictionary<string, bool> Flags { get; private set; } = new Dictionary<string, bool>();

    public bool CheckForFlags(List<string> flagNames)
    {
        foreach (string flagName in flagNames)
        {
            if (!Flags.ContainsKey(flagName) || !Flags[flagName])
            {
                return false;
            }
        }

        return true;
    }

    public void ToggleFlags(List<string> flagNames, bool state)
    {
        foreach (string flagName in flagNames)
        {
            Flags[flagName] = state;
        }
    }

    public void LoadFlags(List<string> flagNames)
    {
        Flags = new Dictionary<string, bool>();

        ToggleFlags(flagNames, true);
    }
}
