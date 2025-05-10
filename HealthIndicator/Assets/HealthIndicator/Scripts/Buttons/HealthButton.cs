using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI _buttonText;
    [SerializeField] protected Health _health;

    protected bool _isDamage;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();

        ChangeButtonText();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeHealth);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeHealth);
    }

    public void SetHealth(Health health)
    {
        _health = health;
    }

    protected abstract void ChangeButtonText();

    protected abstract void ChangeHealth();
}