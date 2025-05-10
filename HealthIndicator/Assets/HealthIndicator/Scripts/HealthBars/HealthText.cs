using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthText : HealthBar
{
    private TextMeshProUGUI _textHealth;

    private void Awake()
    {
        _textHealth = GetComponent<TextMeshProUGUI>();
    }

    public override void UpdateDrawing(float currentValue)
    {
        _textHealth.text = $"{currentValue} / {MaxValue}";
    }
}