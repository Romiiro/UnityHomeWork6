using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCommand : ICommand {
    private bool _losed;
    private Menu _menu;
    private GameManager _gm;

    public EndGameCommand(Menu menu, GameManager gm, bool losed) {
        _menu = menu;
        _gm = gm;
        _losed = losed;
    }

    public void Execute() {
        EndGame();
    }

    private void EndGame() {
        _gm.GamePause = true;
 
        if (_losed) {
            _menu.ChangeMenuScreen(_menu.LosePanel);
        }
        else {
            _menu.ChangeMenuScreen(_menu.WinPanel);
        }
    }


}
