using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCodeCommand : ICommand
{
    private readonly GameManager _gm;
    private readonly Tools _tool;
    private readonly GameScreen _game;
    private readonly int multiply;

    public ChangeCodeCommand(GameManager gm, Tools tool, GameScreen game, bool isGeneration)
    {
        _gm = gm;
        _tool = tool;
        _game = game;
        multiply = isGeneration ? -1 : 1;
    }

    public void Execute()
    {
        ChangeCode();
    }

    private void ChangeCode()
    {
        int[] tempCode = _gm.GetCurrentCode();

        for (int i = 0; i < 3; i++)
        {
            int tempNum = _gm.GetNumberOfCurrentCode(i) + GameSettings.ToolsImpact[_tool][i] * multiply;
            _gm.SetNumberOfCurrentCode(tempNum, i);
        }

        if (!_gm.GamePause) {
            _gm.CheckWin();
        }
        Debug.Log($"\n {_tool} {_gm.GetNumberOfCurrentCode(0)} {_gm.GetNumberOfCurrentCode(1)} {_gm.GetNumberOfCurrentCode(2)}");

        Debug.Log($"\nStart code: {_gm.StartCode[0]} {_gm.StartCode[1]} {_gm.StartCode[2]} ");
    }
}
