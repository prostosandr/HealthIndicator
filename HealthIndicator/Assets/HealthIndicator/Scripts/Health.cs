using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _minValue;
    [SerializeField] private float _maxValue;

    private float _value;

    public float Value => _value;
    public float MaxValue => _maxValue;

    public event Action<float> ValueChanged;

    public void TakeDamage(int damage)
    {
        if (damage >= 0)
        {
            _value -= damage;

            EqualizeValue();
        }
    }

    public void TakeHeal(int valueHeal)
    {
        if (valueHeal >= 0)
        {
            _value += valueHeal;

            EqualizeValue();
        }
    }

    private void EqualizeValue()
    {
        _value = Mathf.Clamp(_value, _minValue, _maxValue);

        ValueChanged?.Invoke(_value);
    }
}
