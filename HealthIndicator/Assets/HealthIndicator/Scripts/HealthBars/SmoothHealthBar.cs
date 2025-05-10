using System.Collections;
using UnityEngine;

public class SmoothHealthBar : InstanceHealthSlider
{
    [SerializeField] private float _smoothDuration;

    private Coroutine _coroutine;

    public override void UpdateDrawing()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(ChangeValueSmooth());
    }

    private IEnumerator ChangeValueSmooth()
    {
        float currentSliderValue = _slider.value;

        float elapsed = 0f;

        while (_slider.value != _health.Value)
        {
            elapsed += Time.deltaTime;

            float thridParameter = Mathf.Clamp01(elapsed / _smoothDuration);

            _slider.value = Mathf.Lerp(currentSliderValue, (float)_health.Value / (float)_health.MaxValue, thridParameter);

            yield return null;
        }

        _coroutine = null;
    }
}