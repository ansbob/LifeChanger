using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeChanger : MonoBehaviour
{
    [SerializeField] private Slider _life;

    private bool _increase;
    private bool _decrease;

    private float _currentValue;
    private float _speed = 0.1f;
    private float _distance = 0.1f;

    public void Change(bool increase)
    {
        if (increase)
            _increase = true;
        else
        {
            _increase = false;
            _decrease = true;
        }

        _currentValue = _life.value;
    }

    public void Update()
    {
        if (_increase)
            _life.value = Mathf.MoveTowards(_life.value, _currentValue + _distance, Time.deltaTime * _speed);
        else if (_decrease)
            _life.value = Mathf.MoveTowards(_life.value, _currentValue - _distance, Time.deltaTime * _speed);
    }
}
