using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    private int _value;

    public int Value => _value;
    public int MaxValue => _maxValue;

    public event Action<int, int> ValueChanged;

    public void TakeDamage(int damage)
    {
        FixAmountHealthChange(damage);

        _value -= damage;

        EqualizeValue();
    }

    public void TakeHeal(int valueHeal)
    {
        FixAmountHealthChange(valueHeal);

        _value += valueHeal;

        EqualizeValue();   
    }

    private void FixAmountHealthChange(int amount)
    {
        if (amount < 0)
            amount = -amount;
    }

    private void EqualizeValue()
    {
        _value = Mathf.Clamp(_value, _minValue, _maxValue);

        ValueChanged?.Invoke(_value, _maxValue);
    }
}
