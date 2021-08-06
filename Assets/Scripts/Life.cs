using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    private float _life = 50;
    private float _deltaLife = 10;

    private const float _maxValueLimiter = 91;
    private const float _minValueLimiter = 9;

    public delegate void LifeHandler(float life);
    public event LifeHandler OnChanged;

    public void Change(bool increase)
    {
        if (increase && _life < _maxValueLimiter)
            _life += _deltaLife;
        else if (!increase && _life > _minValueLimiter)
            _life -= _deltaLife;

        OnChanged?.Invoke(_life);
    }
}
