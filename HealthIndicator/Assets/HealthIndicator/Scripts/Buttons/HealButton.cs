using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private int _valueHeal;

    protected override void ChangeButtonText()
    {
        _buttonText.text = $"+{_valueHeal} здоровья";

        _isDamage = true;
    }

    protected override void ChangeHealth()
    {
        _health.TakeHeal(_valueHeal);
    }
}
