using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public float _life = 50;

    private const float _maxValueLimiter = 91;
    private const float _minValueLimiter = 9;

    private float _deltaLife = 10;

    public void ChangeLifeValue(bool increase)
    {
        if (increase && _life < _maxValueLimiter)
            _life += _deltaLife;
        else if (!increase && _life > _minValueLimiter)
            _life -= _deltaLife;
    }
}
