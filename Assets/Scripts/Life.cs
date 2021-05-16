using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    private float _life = 50;
    private float _deltaLife = 10;

    private const float _maxValueLimiter = 91;
    private const float _minValueLimiter = 9;

    public float LifeValue => _life;

    public void Increase()
    {
        if (_life < _maxValueLimiter)
            _life += _deltaLife;
    }

    public void Decrease()
    {
        if (_life > _minValueLimiter)
            _life -= _deltaLife;
    }
}
