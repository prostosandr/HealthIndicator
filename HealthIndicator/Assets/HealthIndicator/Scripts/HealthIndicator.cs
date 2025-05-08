using UnityEngine;

public class HealthIndicator : MonoBehaviour
{
    [SerializeField] private DamageButton _damageButton;
    [SerializeField] private HealButton _healButton;
    [SerializeField] private HealthText _healthText;
    [SerializeField] private InstanceHealthSlider _instanceHealthSlider;
    [SerializeField] private SmoothHealthBar _smoothHealthBar;
    [SerializeField] private int _minHealth;
    [SerializeField] private int _maxHealth;

    private int _health;

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
        _health -= damage;

        EqaulizeHealth();
    }

    private void Heal(int valueHeal)
    {
        _health += valueHeal;

        EqaulizeHealth();
    }

    private void EqaulizeHealth()
    {
        _health = Mathf.Clamp(_health, _minHealth, _maxHealth);

        UpdateUI();
    }

    private void UpdateUI()
    {
        _healthText.UpdateText(_health, _maxHealth);
        _instanceHealthSlider.UpdateSliderValue(_health, _maxHealth);
        _smoothHealthBar.UpdateSliderValue(_health, _maxHealth);
    }
}
