using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameCommand : ICommand
{
    private GameManager _gm;

    public StartGameCommand(GameManager gm)
    {
        _gm = gm;
    }
    public void Execute()
    {
        StartGame();
    }

    private void StartGame()
    {
        _gm.SetWinCode(CodeGenerator.GenerateWinCode());
        _gm.SetCurrentCode(_gm.GetWinCode());
        CodeGenerator.GenerateStartCode(_gm);
        _gm.GamePause = false;
    }


}
