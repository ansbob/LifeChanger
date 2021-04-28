using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    [SerializeField] private Slider _life;

    private float _currentValue;
    private float _speed = 0.1f;
    private float _deltaLife;

    public void Change(bool increase)
    {
        if (increase)
            _deltaLife = 0.1f;
        else
            _deltaLife = -0.1f;

        _currentValue = _life.value;
    }

    public void Awake()
    {
        _deltaLife = 0;
        _currentValue = _life.value;
    }

    public void Update()
    {
        _life.value = Mathf.MoveTowards(_life.value, _currentValue + _deltaLife, Time.deltaTime * _speed);
    }
}

