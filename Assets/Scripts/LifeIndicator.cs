using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] private Slider _lifeSlider;

    private Life _life = new Life();

    private float _currentValue;
    private float _speed = 0.1f;
    private float _deltaLife = 0.1f;

    private float _maxLifeSliderValue = 1;
    private float _minLifeSliderValue = 0.1f;
    

    public void Awake()
    {
        _currentValue = _lifeSlider.value;
    }

    public void ChangeValue(bool increase)
    {
        if (increase)
        {
            _life.Increase();

            if (_currentValue < _maxLifeSliderValue)
                _currentValue += _deltaLife;
        }
        else
        {
            _life.Decrease();

            if (_currentValue > _minLifeSliderValue)
                _currentValue -= _deltaLife;
        }
    }

    public void Update()
    {
        if (_lifeSlider.value != _currentValue)
            _lifeSlider.value = Mathf.MoveTowards(_lifeSlider.value, _currentValue, Time.deltaTime * _speed);
    }
}
