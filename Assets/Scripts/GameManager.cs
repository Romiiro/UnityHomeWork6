using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private bool _gamePause = true;
    private int[] _currentCode = new int[3];
    private int[] _winCode = new int[3];

    public int[] GetCurrentCode()
    {
        return _currentCode;
    }

    public int GetNumberOfCurrentCode(int index)
    {
        return _currentCode[index];
    }

    public void SetCurrentCode(int[] code)
    {
        for (int i = 0; i < 3; i++)
        {
            _currentCode[i] = ValidateNumber(code[i]);
        }
    }

    public void SetNumberOfCurrentCode(int number, int index)
    {
        _currentCode[index] = ValidateNumber(number);
    }

    public void SetWinCode(int[] code)
    {
        for (int i = 0; i < 3; i++)
        {
            _winCode[i] = ValidateNumber(code[i]);
        }
    }

    private int ValidateNumber(int number) {
        if (number < 0) {
            return number += 10;
        }
        else if(number > 9) {
            return number -= 10;
        }

        return number;
    }
    public bool GamePause
    {
        get => _gamePause;
        set => _gamePause = value;
    }
}
