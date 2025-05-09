using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealthButton : MonoBehaviour
{
    [SerializeField] protected int _amountHealthChange;
    [SerializeField] protected TextMeshProUGUI _buttonText;

    private Button _button;

    public event Action<int> ButtonClicked;

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

    private void ChangeHealth()
    {
        ButtonClicked?.Invoke(_amountHealthChange);
    }

    public virtual void ChangeButtonText()
    {
        _buttonText.text = $"{_amountHealthChange} здоровья";
    }
}