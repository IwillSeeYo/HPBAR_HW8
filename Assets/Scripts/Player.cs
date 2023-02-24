using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _currentHealthPoint;
    private float _value = 10f;

    public float MaxHealth => _maxHealth;
    public float CurrentHealthPoint => _currentHealthPoint;

    private void Start()
    {
        _currentHealthPoint = _maxHealth;
    }

    private void Update()
    {
        if(_currentHealthPoint > _maxHealth)
            _currentHealthPoint = _maxHealth;
        else if(_currentHealthPoint <0)
            _currentHealthPoint = 0;

    }

    public void TakeDamage()
    {
        _currentHealthPoint -= _value;
    }

    public void TakeHeal()
    {
        _currentHealthPoint += _value;
    }
}
