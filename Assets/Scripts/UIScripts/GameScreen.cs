using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameScreen : MonoBehaviour
{
    [SerializeField] private Text[] _codeNumberTexts;
    [SerializeField] private Image[] _codeNumberBackgrounds;
    [SerializeField] private GameObject _gameMenuObject;
    [SerializeField] private Text _timerText;
    [SerializeField] private TimeHandler _timeHandler;
    [SerializeField] private Menu _menu;
    [SerializeField] private GameManager _gm;
    [SerializeField] private Button rotateButton;
    [SerializeField] private Button knockButton;
    [SerializeField] private Button kickButton;
    
    private Color _rightNumberColor = new Color(
        0, 246, 0, 121);
    private Color _defaultNumberColor = new Color(
        255, 255, 255, 121);


    // Start is called before the first frame update
    void Start()
    {
        rotateButton.onClick.AddListener(delegate { ChangeCode(Tools.Rotate);});
        knockButton.onClick.AddListener(delegate{ChangeCode(Tools.Knock);});
        kickButton.onClick.AddListener(delegate{ChangeCode(Tools.Kick);});
    }

    private void ChangeCode(Tools tool)
    {
        var com = new ChangeCodeCommand(_gm, tool, this, false);
        com.Execute();
    }

    // Update is called once per frame
    private void Update()
    {
        double restTime = _timeHandler.GetRestOfTime();
        _timerText.text = restTime.ToString("##.");
        if (restTime <= 0)
        {
            var com = new EndGameCommand(_menu, _gm, true);
            com.Execute();
        }
    }

    public void DisplayCode()
    {
        int[] code = _gm.GetCurrentCode();
        int[] winCode = _gm.GetWinCode();
        for (int i = 0; i < 3; i++)
        {
            if (code[i] == winCode[i])
            {
                _codeNumberBackgrounds[i].color = new Color(
                    0, 246, 0, 121);
            }
            else
            {
                _codeNumberBackgrounds[i].color = new Color(
                    255, 255, 255, 121);
            }
            _codeNumberTexts[i].text = code[i].ToString();
        }
    }

    public void DisplayNumber(int index, bool numberIsRight)
    {
        _codeNumberBackgrounds[index].color = numberIsRight ? 
            _rightNumberColor : _defaultNumberColor;
        _codeNumberTexts[index].text = _gm.GetNumberOfCurrentCode(index).ToString();
    }
}
