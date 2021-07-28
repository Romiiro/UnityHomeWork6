using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _startGameMenu;
    [SerializeField] private GameObject _difficultySelectMenu;
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _gamePauseMenu;

    private GameObject _currentScreen;
    
    public GameObject CurrrentScreen => _currentScreen;

    public GameObject MainMenu => _mainMenu;

    public GameObject StartGameMenu => _startGameMenu;

    public GameObject GamePauseMenu => _gamePauseMenu;

    public GameObject GamePanel => _gamePanel;

    public GameObject DifficultySelectMenu => _difficultySelectMenu;

    public void ChangeMenuScreen(GameObject screen)
    {
        var com = new ChangeScreenCommand(screen, this);
        com.Execute();
        _currentScreen = screen;
    }

    private void Start()
    {
        _currentScreen = _mainMenu;
    }
}
