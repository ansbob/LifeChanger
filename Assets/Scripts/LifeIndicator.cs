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
    

    public void Awake()
    {
        _currentValue = _lifeSlider.value;
    }

    public void ChangeValue(bool increase)
    {
        if (increase)
        {
            _life.ChangeLifeValue(true);
            _currentValue += _deltaLife;
        }
        else
        {
            _life.ChangeLifeValue(false);
            _currentValue -= _deltaLife;
        }
    }

    public void Update()
    {
        if (_lifeSlider.value != _currentValue)
            _lifeSlider.value = Mathf.MoveTowards(_lifeSlider.value, _currentValue, Time.deltaTime * _speed);
    }
}
