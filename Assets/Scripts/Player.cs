using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LifeIndicator _lifeIndicator;
    private Life _life = new Life();

    public void ChangeLife(bool increase)
    {
        if (increase)
            _life.Increase();
        else
            _life.Decrease();

        _lifeIndicator.ChangeValue(_life);
    }
}
