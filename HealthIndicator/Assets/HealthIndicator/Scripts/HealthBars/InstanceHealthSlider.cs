using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class InstanceHealthSlider : MonoBehaviour
{
    protected Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public virtual void UpdateSliderValue(int health, int maxHealth)
    {
        _slider.value = (float)health / (float)maxHealth;
    }
}