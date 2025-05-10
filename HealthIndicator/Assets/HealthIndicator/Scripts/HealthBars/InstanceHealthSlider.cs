using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class InstanceHealthSlider : HealthBar
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public override void UpdateDrawing(float currentValue)
    {
        _slider.value = currentValue / MaxValue;
    }
}