using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI ButtonText;
    [SerializeField] protected Health _health;

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

    protected abstract void ChangeButtonText();

    protected abstract void ChangeHealth();
}