using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Life _life;

    public void ChangeLife(bool increase)
    {
        if (increase)
            _life.Change(true);
        else
            _life.Change(false);
    }
}
