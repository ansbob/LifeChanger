using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] private Slider _lifeSlider;

    private float _currentValue;
    private float _speed = 0.1f;

    private int _frames = 255;

    public void ChangeValue()
    {
        _currentValue = Life.LifeValue / 100;

        StartCoroutine(ChangeSliderValue());
    }

    public IEnumerator ChangeSliderValue()
    {
        for (int i = 0; i < _frames; i++)
        {
            _lifeSlider.value = Mathf.MoveTowards(_lifeSlider.value, _currentValue, Time.deltaTime * _speed);

            yield return null;
        }
    }
}
