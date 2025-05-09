using UnityEngine;

public class HealthRenderer : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private HealthBarArray _healthBarArray;

    private HealthBar[] _healthBars;

    private void Awake()
    {
        _healthBars = _healthBarArray.Bars;
    }

    private void OnEnable()
    {
        _health.ValueChanged += UpdateUI;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= UpdateUI;
    }

    private void UpdateUI(int healthValue, int maxHealth)
    {
        foreach (HealthBar healthBar in _healthBars)
        {
            healthBar.UpdateDrawing(healthValue, maxHealth);
        }
    }
}
