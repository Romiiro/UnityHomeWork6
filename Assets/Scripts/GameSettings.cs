using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettings
{
    private const int _minDifficultyLevel = 1;
    private const int _maxDifficultyLevel = 10;
    private static int _currentDifficultyLevel = 1;
    private static bool _eventIsEnabled = false;

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
