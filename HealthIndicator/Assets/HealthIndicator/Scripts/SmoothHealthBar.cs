using System.Collections;
using UnityEngine;

public class SmoothHealthBar : InstanceHealthSlider
{
    [SerializeField] private float _smoothDuration;

    private Coroutine _coroutine;

    private IEnumerator changeValueSmooth(int health, int maxHealth)
    {
        float currentSliderValue = _slider.value;

        float elapsed = 0f;

        while (_slider.value != health)
        {
            elapsed += Time.deltaTime;

            float thridParametr = Mathf.Clamp01(elapsed / _smoothDuration);

            _slider.value = Mathf.Lerp(currentSliderValue, (float)health / (float)maxHealth, thridParametr);

            yield return null;
        }

        _coroutine = null;
    }

    public override void UpdateSliderValue(int health, int maxHealth)
    {
        if(_coroutine  != null)
            StopCoroutine( _coroutine);

        _coroutine = StartCoroutine(changeValueSmooth(health, maxHealth));
    }
}
