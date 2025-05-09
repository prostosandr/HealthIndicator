using UnityEngine;

public class HealthRenderer : MonoBehaviour
{
    [SerializeField] private HealthText _healthText;
    [SerializeField] private InstanceHealthSlider _instanceHealthSlider;
    [SerializeField] private SmoothHealthBar _smoothHealthBar;

    public void UpdateUI(int healthValue, int maxHealth)
    {
        _healthText.UpdateText(healthValue, maxHealth);
        _instanceHealthSlider.UpdateSliderValue(healthValue, maxHealth);
        _smoothHealthBar.UpdateSliderValue(healthValue, maxHealth);
    }
}
