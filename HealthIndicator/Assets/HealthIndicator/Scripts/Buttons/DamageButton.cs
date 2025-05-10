using UnityEngine;

public class DamageButton : HealthButton
{
    [SerializeField] private int _damage;

    protected override void ChangeButtonText()
    {
        ButtonText.text = $"-{_damage} здоровья";
    }

    protected override void ChangeHealth()
    {
        Health.TakeDamage(_damage);
    }
}
