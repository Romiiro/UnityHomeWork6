using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScreen : MonoBehaviour
{
    [SerializeField] private GameObject _firstNumberText;
    [SerializeField] private GameObject _secondNumberText;
    [SerializeField] private GameObject _thirdNumberText;
    [SerializeField] private GameObject _gameMenuObject;
    [SerializeField] private Text _timerText;
    [SerializeField] private TimeHandler _timeHandler;
    [SerializeField] private Menu _menu;
    [SerializeField] private GameManager _gm;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double restTime = _timeHandler.GetRestOfTime();
        _timerText.text = restTime.ToString("##.");
        if (restTime <= 0)
        {
            var com = new EndGameCommand(_menu, _gm, true);
            com.Execute();
        }

    }
}
