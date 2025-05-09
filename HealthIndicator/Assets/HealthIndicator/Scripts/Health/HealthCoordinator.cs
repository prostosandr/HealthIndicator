using UnityEngine;

public class HealthCoordinator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private HealthRenderer _healthRenderer;

    [SerializeField] private DamageButton _damageButton;
    [SerializeField] private HealButton _healButton;

    private void OnEnable()
    {
        _damageButton.ButtonClicked += DealDamage;
        _healButton.ButtonClicked += Heal;
    }

    private void OnDisable()
    {
        _damageButton.ButtonClicked -= DealDamage;
        _healButton.ButtonClicked -= Heal;
    }

    private void DealDamage(int damage)
    {
        _health.TakeDamage(damage);

        _healthRenderer.UpdateUI(_health.HealthValue, _health.MaxHealth);
    }

    private void Heal(int valueHeal)
    {
        _health.Heal(valueHeal);

        _healthRenderer.UpdateUI(_health.HealthValue, _health.MaxHealth);
    }
}