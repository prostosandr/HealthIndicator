using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : DamageButton
{
    public override void Inicialize()
    {
        base.Inicialize();

        _buttonText.text = $"+{_amountHealthChange} здоровья";
    }
}
