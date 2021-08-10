using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGameCommand : ICommand {

    private Menu _menu;
    private GameManager _gm;
    private TimeHandler _timeHandler;

    public RestartGameCommand(Menu menu, GameManager gm, TimeHandler th)
    {
        _menu = menu;
        _gm = gm;
        _timeHandler = th;
    }

    public void Execute() {
        RestartGame();
    }

    private void RestartGame()
    {
        _menu.ChangeMenuScreen(_menu.GamePanel);
        _gm.SetCurrentCode(_gm.StartCode);
        _timeHandler.ResetTimer();
        _gm.GamePause = false;
    }
}
