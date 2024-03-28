using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Layers
{
    Ground
}

public enum Tags
{
    Player,
    Item
}

public static class Tool
{
    public static string GetLayer(Layers _value)
    {
        return _value.ToString();
    }

    public static string GetTag(Tags _value)
    {
        return _value.ToString();
    }
}