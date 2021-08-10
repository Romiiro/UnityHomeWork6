using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameMenu : MonoBehaviour {
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private Menu _menu;
    [SerializeField] private GameManager _gm;
    [SerializeField] private TimeHandler _timeHandler;

    private void Start()
    {
        _restartButton.onClick.AddListener(Restart);
        _mainMenuButton.onClick.AddListener(ReturnToMainMenu);
        
        if(_nextLevelButton != null) {
            _nextLevelButton.onClick.AddListener(NextLevelStart);
        }
    }

    private void Restart()
    {
        var com = new RestartGameCommand(_menu, _gm, _timeHandler);
        com.Execute();
    }

    private void NextLevelStart()
    {

    }

    private void ReturnToMainMenu()
    {

    }
}
