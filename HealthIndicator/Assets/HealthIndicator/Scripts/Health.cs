using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    private int _value;

    public int Value => _value;
    public int MaxValue => _maxValue;

    public event Action ValueChanged;

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

        ValueChanged?.Invoke();
    }
}
