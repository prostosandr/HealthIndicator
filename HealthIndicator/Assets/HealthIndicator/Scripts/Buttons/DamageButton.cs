public class DamageButton : HealthButton
{
    protected override void ChangeButtonText()
    {
        _buttonText.text = $"-{_amountHealthChange} здоровья";

        _isDamage = true;
    }
}
