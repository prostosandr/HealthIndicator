using UnityEngine;

public class DamageButton : HealthButton
{
    [SerializeField] private int _damage;

    protected override void ChangeButtonText()
    {
        _buttonText.text = $"-{_damage} здоровья";

        _isDamage = true;
    }

    protected override void ChangeHealth()
    {
        _health.TakeDamage(_damage);
    }
}
