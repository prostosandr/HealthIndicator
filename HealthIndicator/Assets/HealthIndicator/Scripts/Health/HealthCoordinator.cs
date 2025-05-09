using UnityEngine;

public class HealthCoordinator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private ButtonsArray _buttonsArray;

    private HealthButton[] _healthButtons;

    private void Awake()
    {
        _healthButtons = _buttonsArray.HealthButtons;
    }

    private void OnEnable()
    {
        foreach (HealthButton healthButton in _healthButtons)
        {
            healthButton.ButtonClicked += ChangeHealth;
        }
    }

    private void OnDisable()
    {
        foreach (HealthButton healthButton in _healthButtons)
        {
            healthButton.ButtonClicked -= ChangeHealth;
        }
    }

    private void ChangeHealth(int value, bool isDamage)
    {
        if (isDamage)
            _health.TakeDamage(value);
        else
            _health.TakeHeal(value);
    }
}