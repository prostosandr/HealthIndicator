using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class InstanceHealthSlider : HealthBar
{
    protected Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public override void UpdateDrawing()
    {
        _slider.value = (float)_health.Value / (float)_health.MaxValue;
    }
}