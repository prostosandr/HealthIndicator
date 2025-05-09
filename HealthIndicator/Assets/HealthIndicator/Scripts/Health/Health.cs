using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _minHealth;
    [SerializeField] private int _maxHealth;

    private int _healthValue;

    public int HealthValue => _healthValue;
    public int MaxHealth => _maxHealth;

    private void EqualizeHealth()
    {
        _healthValue = Mathf.Clamp(_healthValue, _minHealth, _maxHealth);
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            damage = -damage;

        _healthValue -= damage;

        EqualizeHealth();
    }

    public void Heal(int valueHeal)
    {
        if (valueHeal < 0)
            valueHeal = -valueHeal;

        _healthValue += valueHeal;

        EqualizeHealth();
    }
}
