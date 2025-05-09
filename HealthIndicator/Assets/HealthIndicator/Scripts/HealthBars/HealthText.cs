using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthText : MonoBehaviour
{
    private TextMeshProUGUI _textHealth;

    private void Awake()
    {
        _textHealth = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(int currentHealth, int maxHealth)
    {
        _textHealth.text = $"{currentHealth} / {maxHealth}";
    }
}