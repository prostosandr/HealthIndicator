public class HealButton :HealthButton
{
    protected override void ChangeButtonText()
    {
        _buttonText.text = $"+{_amountHealthChange} здоровья";

        _isDamage = false;
    }
}
