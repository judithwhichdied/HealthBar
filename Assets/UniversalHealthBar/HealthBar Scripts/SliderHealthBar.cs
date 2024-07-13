using System;
using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBar : MonoBehaviour
{
    [SerializeField] protected PlayerHealth _playerHealth;
    [SerializeField] protected Slider _bar;

    public event Action HealthChanged;

    protected virtual void Start()
    {
        _bar.minValue = _playerHealth.MinHealth;
        _bar.maxValue = _playerHealth.MaxHealth;
        _bar.value = _bar.maxValue;
    }

    protected virtual void Update()
    {
        HealthChanged?.Invoke();
    }

    protected virtual void OnEnable()
    {
        HealthChanged += FillBar;
    }

    protected virtual void OnDisable()
    {
        HealthChanged -= FillBar;
    }

    private void FillBar()
    {
        float filledArea = _playerHealth.CurrentHealth;

        _bar.value = filledArea;
    }
}
