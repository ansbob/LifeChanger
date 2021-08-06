using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] private Slider _lifeSlider;

    private float _currentValue;
    private float _speed = 0.1f;

    private int _dividerForSlider = 100;

    public void ChangeValue(float lifeValue)
    {
        _currentValue = lifeValue / _dividerForSlider;

        StartCoroutine(ChangeSliderValue());
    }

    private IEnumerator ChangeSliderValue()
    {
        while (_lifeSlider.value != _currentValue)
        {
            _lifeSlider.value = Mathf.MoveTowards(_lifeSlider.value, _currentValue, Time.deltaTime * _speed);

            yield return null;
        }
    }
}
