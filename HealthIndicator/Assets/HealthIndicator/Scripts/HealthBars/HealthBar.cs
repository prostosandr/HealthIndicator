using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] private Health Health;

    protected float MaxValue;

    private void Start()
    {
        MaxValue = Health.MaxValue;
    }

    private void OnEnable()
    {
        Health.ValueChanged += UpdateDrawing;
    }

    private void OnDisable()
    {
        Health.ValueChanged -= UpdateDrawing;
    }

    public abstract void UpdateDrawing(float currentValue);
}
