using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float _maxHealth = 100;
    private const float _minHealth = 0;

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
        _currentHealthPoint = Mathf.Clamp(_currentHealthPoint - damade, _minHealth, _maxHealth);
        HealthChange?.Invoke(CurrentHealthPoint);
    }

    public void TakeHeal(float heal)
    {
        _currentHealthPoint = Mathf.Clamp(_currentHealthPoint + heal, _minHealth, _maxHealth);
        HealthChange?.Invoke(CurrentHealthPoint);
    }
}
