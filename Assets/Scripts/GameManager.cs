using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Menu _menu;
    [SerializeField] private GameScreen game;

    private bool _gamePause = true;
    private int[] _startCode = new int[3];
    private int[] _currentCode = new int[3];
    private int[] _winCode = new int[3];


    public int[] StartCode {
        get {
            return _startCode;
        }
        set {
            _startCode = value;
        }
    }

    public Menu Menu => _menu;

    public int[] GetCurrentCode()
    {
        return _currentCode;
    }

    public int[] GetWinCode()
    {
        return _winCode;
    }

    public int GetNumberOfCurrentCode(int index)
    {
        return _currentCode[index];
    }

    public void SetCurrentCode(int[] code)
    {
        for (int i = 0; i < 3; i++)
        {
            SetNumberOfCurrentCode(code[i], i);
        }
    }

    public void SetNumberOfCurrentCode(int number, int index) {
        _currentCode[index] = ValidateNumber(number);
        game.DisplayNumber(index, CheckEquality(index));
    }

    private bool CheckEquality(int index) {
        bool equals = _currentCode[index] == _winCode[index];
        
        return _currentCode[index] == _winCode[index];
    }

    public void CheckWin()
    {
        if(_winCode.SequenceEqual(_currentCode))
            Menu.ChangeMenuScreen(Menu.WinPanel);
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
