using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private int _valueHeal;

    protected override void ChangeButtonText()
    {
        ButtonText.text = $"+{_valueHeal} ��������";
    }

    protected override void ChangeHealth()
    {
        _health.TakeHeal(_valueHeal);
    }
}
