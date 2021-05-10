using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] private Slider _lifeSlider;

    private float _currentValue;
    private float _speed = 0.1f;
    private float _deltaLife = 0.1f;

    private float _maxLifeSliderValue = 1;
    private float _minLifeSliderValue = 0.1f;

    private int _frames = 255;
    
    public void Awake()
    {
        _currentValue = _lifeSlider.value;
    }

    public void ChangeValue(bool increase)
    {
        if (increase)
        {
            if (_currentValue < _maxLifeSliderValue)
                _currentValue += _deltaLife;
        }
        else
        {
            if (_currentValue > _minLifeSliderValue)
                _currentValue -= _deltaLife;
        }

        StartCoroutine(ChangeValue());
    }

    public IEnumerator ChangeValue()
    {
        for (int i = 0; i < _frames; i++)
        {
            _lifeSlider.value = Mathf.MoveTowards(_lifeSlider.value, _currentValue, Time.deltaTime * _speed);

            yield return null;
        }
    }
}
