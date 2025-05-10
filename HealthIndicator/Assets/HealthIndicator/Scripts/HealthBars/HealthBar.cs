using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.ValueChanged += UpdateDrawing;
    }

    private void OnDisable()
    {
        _health.ValueChanged -= UpdateDrawing;
    }

    public abstract void UpdateDrawing();
}
