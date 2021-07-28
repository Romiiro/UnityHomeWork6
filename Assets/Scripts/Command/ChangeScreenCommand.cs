using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreenCommand : ICommand
{

    private GameObject _targetScreen;
    private GameObject _currentScreen;
    private Menu _menu;
    
    public ChangeScreenCommand(GameObject screen, Menu menu)
    {
        _targetScreen = screen;
        _menu = menu;
        _currentScreen = _menu.CurrrentScreen;
    }

    public void Execute()
    {
        HideCurrentScreen();
        ShowTargetScreen();
    }

    private void HideCurrentScreen()
    {
        _currentScreen.gameObject.SetActive(false);
    }

    private void ShowTargetScreen()
    {
        _targetScreen.gameObject.SetActive(true);
    }
}
