using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : MonoBehaviour
{
    [SerializeField] protected int _amountHealthChange;
    [SerializeField] protected TextMeshProUGUI _buttonText;

    private Button _button;

    public event Action<int> ButtonClicked;

    private void Awake()
    {
        Inicialize();
    }

    public virtual void Inicialize()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeHealth);

        _buttonText.text = $"-{_amountHealthChange} здоровья";
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(ChangeHealth);
    }

    private void ChangeHealth()
    {
        if (_amountHealthChange >= 0)
            ButtonClicked?.Invoke(_amountHealthChange);
    }
}
