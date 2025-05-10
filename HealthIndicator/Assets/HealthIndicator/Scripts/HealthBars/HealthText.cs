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

    public override void UpdateDrawing()
    {
        _textHealth.text = $"{_health.Value} / {_health.MaxValue}";
    }
}