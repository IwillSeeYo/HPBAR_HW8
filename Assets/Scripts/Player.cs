using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float _maxHealth = 100;

    private float _currentHealthPoint;

    public event Action<float> HealthChange;

    public float MaxHealth => _maxHealth;
    public float CurrentHealthPoint => _currentHealthPoint;

    private void Start()
    {
        _currentHealthPoint = _maxHealth;
        HealthChange?.Invoke(CurrentHealthPoint);
    }

    public void TakeDamage(float damade)
    {
        _currentHealthPoint -= damade;
        HealthChange?.Invoke(CurrentHealthPoint);

        if (_currentHealthPoint < 0)
            _currentHealthPoint = 0;
    }

    public void TakeHeal(float heal)
    {
        _currentHealthPoint += heal;
        HealthChange?.Invoke(CurrentHealthPoint);

        if (_currentHealthPoint > _maxHealth)
            _currentHealthPoint = _maxHealth;
    }
}
