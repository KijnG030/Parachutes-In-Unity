using UnityEngine;
using System;

public static class GameEvents
{
    public static Action<int> OnScoreAdded;
    public static Action<int> OnLivesChanged;
}
