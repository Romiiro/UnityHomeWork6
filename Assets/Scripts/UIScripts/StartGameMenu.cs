using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameMenu : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _difficultySelectButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Menu _menu;
    
    private void Start()
    {
        _startGameButton.onClick.AddListener(
            delegate{_menu.ChangeMenuScreen(_menu.GamePanel);});
        _difficultySelectButton.onClick.AddListener(
            delegate{_menu.ChangeMenuScreen(_menu.DifficultySelectMenu);});
        _mainMenuButton.onClick.AddListener(
            delegate{_menu.ChangeMenuScreen(_menu.MainMenu);});
    }


}
