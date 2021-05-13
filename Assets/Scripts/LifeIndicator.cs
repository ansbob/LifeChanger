using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Life))]
public class LifeIndicator : MonoBehaviour
{
    [SerializeField] private Slider _lifeSlider;

    private float _currentValue;
    private float _speed = 0.1f;

    private int _dividerForSlider = 100;

    private Life _life;

    private void Awake()
    {
        _life = gameObject.GetComponent<Life>();
    }

    public void ChangeValue()
    {
        _currentValue = _life.LifeValue / _dividerForSlider;

        StartCoroutine(ChangeSliderValue());
    }

    public IEnumerator ChangeSliderValue()
    {
        while (_lifeSlider.value != _currentValue)
        {
            _lifeSlider.value = Mathf.MoveTowards(_lifeSlider.value, _currentValue, Time.deltaTime * _speed);

            yield return null;
        }
    }
}
