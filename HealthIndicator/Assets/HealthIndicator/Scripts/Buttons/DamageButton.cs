public class DamageButton : HealthButton
{
    public override void ChangeButtonText()
    {
        _buttonText.text = $"-{_amountHealthChange} здоровья";
    }
}
