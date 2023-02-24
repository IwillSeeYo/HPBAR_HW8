using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HitpointBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private float _rate = 50f;

    private void Start()
    {
        _slider.maxValue = _player.MaxHealth;
        _slider.value = _player.CurrentHealthPoint;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _player.CurrentHealthPoint, _rate * Time.deltaTime);
    }
}
