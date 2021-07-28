using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Menu _menu;

    private void Start()
    {
        _startGameButton.onClick.AddListener(delegate{_menu.ChangeMenuScreen(_menu.StartGameMenu);});
    }

}
