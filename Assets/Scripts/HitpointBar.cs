using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HitpointBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private Coroutine _coroutine;
    private float _rate = 50f;

    private void Start()
    {
        _slider.maxValue = _player.MaxHealth;
        _slider.value = _player.MaxHealth;
    }

    private void OnEnable()
    {
        _player.HealthChange += OnChangeHealth;
    }

    private void OnDisable()
    {
        _player.HealthChange-= OnChangeHealth;
    }

    private void OnChangeHealth(float health)
    {
        _coroutine = StartCoroutine(ChangeHealthValue(health));
    }

    private IEnumerator ChangeHealthValue(float health)
    {
        while(_slider.value != health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.CurrentHealthPoint, _rate*Time.deltaTime);

            yield return null;  
        }
    }
}
