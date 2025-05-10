using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected float MaxValue { get; private set; }

    private void Start()
    {
        MaxValue = _health.MaxValue;
    }

    private void OnEnable()
    {
        _health.ValueChanged += UpdateDrawing;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= UpdateDrawing;
    }

    public abstract void UpdateDrawing(float currentValue);
}
