public class HealButton :HealthButton
{
    protected override void ChangeButtonText()
    {
        _buttonText.text = $"+{_amountHealthChange} ��������";

        _isDamage = false;
    }
}
