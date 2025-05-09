public class HealButton :HealthButton
{
    public override void ChangeButtonText()
    {
        _buttonText.text = $"+{_amountHealthChange} здоровья";
    }
}
