using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LifeIndicator _lifeIndicator;
    private Life _life = new Life();

    private void Start()
    {
        _life.OnChanged += _lifeIndicator.ChangeValue;
    }

    public void ChangeLife(bool increase)
    {
        if (increase)
            _life.Change(true);
        else
            _life.Change(false);
    }
}
