using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHandler : MonoBehaviour
{
    private double _startTime = 60;
    private double _currentTime;
    private double _passedTime = 0;
    [SerializeField] private GameManager _gm;

    public double GetRestOfTime()
    {
        return _startTime - _passedTime;
    }

    private void FixedUpdate()
    {
        if (!_gm.GamePause)
        {
            _passedTime += Time.deltaTime;
        }
    }

    public void ResetTimer()
    {
        _passedTime = 0;
    }
}
