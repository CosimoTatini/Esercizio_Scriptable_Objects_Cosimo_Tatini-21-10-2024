using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats : MonoBehaviour
{
    public FloatVariable speed;
    public FloatVariable hp;
    public FloatVariable _maxHp;
    public FloatVariable damage;

    public Stringvariable playername;

    private void Awake()
    {
        hp.Value = _maxHp.Value;
    }

    public void TakeDamage(float amount)
    {
        hp.Value -= amount;
        hp.Value = Mathf.Clamp(hp.Value, 0, _maxHp.Value);
    }

  
}
