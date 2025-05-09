using System.Collections;
using UnityEngine;

public class SmoothHealthBar : InstanceHealthSlider
{
    [SerializeField] private float _smoothDuration;

    private Coroutine _coroutine;

    public override void UpdateDrawing(int health, int maxHealth)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(ChangeValueSmooth(health, maxHealth));
    }

    private IEnumerator ChangeValueSmooth(int health, int maxHealth)
    {
        float currentSliderValue = _slider.value;

        float elapsed = 0f;

        while (_slider.value != health)
        {
            elapsed += Time.deltaTime;

            float thridParameter = Mathf.Clamp01(elapsed / _smoothDuration);

            _slider.value = Mathf.Lerp(currentSliderValue, (float)health / (float)maxHealth, thridParameter);

            yield return null;
        }

        _coroutine = null;
    }
}