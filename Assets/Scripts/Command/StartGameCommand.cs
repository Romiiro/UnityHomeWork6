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
        _gm.GamePause = false;
    }
}
