using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettings
{
    private const int _minDifficultyLevel = 1;
    private const int _maxDifficultyLevel = 10;
    private static int _currentDifficultyLevel = 3;
    private static bool _eventIsEnabled = false;

    private static readonly Dictionary<Tools, int[]> _toolsImpact = new Dictionary<Tools, int[]>
    {
        {Tools.Rotate, new int[] {1, -1, 0}},
        {Tools.Knock, new int[] {-1, 2, -1}},
        {Tools.Kick, new int[] {-1, +1, +1}}
    };

    public static Dictionary<Tools, int[]> ToolsImpact => _toolsImpact;

    public static int MinDifficultyLevel => _minDifficultyLevel;

    public static int MaxDifficultyLevel => _maxDifficultyLevel;

    public static int CurrentDifficultyLevel
    {
        get => _currentDifficultyLevel;
        set => _currentDifficultyLevel = value;
    }

    public static bool EventIsEnabled => _eventIsEnabled;

    public static void ChangeEventEnabledStatus(bool value)
    {
        _eventIsEnabled = true;
    }


}
